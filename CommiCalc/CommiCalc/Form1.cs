using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CommiCalc
{
    public partial class Form1 : Form
    {
        Color normal;

        //string tableName = "Sheet1";
        string colomnName = "手续费";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textChildRate.Text = Properties.Settings.Default.P1;
            textMainRate.Text = Properties.Settings.Default.P2;
            textSaleRate.Text = Properties.Settings.Default.P3;
            textSalePercent.Text = Properties.Settings.Default.P4;
            normal = textSubCommi.BackColor;

        }

        private void calc()
        {
            try
            {
                double childRate = double.Parse(textChildRate.Text);
                double mainRate = double.Parse(textMainRate.Text);
                string[] childCommis = textChildDetail.Text.Split();

                List<double> childs = new List<double>();
                List<double> mains = new List<double>();
                textMainDetail.Text = "";

                //StringBuilder sb = new StringBuilder();
                foreach (string childCommi in childCommis)
                {
                    if (string.IsNullOrEmpty(childCommi.Trim()))
                        continue;
                    double child = double.Parse(childCommi);
                    double main = child * mainRate / childRate;
                    if (main < 5.001)
                        main = 5;
                    childs.Add(child);
                    mains.Add(double.Parse(main.ToString("#.##")));
     
                    //if (sb.Length != 0)
                    //    sb.Append("\r\n");
                    //sb.Append(main.ToString("#.##"));
                    if (textMainDetail.Text != "")
                        textMainDetail.Text += "\r\n";
                    textMainDetail.Text += main.ToString("#.##");
                    textNumber.Text = mains.Count.ToString();
                  }

                //textMainDetail.Text = sb.ToString();
 
                double sum1 = 0.0;
                double sum2 = 0.0;
                childs.ForEach(d => sum1 += d);
                mains.ForEach(d => sum2 += d);
                textChildSum.Text = sum1.ToString("#.##");
                textMainSum.Text = sum2.ToString("#.##");

                double sum = sum1 - sum2;
                textSubCommi.Text = sum.ToString("#.##");
                textSubCommi.BackColor = normal;

                // sale commi
                double saleRate = double.Parse(textSaleRate.Text);
                double salePercent = double.Parse(textSalePercent.Text);
                double saleCommi = sum * (childRate - saleRate) / (childRate - mainRate) * salePercent / 100.0;
                textSaleCommi.Text = saleCommi.ToString("#.##");
                textSaleCommi.BackColor = normal;


                Properties.Settings.Default.P1 = textChildRate.Text;
                Properties.Settings.Default.P2 = textMainRate.Text;
                Properties.Settings.Default.P3 = textSaleRate.Text;
                Properties.Settings.Default.P4 = textSalePercent.Text;

                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                textSubCommi.BackColor = Color.Red;
                textSaleCommi.BackColor = Color.Red;
                 textSubCommi.Text = "?输入有误";
                textSaleCommi.Text = "?输入有误";
                
           }
        }

        private void textChildDetail_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textChildRate_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textMainRate_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textSalePercent_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textSaleRate_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textChildDetail_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string path = "";
            if (fileList != null && fileList.Length == 1)
                path = fileList[0];
            if (string.IsNullOrEmpty(path))
                return;

            OleDbConnection dbConnection = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;HDR=Yes;""", path));
            dbConnection.Open();
            try
            {
                DataTable dt1 = dbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string tableName = (string)dt1.Rows[0]["TABLE_NAME"];

                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(string.Format("SELECT * FROM [{0}]", tableName), dbConnection);
                DataTable dt = new DataTable();
                dbAdapter.Fill(dt);
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    sb.Append(row[colomnName].ToString());
                    sb.Append("\r\n");
                }
                textChildDetail.Text = sb.ToString();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                dbConnection.Close();
            }

        }

        private void textChildDetail_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void textChildDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                ((RichTextBox)sender).Paste(DataFormats.GetFormat("Text"));
                e.Handled = true;
            }
        }
    }
}
