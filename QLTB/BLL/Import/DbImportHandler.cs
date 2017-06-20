using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Model;
using OfficeOpenXml;

namespace QLTB.Handler
{
    public class DbImportHandler
    {
        private string PATH = Path.GetDirectoryName(Application.ExecutablePath);

        //public List<string> GetSourceHeader(string path, int headerIndex, int sheetIndex)
        //{
        //    var headers = new List<string>();
        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
        //    Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[sheetIndex];
        //    //get all worksheet
        //    Excel.Range xlRange = xlWorksheet.UsedRange;
        //    int colCount = xlRange.Columns.Count;
        //    for (int j = 0; j < colCount; j++)
        //    {
        //        headers.Add(((Excel.Range)xlRange.Cells[headerIndex, j + 1]).Value.ToString());
        //    }
        //    #region Clean
        //    //cleanup
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();

        //    //rule of thumb for releasing com objects:
        //    //  never use two dots, all COM objects must be referenced and released individually
        //    //  ex: [somthing].[something].[something] is bad

        //    //release com objects to fully kill excel process from running in the background
        //    Marshal.ReleaseComObject(xlRange);
        //    Marshal.ReleaseComObject(xlWorksheet);

        //    //close and release
        //    xlWorkbook.Close(false);
        //    Marshal.ReleaseComObject(xlWorkbook);

        //    //quit and release
        //    xlApp.Quit();

        //    Marshal.ReleaseComObject(xlApp);
        //    #endregion
        //    return headers;
        //}
        //public List<string> GetKhoPhong(string path, int headerIndex, int sheetIndex)
        //{
        //    var khophong = new List<string>();
        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
        //    Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[sheetIndex];
        //    //get all worksheet
        //    Excel.Range xlRange = xlWorksheet.UsedRange;
        //    try
        //    {

        //        int colCount = xlRange.Columns.Count;
        //        int rowCount = xlRange.Rows.Count;
        //        int khophongindex = 4;
        //        //get khophong column index
        //        //for (int j = 0; j < colCount; j++)
        //        //{
        //        //    string tmp = ((Excel.Range)xlRange.Cells[headerIndex, j + 1]).Value.ToString();
        //        //    if (tmp.Equals("Kho phòng",StringComparison.CurrentCultureIgnoreCase))
        //        //    {
        //        //        khophongindex = j+1;
        //        //    }
        //        //}
        //        if (rowCount > 1)
        //        {
        //            for (int i = headerIndex; i < rowCount; i++)
        //            {
        //                string tmp = ((Excel.Range)xlRange.Cells[i + 1, khophongindex]).Value.ToString();
        //                if (!string.IsNullOrEmpty(tmp))
        //                {
        //                    if (!khophong.Contains(tmp))
        //                        khophong.Add(tmp);
        //                }
        //            }
        //            return khophong;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        #region Clean
        //        //cleanup
        //        GC.Collect();
        //        GC.WaitForPendingFinalizers();

        //        //rule of thumb for releasing com objects:
        //        //  never use two dots, all COM objects must be referenced and released individually
        //        //  ex: [somthing].[something].[something] is bad

        //        //release com objects to fully kill excel process from running in the background
        //        Marshal.ReleaseComObject(xlRange);
        //        Marshal.ReleaseComObject(xlWorksheet);

        //        //close and release
        //        xlWorkbook.Close(false);
        //        Marshal.ReleaseComObject(xlWorkbook);

        //        //quit and release
        //        xlApp.Quit();

        //        Marshal.ReleaseComObject(xlApp);
        //        #endregion
        //    }
        //}
        ///// <summary>
        ///// Lấy file info gồm 
        ///// </summary>
        ///// <param name="path"></param>
        ///// <param name="headerIndex"></param>
        ///// <param name="sheetIndex"></param>
        ///// <returns></returns>
        //public Model.FileInfo GetFileInfo(string path, int headerIndex, int sheetIndex)
        //{
        //    //khai bao bien
        //    var khophong = new List<Columnmapping>();
        //    var header = new List<Columnmapping>();
        //    var nguonkp = new List<Columnmapping>();
        //    var thietbichuaco = new List<string>();
        //    var info = new Model.FileInfo();

