using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace LicenceGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("请输入机器序列号！");
                return;
            }
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(s);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string priKey = @"<RSAKeyValue><Modulus>5oQhKZMWLAfCJf9TtZlQGXixQDYKqtN+XUCfm6vbqN2C2PqQK63FWFf5EhC5ELWSbCqYwitCHqNqnQoMAZU+ek5MCJlD0liTwGbKa7Jg6/dozieOUozcZjPEKtwY3IeUTVu8E9c+90WlxGI6iALlYzXb737hyQ0sJVlkgHszivE=</Modulus><Exponent>AQAB</Exponent><P>+XRvr57olNs02S8WPXPcmWoVqJryIbiXCJUlrqnDRxb/iwRgoEcUc9LVfz4f1e0sa3TljMk+i/bcFTiOPL/Saw==</P><Q>7JB735/NpULsuMFOJvVKGdg2JBF9l2aHEd1J+H78Oj+v+1ZV0c3GDU7Gw57friK0NETxqVBsgGxACUfuWCIHEw==</Q><DP>XqH7VKZ2GTJnhBTG3R09DL4f5UySmpRKR6k9GFuyhx+EZhqNBYCxk5biA1lv/lnxRfqcsqINpk9KAorn+sfSbQ==</DP><DQ>w0Q/+8acqN0lKRvmtqGiGNMvXXZShLZMp6JRfJzU9f+782rAS/3ejP2Jc8+gMszSkpKWJ3wLE7ZG5WJKitULoQ==</DQ><InverseQ>P/uj2QqqsSRIxxxqKzsoi/ZZeXcGP+99ZxO9nsa/rlMYQVHGSIgN4fJ7J6vkEMpFl1DuRVVPNnlGLGzGjeC2KA==</InverseQ><D>NrylS0P7/dSRy4gHjpWrKYE5RbAPdGToGqifvc1fSYff7DoDRfvrYoDxSdLivw7+h+TNhT3UY4YWaNfb5fxUay8Hw+N/NyAceey9IQLolNUL9+QwwzXYOmiYucVmRt4Wf4YNqqm9CDu5zfU0tpa3iFyyF+Ygbs9s7V4oiqyENYk=</D></RSAKeyValue>";
            rsa.FromXmlString(priKey);
            byte[] sign = rsa.SignData(bytes, "SHA1");

            string path = Path.Combine(Environment.CurrentDirectory, "calc.lic");
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Write(sign, 0, sign.Length);
            }

            MessageBox.Show(path + " 授权文件创建成功！");

        }
    }
}
