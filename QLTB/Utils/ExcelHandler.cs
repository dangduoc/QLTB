using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QLTB.Utils
{
    public class ExcelHandler<T> where T : class
    {

        private string PATH = Path.GetDirectoryName(Application.ExecutablePath);
        public List<string> GetSourceHeader(string path,int headerIndex,int sheetIndex)
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
        public Response<List<T>> Read(string path, int headerRow, int sheet, IList<T> lst)
        {
            Response<List<T>> result = new Response<List<T>>();
            List<T> danhsach = new List<T>();
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
                var tmp = Activator.CreateInstance<T>();
                //for (int j = 0; j < colCount; j++)
                //{
                //    Type type = tmp.GetType().GetProperties()[j].PropertyType;
                //    var item = Convert.ChangeType(((Excel.Range)xlRange.Cells[i, j + 1]).Value.ToString(), type);
                //    tmp.GetType().GetProperties()[j].SetValue(tmp, item);
                //}
                result.SucceedResults += 1;
                danhsach.Add(tmp);
                //result.Add(tmp);
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
            result.Data = danhsach;
            return result;
        }
        public void Write(List<string> header, List<T> list, string path, int code)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Writing header
            for (int i = 1; i <= header.Count; i++)
            {
                xlWorkSheet.Cells[1, i] = header[i - 1];
            }
            for (int i = 1; i <= list.Count; i++)
            {
                for (int j = 0; j < list[i - 1].GetType().GetProperties().Count(); j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = list[i - 1].GetType().GetProperties()[j].GetValue(list[i - 1]).ToString();
                }
            }



            xlWorkBook.SaveAs(path, code, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlShared, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        }
    }
    public class InfoResult
    {
        public List<string> headers { get; set; }
        public List<string> sheets { get; set; }
    }
}
