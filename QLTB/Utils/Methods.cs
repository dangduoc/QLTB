using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLTB.Utils
{
    public static class Methods
    {
        public static bool CompareTwoList<T>(IList<T> list1, IList<T> list2)
        {
            var firstNotSecond = list1.Except(list2).ToList();
            var secondNotFirst = list2.Except(list1).ToList();
            return !firstNotSecond.Any() && !secondNotFirst.Any();
        }




    }
    public class SetUpInfo
    {
        public bool CheckUserPC(out string message)
        {
            message = "";
            bool check = false;
            //Local DB installed
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\11.0");
            if (key != null)
            {
                if (key.GetValue("ParentInstance") != null)
                {
                    message = "";
                    check = true;
                }
                else
                {
                    message = "Ứng dụng yêu cầu Microsoft SQL Server Local DB v11" + Environment.NewLine;
                    check = false;
                }
            }
            //Net FrameWork 4.5.1
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {

                    if (((int)ndpKey.GetValue("Release")) >= 379893)
                    {
                        message += "";
                        check = true;
                    }
                    else
                    {
                        message += "Ứng dụng yêu cầu .NET FrameWork 4.5.2 trở lên";
                        check = false;
                    }
                }
                else
                {
                    message += "Ứng dụng yêu cầu .NET FrameWork 4.5.2 trở lên";
                    check = false;
                }
            }
            return check;
        }
        public void InstallDependency(bool LocalDB, bool dotNET)
        {
            if (LocalDB && dotNET)
            {
                //install local db
                Process localProcess = InstallLocalDB();
                if (localProcess != null)
                {
                    localProcess.EnableRaisingEvents = true;
                    localProcess.Exited += (sender, e) =>
                    {
                        if (!CheckLocalDB())
                        {
                            MessageBox.Show("Local chưa cài đặt thành công, vui lòng thử lại");
                            Application.Exit();
                        }
                    };
                }
                Process dotnetProcess = InstallNETFramework();
                if (dotnetProcess != null)
                {
                    dotnetProcess.EnableRaisingEvents = true;
                    dotnetProcess.Exited += (sender, e) =>
                    {
                        if (!CheckDotNet())
                        {
                            MessageBox.Show(".NET Framework chưa cài đặt thành công, vui lòng thử lại");
                            Application.Exit();
                        }
                    };
                }
            }
        }
        public Process InstallLocalDB()
        {
            string root = Path.GetDirectoryName(Application.ExecutablePath) + @"\AddIn";
            string filepath = "";
            if (Environment.Is64BitOperatingSystem)
            {
                filepath = Path.Combine(root, "SqlLocalDBx64.msi");
            }
            else
            {
                filepath = Path.Combine(root, "SqlLocalDBx86.msi");
            }
            if (File.Exists(filepath))
            {
                ProcessStartInfo inf = new ProcessStartInfo(filepath, "/qn IACCEPTSQLLOCALDBLICENSETERMS=YES") { UseShellExecute = true, WindowStyle = ProcessWindowStyle.Normal };
                return Process.Start(filepath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file cài đặt. Folder chứa file cài đặt: " + Environment.NewLine + filepath);
                return null;
            }
        }
        public Process InstallNETFramework()
        {
            string root = Path.GetDirectoryName(Application.ExecutablePath) + @"\AddIn";
            string filepath = "";
            if (Environment.Is64BitOperatingSystem)
            {
                filepath = Path.Combine(root, "SqlLocalDBx64.msi");
            }
            else
            {
                filepath = Path.Combine(root, "SqlLocalDBx86.msi");
            }
            if (File.Exists(filepath))
            {
                ProcessStartInfo inf = new ProcessStartInfo(filepath, "/qn IACCEPTSQLLOCALDBLICENSETERMS=YES") { UseShellExecute = true, WindowStyle = ProcessWindowStyle.Normal };
                return Process.Start(filepath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file cài đặt. Folder chứa file cài đặt: " + Environment.NewLine + filepath);
                return null;
            }
        }

        private bool CheckLocalDB()
        {
            //Local DB installed
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\11.0");
            if (key != null)
            {
                if (key.GetValue("ParentInstance") != null)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckDotNet()
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {

                    if (((int)ndpKey.GetValue("Release")) >= 379893)
                    {
                        return true;
                    }

                }
                return false;
            }
        }

        // Checking the version using >= will enable forward compatibility.
        //private static string CheckFor45PlusVersion(int releaseKey)
        //{
        //    if (releaseKey >= 460798)
        //    {
        //        return "4.7 or later";
        //    }
        //    if (releaseKey >= 394802)
        //    {
        //        return "4.6.2";
        //    }
        //    if (releaseKey >= 394254)
        //    {
        //        return "4.6.1";
        //    }
        //    if (releaseKey >= 393295)
        //    {
        //        return "4.6";
        //    }
        //    if ((releaseKey >= 379893))
        //    {
        //        return "4.5.2";
        //    }
        //    if ((releaseKey >= 378675))
        //    {
        //        return "4.5.1";
        //    }
        //    if ((releaseKey >= 378389))
        //    {
        //        return "4.5";
        //    }
        //    // This code should never execute. A non-null release key should mean
        //    // that 4.5 or later is installed.
        //    return "No 4.5 or later version detected";
        //}
    }
}