        //    //
        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
        //    Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[sheetIndex];
        //    //get all worksheet
        //    Excel.Range xlRange = xlWorksheet.UsedRange;
        //    try
        //    {
        //        int colCount = xlRange.Columns.Count;
        //        int rowCount = xlRange.Rows.Count;
        //        #region Lấy kho phòng
        //        int khophongindex = 4;
        //        //get khophong column index
        //        //for (int j = 0; j < colCount; j++)
        //        //{
        //        //    string tmp = ((Excel.Range)xlRange.Cells[headerIndex, j + 1]).Value.ToString();
        //        //    if (tmp.Equals("Kho phòng",StringComparison.CurrentCultureIgnoreCase))
        //        //    {
        //        //        khophongindex = j+1;
        //        //    }
        //        //}
        //        if (rowCount > 1)
        //        {
        //            var lst = new List<string>();
        //            for (int i = headerIndex; i < rowCount; i++)
        //            {
        //                string tmp = ((Excel.Range)xlRange.Cells[i + 1, khophongindex]).Value.ToString();
        //                if (!string.IsNullOrEmpty(tmp))
        //                {
        //                    if (!lst.Contains(tmp))
        //                        lst.Add(tmp);
        //                }
        //            }
        //            if (lst.Count > 0)
        //            {
        //                int i = 1;
        //                foreach (var item in lst)
        //                {
        //                    khophong.Add(new Columnmapping
        //                    {
        //                        Index = i++,
        //                        Ten = item
        //                    });
        //                }
        //            }
        //        }
        //        #endregion
        //        #region Lấy header
        //        var headers = new List<string>();
        //        for (int j = 0; j < colCount; j++)
        //        {
        //            headers.Add(((Excel.Range)xlRange.Cells[headerIndex, j + 1]).Value.ToString());
        //        }
        //        if (headers.Count > 0)
        //        {
        //            int i = 1;
        //            foreach (var item in headers)
        //            {
        //                header.Add(new Columnmapping
        //                {
        //                    Index = i++,
        //                    Ten = item
        //                });
        //            }
        //        }
        //        #endregion
        //        #region Lấy Nguồn kinh phí
        //        int nguonkpindex = 8;
        //        if (rowCount > 1)
        //        {
        //            var lst = new List<string>();
        //            for (int i = headerIndex; i < rowCount; i++)
        //            {
        //                string tmp = ((Excel.Range)xlRange.Cells[i + 1, nguonkpindex]).Value.ToString();
        //                if (!string.IsNullOrEmpty(tmp))
        //                {
        //                    if (!lst.Contains(tmp))
        //                        lst.Add(tmp);
        //                }
        //            }
        //            if (lst.Count > 0)
        //            {
        //                int i = 1;
        //                foreach (var item in lst)
        //                {
        //                    nguonkp.Add(new Columnmapping
        //                    {
        //                        Index = i++,
        //                        Ten = item
        //                    });
        //                }
        //            }
        //        }
        //        #endregion
        //        #region Lấy thiết bị chưa có
        //        var dstb = new DbThietBiTTHandler().GetMaTB();
        //        int matbindex = 1;
        //        if (rowCount > 1)
        //        {
        //            var lst = new List<string>();
        //            for (int i = headerIndex; i < rowCount; i++)
        //            {
        //                string tmp = ((Excel.Range)xlRange.Cells[i + 1, matbindex]).Value.ToString();
        //                if (!string.IsNullOrEmpty(tmp))
        //                {
        //                    tmp = tmp.ToUpper();
        //                    if (!dstb.Contains(tmp))
        //                        lst.Add(tmp);
        //                }
        //            }
        //            if (lst.Count > 0)
        //            {
        //                thietbichuaco = lst;
        //            }
        //        }
        //        #endregion
        //        info.header = header;
        //        info.khophong = khophong;
        //        info.nguonkinhphi = nguonkp;
        //        info.thietbichuaco = thietbichuaco;
        //        return info;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        #region Clean
        //        //cleanup
        //        GC.Collect();
        //        GC.WaitForPendingFinalizers();

        //        //rule of thumb for releasing com objects:
        //        //  never use two dots, all COM objects must be referenced and released individually
        //        //  ex: [somthing].[something].[something] is bad

        //        //release com objects to fully kill excel process from running in the background
        //        Marshal.ReleaseComObject(xlRange);
        //        Marshal.ReleaseComObject(xlWorksheet);

        //        //close and release
        //        xlWorkbook.Close(false);
        //        Marshal.ReleaseComObject(xlWorkbook);

