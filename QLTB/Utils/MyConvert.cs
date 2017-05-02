using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Utils
{
    public static class MyConvert
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        public static string DateToString(DateTime? date)
        {
            if (date == null) return "";
            else
            return ((DateTime)date).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
        }
        public static string BoolToString(bool value, string iftrue,string iffalse)
        {
            return value == true ? iftrue : iffalse;
        }
        public static string ToVienameseCurrency(double value)
        {
            CultureInfo original = new CultureInfo("vi-VN", false);
            NumberFormatInfo vietNfi = (NumberFormatInfo)original.NumberFormat.Clone();
            vietNfi.CurrencySymbol = "₫"; // ₫
            return value.ToString("C", vietNfi);
        }
        public static T ConvertSameData<T>(object source)
        {
            var result = Activator.CreateInstance<T>();
            foreach (var item in typeof(T).GetProperties())
            {
                item.SetValue(result, typeof(object).GetProperty(item.Name).GetValue(source));
            }
            return result;
        }
    }
}
