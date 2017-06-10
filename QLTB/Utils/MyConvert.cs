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
        public static string BoolToString(bool value, string iftrue, string iffalse)
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
                if (!item.GetMethod.IsVirtual)
                    if (source.GetType().GetProperty(item.Name) != null)
                        item.SetValue(result, source.GetType().GetProperty(item.Name).GetValue(source) ?? null);
            }
            return result;
        }
        public static object ChangeType(object value, Type type)
        {
            // returns null for non-nullable types
            Type type2 = Nullable.GetUnderlyingType(type);

            if (type2 != null)
            {
                if (value == null)
                {
                    return null;
                }

                type = type2;
            }

            return Convert.ChangeType(value, type);
        }
        public static void TransferValues(object value1, object value2)
        {
            foreach (var item in value1.GetType().GetProperties())
            {
                if (!item.GetMethod.IsVirtual)
                    item.SetValue(value1, value2.GetType().GetProperty(item.Name).GetValue(value2) ?? null);
            }
        }
    }
}