        //        //quit and release
        //        xlApp.Quit();

        //        Marshal.ReleaseComObject(xlApp);
        //        #endregion
        //    }
        //}
        //public List<string> GetSheets(string path)
        //{
        //    var result = new List<string>();
        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
        //    //get all worksheet
        //    try
        //    {
        //        foreach (Excel.Worksheet item in xlWorkbook.Sheets)
        //        {
        //            result.Add(item.Name);
        //        }
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        #region Clean
        //        //cleanup
        //        GC.Collect();
        //        GC.WaitForPendingFinalizers();

        //        //rule of thumb for releasing com objects:
        //        //  never use two dots, all COM objects must be referenced and released individually
        //        //  ex: [somthing].[something].[something] is bad

        //        //release com objects to fully kill excel process from running in the background

        //        //close and release
        //        Marshal.ReleaseComObject(xlWorkbook.Sheets);
        //        xlWorkbook.Close(false);
        //        Marshal.ReleaseComObject(xlWorkbook);

        //        //quit and release
        //        xlApp.Quit();
        //        Marshal.ReleaseComObject(xlApp);
        //        #endregion
        //    }

        //}
        //public List<ThietBiImport> Read(string path, int headerRow, int sheet, List<Columnmapping> header, List<Columnmapping> khophong, List<Columnmapping> nguonkp)
        //{
        //    List<ThietBiImport> lst = new List<ThietBiImport>();
        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
        //    Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[sheet];
        //    Excel.Range xlRange = xlWorksheet.UsedRange;
        //    try
        //    {
        //        int rowCount = xlRange.Rows.Count;
        //        int colCount = xlRange.Columns.Count;
        //        //
        //        for (int i = 1 + headerRow; i <= rowCount; i++)
        //        {
        //            var tmp = new ThietBiImport();
        //            tmp.ThietBiId = (string)((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("ThietBiId")).FirstOrDefault().Index]).Value.ToString();
        //            tmp.SoHieu = (string)((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("SoHieu")).FirstOrDefault().Index]).Value.ToString();
        //            tmp.Ten = (string)((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("Ten")).FirstOrDefault().Index]).Value.ToString();
        //            //phong hoc
        //            string tenphong = ((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("PhongHocId")).FirstOrDefault().Index]).Value.ToString();
        //            tmp.PhongHocId = khophong.Where(p => p.Ten.Equals(tenphong)).FirstOrDefault().Index;
        //            //nguon kinh phi
        //            string tennguonkp = ((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("NguonKinhPhiId")).FirstOrDefault().Index]).Value.ToString();
        //            tmp.NguonKinhPhiId = nguonkp.Where(p => p.Ten.Equals(tennguonkp)).FirstOrDefault().Index;

        //            //
        //            tmp.QuyCachSD = ((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("QuyCachSD")).FirstOrDefault().Index]).Text;
        //            tmp.MonHocId = Convert.ToInt32(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("MonHocId")).FirstOrDefault().Index]).Value.ToString());
        //            tmp.DonViTinhId = Convert.ToInt32(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("DonViTinhId")).FirstOrDefault().Index]).Value.ToString());
        //            tmp.NuocSanXuat = ((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("NuocSanXuat")).FirstOrDefault().Index]).Text;
        //            tmp.NamDuaVaoSD = Convert.ToInt32(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("NamDuaVaoSD")).FirstOrDefault().Index]).Value.ToString());
        //            tmp.NamTheoDoi = Convert.ToInt32(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("NamTheoDoi")).FirstOrDefault().Index]).Value.ToString());
        //            //han su dung
        //            DateTime hansd;
        //            if (DateTime.TryParse(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("HanSD")).FirstOrDefault().Index]).Value2, out hansd))
        //            {
        //                tmp.HanSD = hansd;
        //            }
        //            tmp.SoLuong = Convert.ToInt32(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("SoLuong")).FirstOrDefault().Index]).Value.ToString());
        //            //don gia
        //            double dongia;
        //            if (double.TryParse(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("DonGia")).FirstOrDefault().Index]).Text, out dongia))
        //            {
        //                tmp.DonGia = dongia;
        //            }
        //            //thanh tien
        //            decimal thanhtien;
        //            if (decimal.TryParse((xlRange.Cells[i, header.Where(p => p.Ten.Equals("ThanhTien")).FirstOrDefault().Index]).Text, out thanhtien))
        //            {
        //                tmp.ThanhTien = thanhtien;
        //            }
        //            //ngay san xuat
        //            DateTime ngaysx;
        //            if (DateTime.TryParse(((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("NgaySanXuat")).FirstOrDefault().Index]).Value2, out ngaysx))
        //            {
        //                tmp.NgaySanXuat = ngaysx;
        //            }
        //            //
        //            tmp.GhiChu = ((Excel.Range)xlRange.Cells[i, header.Where(p => p.Ten.Equals("GhiChu")).FirstOrDefault().Index]).Text;
        //            lst.Add(tmp);
        //        }
        //        return lst;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        #region Clean
        //        //cleanup
        //        GC.Collect();
        //        GC.WaitForPendingFinalizers();

