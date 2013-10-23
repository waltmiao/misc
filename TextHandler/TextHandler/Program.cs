using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace TextHandler
{
    class Program
    {
        static void Main(string[] args)
        {
             //string pathParent = @"C:\tasks\100";
             //DirectoryInfo dir = new DirectoryInfo(pathParent);
             //foreach (DirectoryInfo child in dir.GetDirectories("*"))
             //{
             //    HandleFolder(child.FullName, pathParent);
             //}

            string key = GenerateKey();//"waltmiao";

            //EncryptFile(@"c:\tasks\100.zip", @"c:\tasks\200.dat", key);
            //DecryptFile(@"c:\tasks\200.dat", @"c:\tasks\100_1.zip", key);

            GCHandle gch = GCHandle.Alloc(key, GCHandleType.Pinned);

            EncryptFile(@"c:\tasks\100.csv", @"c:\tasks\200.zzz", key);
            DecryptFile(@"c:\tasks\200.zzz", @"c:\tasks\100_1.csv", key);


            gch.Free();


        }
        static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }


        static void EncryptFile(string sInputFilename,
         string sOutputFilename,
         string sKey)
        {
            FileStream fsInput = new FileStream(sInputFilename,
               FileMode.Open,
               FileAccess.Read);

            FileStream fsEncrypted = new FileStream(sOutputFilename,
               FileMode.Create,
               FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted,
               desencrypt,
               CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }

        static void DecryptFile(string sInputFilename,
           string sOutputFilename,
           string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set initialization vector.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            //Create a file stream to read the encrypted file back.
            FileStream fsread = new FileStream(sInputFilename,
               FileMode.Open,
               FileAccess.Read);
            //Create a DES decryptor from the DES instance.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Create crypto stream set to read and do a 
            //DES decryption transform on incoming bytes.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread,
               desdecrypt,
               CryptoStreamMode.Read);
            //Print the contents of the decrypted file.
            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
        } 



        private static void HandleFolder(string pathChild, string pathParent)
        {
           // string path = @"C:\tasks\100\20130401";
            Dictionary<string, string> money = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(Path.Combine(pathChild, "bcp_file_cust_real_fund.txt"), Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    string[] words = line.Split(new string[] { "^@#~" }, StringSplitOptions.None);
                    if (words.Length >= 4)
                        money[words[0]] = words[3];
                }

            }

            string name = "clients.csv";

            using (StreamReader sr = new StreamReader(Path.Combine(pathChild, "bcp_file_dictionary.txt"), Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim('|');
                    string[] words = line.Split(new string[] { "^@#~" }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 2 && words[0] == "1000" && words[1] == "Name")
                        name = words[2] + pathChild.Substring(pathChild.Length - 8) + ".csv";
                }

            }

            List<string> ss = new List<string>();
            int iii = 0;

            using (StreamReader sr = new StreamReader(Path.Combine(pathChild, "bcp_file_cust_whole.txt"), Encoding.Default))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(pathParent, name), false, Encoding.Default))
                {
                    sw.WriteLine("姓名,出生年份,手机号,资金,地址,身份证号");
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        line = line.Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;
                        string[] words = line.Split(new string[] { "^@#~" }, StringSplitOptions.None);
                        if (words.Length < 12) continue;


                        string m = "";
                        if (money.ContainsKey(words[0]))
                            m = money[words[0]];
                        string year = "";
                        if (words[11].Length > 10 && words[11][6] == '1' && words[11][7] == '9')
                            year = words[11].Substring(6, 4);

                        string tel = words[4].Trim();
                        if (string.IsNullOrEmpty(tel))
                        {
                            if (words[3].Length > 11 && words[3].Contains("-"))
                                words[3] = words[3].Split(new char[] { '-' })[1];
                            if (words[3].Length >= 11)
                                tel = words[3];

                        }

                        if (tel.Length == 11)
                        {
                            if (!ss.Contains(tel))
                                ss.Add(tel);
                            else
                            {
                                ++iii;
                            }
                        }

                        List<string> infos = new List<string>();
                        infos.Add(words[1]);
                        infos.Add(year);
                        infos.Add(tel);
                        infos.Add(m);
                        infos.Add(words[2]);
                        infos.Add(words[11]);


                        sw.WriteLine(string.Join(",", infos.ToArray()));

                    }
                }
            }
        }
    }
}
