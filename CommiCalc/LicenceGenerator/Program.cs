using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Security.Principal;
using System.Management;

namespace LicenceGenerator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] ss = new string[] { "BFEBFBFF00010676", "BFEBFBFF000206A7", "BFEBFBFF000206A7" };
            List<string> ls = new List<string>(ss);

            string serial = GetSerial();
            if (!ls.Contains(serial))
            {
                MessageBox.Show("没有权限！");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static string GetSerial()
        {
            string cpuInfo = "";
            ManagementClass cimobject = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = cimobject.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                if (!string.IsNullOrEmpty(cpuInfo))
                    return cpuInfo.Trim();
            }
            return cpuInfo.Trim();
        }
    }
}
