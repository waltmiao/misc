using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Security.Principal;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace CommiCalc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string serial = GetSerial();
            if (String.IsNullOrEmpty(serial))
            {
                MessageBox.Show("获取机器序列号失败！");
                return;
            }
            string path = Path.Combine(Environment.CurrentDirectory, "calc.lic");
            if (!File.Exists(path))
            {
                Form2 form2 = new Form2();
                form2.textBox1.Text = serial;
                form2.ShowDialog();
                return;
            }
            FileInfo fi = new FileInfo(path);
            using (FileStream fs = fi.OpenRead())
            {
                byte[] bytes = new byte[1024];
                int n = fs.Read(bytes, 0, 1024);
                if (n <= 128 || n >= 512)
                {
                    MessageBox.Show("读取授权文件出错！");
                    return;
                }
                string s = Encoding.ASCII.GetString(bytes, 0, n - 128);
                if (serial != s)
                {
                    MessageBox.Show("授权文件不匹配！");
                    return;
                }
                byte[] sign = new byte[128];
                for (int i = 0; i < 128; ++i)
                    sign[i] = bytes[n - 128 + i];

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(@"<RSAKeyValue><Modulus>5oQhKZMWLAfCJf9TtZlQGXixQDYKqtN+XUCfm6vbqN2C2PqQK63FWFf5EhC5ELWSbCqYwitCHqNqnQoMAZU+ek5MCJlD0liTwGbKa7Jg6/dozieOUozcZjPEKtwY3IeUTVu8E9c+90WlxGI6iALlYzXb737hyQ0sJVlkgHszivE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
                bool bVerify = rsa.VerifyData(Encoding.ASCII.GetBytes(s), "SHA1", sign);
                if (!bVerify)
                {
                    MessageBox.Show("授权文件校验失败！");
                    return;
                }
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