        //        //rule of thumb for releasing com objects:
        //        //  never use two dots, all COM objects must be referenced and released individually
        //        //  ex: [somthing].[something].[something] is bad

        //        //release com objects to fully kill excel process from running in the background
        //        Marshal.ReleaseComObject(xlRange);

        //        Marshal.ReleaseComObject(xlWorksheet);

        //        //close and release
        //        xlWorkbook.Close(false);
        //        Marshal.ReleaseComObject(xlWorkbook);

        //        //quit and release
        //        xlApp.Quit();
        //        Marshal.ReleaseComObject(xlApp);
        //        #endregion
        //    }
        //}
        public List<string> GetSheets(string path)
        {
            var result = new List<string>();
            try
            {
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    foreach (ExcelWorksheet workSheet in package.Workbook.Worksheets)
                    {
                        result.Add(workSheet.Name);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ExcelFileInfo GetFileInfo(string path, int sheetIndex, int headerIndex)
        {
            //khai bao bien
            var khophong = new List<Columnmapping>();
            var header = new List<Columnmapping>();
            var nguonkp = new List<Columnmapping>();
            var thietbichuaco = new List<string>();
            var info = new ExcelFileInfo();
            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[sheetIndex];
                #region Headers
                List<string> headers = new List<string>();
                foreach (var firstRowCell in workSheet.Cells[headerIndex, 1, headerIndex, workSheet.Dimension.End.Column])
                {
                    headers.Add(firstRowCell.Text);
                }
                if (headers.Count > 0)
                {
                    int i = 1;
                    foreach (var item in headers)
                    {
                        header.Add(new Columnmapping
                        {
                            Index = i++,
                            Ten = item
                        });
                    }
                }
                #endregion
                #region Kho Phòng
                int khophongindex = 3;
                var khophongs = new List<string>();
                for (int i = headerIndex + 1;
                        i <= workSheet.Dimension.End.Row;
                        i++)
                {
                    string tmp = workSheet.Cells[i, khophongindex].Value.ToString();
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        if (!khophongs.Contains(tmp))
                            khophongs.Add(tmp);
                    }
                }
                if (khophongs.Count > 0)
                {
                    int i = 1;
                    foreach (var item in khophongs)
                    {
                        khophong.Add(new Columnmapping
                        {
                            Index = i++,
                            Ten = item
                        });
                    }
                }
                #endregion
                #region Nguồn kinh phí
                int nguonkpindex = 5;
                var nguonkps = new List<string>();
                for (int i = headerIndex + 1;
                        i <= workSheet.Dimension.End.Row;
                        i++)
                {
                    string tmp = workSheet.Cells[i, nguonkpindex].Value.ToString();
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        if (!nguonkps.Contains(tmp))
                            nguonkps.Add(tmp);
                    }
                }
                if (nguonkps.Count > 0)
                {
                    int i = 1;
                    foreach (var item in nguonkps)
                    {
                        nguonkp.Add(new Columnmapping
                        {
                            Index = i++,
                            Ten = item
                        });
                    }
                }
                #endregion
                #region Lấy thiết bị chưa có
                var dstb = new DbThietBiTTHandler().GetMaTB();
                int matbindex = 1;
                var lst = new List<string>();
                for (int i = headerIndex + 1;
                   i <= workSheet.Dimension.End.Row;
                   i++)
                {
                    string tmp = workSheet.Cells[i, matbindex].Value.ToString();
                    if (!string.IsNullOrEmpty(tmp))
                    {
                        tmp = tmp.ToUpper();
                        if (!dstb.Contains(tmp))
                            lst.Add(tmp);
                    }
                }
                if (lst.Count > 0)
                {
                    thietbichuaco = lst;
                }
                #endregion
                info.header = header;
                info.khophong = khophong;
                info.nguonkinhphi = nguonkp;
                info.thietbichuaco = thietbichuaco;
            }
            return info;
        }
        public List<ThietBiImport> Read(string path, int headerRow, int sheet, List<Columnmapping> header, List<Columnmapping> khophong, List<Columnmapping> nguonkp)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    List<ThietBiImport> lst = new List<ThietBiImport>();
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[sheet];
                    for (int i = headerRow + 1;
                      i <= workSheet.Dimension.End.Row;
                      i++)
                    {
                        var tmp = new ThietBiImport();
                        #region Builing model             
                        tmp.ThietBiId = workSheet.Cells[i, header.Where(p => p.Ten.Equals("ThietBiId")).FirstOrDefault().Index].Value.ToString();
                        tmp.Ten = workSheet.Cells[i, header.Where(p => p.Ten.Equals("Ten")).FirstOrDefault().Index].Value.ToString();
                        //phong hoc
                        string tenphong = workSheet.Cells[i, header.Where(p => p.Ten.Equals("PhongHocId")).FirstOrDefault().Index].Value.ToString();
                        tmp.PhongHocId = khophong.Where(p => p.Ten.Equals(tenphong)).FirstOrDefault().Index;
                        //nguon kinh phi
                        string tennguonkp = workSheet.Cells[i, header.Where(p => p.Ten.Equals("NguonKinhPhiId")).FirstOrDefault().Index].Value.ToString();
                        tmp.NguonKinhPhiId = nguonkp.Where(p => p.Ten.Equals(tennguonkp)).FirstOrDefault().Index;

                        //
                        tmp.QuyCachSD = workSheet.Cells[i, header.Where(p => p.Ten.Equals("QuyCachSD")).FirstOrDefault().Index].Text;
                        tmp.NuocSanXuat = workSheet.Cells[i, header.Where(p => p.Ten.Equals("NuocSanXuat")).FirstOrDefault().Index].Text;
                        tmp.NamDuaVaoSD = Convert.ToInt32(workSheet.Cells[i, header.Where(p => p.Ten.Equals("NamDuaVaoSD")).FirstOrDefault().Index].Value.ToString());
                        tmp.NgayDuaVaoSD = DateTime.Parse(workSheet.Cells[i, header.Where(p => p.Ten.Equals("NgayDuaVaoSD")).FirstOrDefault().Index].Value.ToString());
                        tmp.NamTheoDoi = Convert.ToInt32(workSheet.Cells[i, header.Where(p => p.Ten.Equals("NamTheoDoi")).FirstOrDefault().Index].Value.ToString());
                        //han su dung
                        DateTime hansd;
                        if (DateTime.TryParse(workSheet.Cells[i, header.Where(p => p.Ten.Equals("HanSD")).FirstOrDefault().Index].Text, out hansd))
                        {
                            tmp.HanSD = hansd;
                        }
                        tmp.SoLuong = Convert.ToInt32(workSheet.Cells[i, header.Where(p => p.Ten.Equals("SoLuong")).FirstOrDefault().Index].Value.ToString());
                        //don gia
                        double dongia;
                        if (double.TryParse(workSheet.Cells[i, header.Where(p => p.Ten.Equals("DonGia")).FirstOrDefault().Index].Text, out dongia))
                        {
                            tmp.DonGia = dongia;
                        }
                        //thanh tien
                        decimal thanhtien;
                        if (decimal.TryParse(workSheet.Cells[i, header.Where(p => p.Ten.Equals("ThanhTien")).FirstOrDefault().Index].Text, out thanhtien))
                        {
                            tmp.ThanhTien = thanhtien;
                        }
                        //ngay san xuat
                        DateTime ngaysx;
                        if (DateTime.TryParse(workSheet.Cells[i, header.Where(p => p.Ten.Equals("NgaySanXuat")).FirstOrDefault().Index].Text, out ngaysx))
                        {
                            tmp.NgaySanXuat = ngaysx;
                        }
                        //
                        tmp.GhiChu = workSheet.Cells[i, header.Where(p => p.Ten.Equals("GhiChu")).FirstOrDefault().Index].Text;
                        #endregion
                        lst.Add(tmp);
                    }
                    return lst;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}