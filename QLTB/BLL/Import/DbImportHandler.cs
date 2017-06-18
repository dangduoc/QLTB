using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using QLTB.Model;
namespace QLTB.Handler
{
    public class DbImportHandler
    {
        private string PATH = Path.GetDirectoryName(Application.ExecutablePath);
        public List<string> GetSourceHeader(string path, int headerIndex, int sheetIndex)
        {

            var headers = new List<string>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[sheetIndex];
            //get all worksheet
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int colCount = xlRange.Columns.Count;
            for (int j = 0; j < colCount; j++)
            {
                headers.Add(((Excel.Range)xlRange.Cells[headerIndex, j + 1]).Value.ToString());
            }
            return headers;
            #region Clean
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();

            Marshal.ReleaseComObject(xlApp);
            #endregion
        }
        public List<string> GetSheets(string path)
        {
            var result = new List<string>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            //get all worksheet
            foreach (Excel.Worksheet item in xlWorkbook.Sheets)
            {
                result.Add(item.Name);
            }
            return result;
            #region Clean
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background

            //close and release
            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();

            Marshal.ReleaseComObject(xlApp);
            #endregion
        }
        public List<ThietBiImport> Read(string path, int headerRow, int sheet)
        {
            List<ThietBiImport> lst = new List<ThietBiImport>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[sheet];

            Excel.Range xlRange = xlWorksheet.UsedRange;
            //
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            //
            for (int i = 1 + headerRow; i <= rowCount; i++)
            {
                var tmp = new ThietBiImport();
                for (int j = 0; j < colCount; j++)
                {
                    Type type = typeof(ThietBiImport).GetProperties()[j].PropertyType;

                    var item = Convert.ChangeType(((Excel.Range)xlRange.Cells[i, j + 1]).Value.ToString(), type);
                    if (item != null)
                    {
                        type.GetProperties()[j].SetValue(tmp, item);
                    }
                }
                lst.Add(tmp);
            }
            #region Clean
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();

            Marshal.ReleaseComObject(xlApp);
            #endregion
            return lst;
        }
    }
}