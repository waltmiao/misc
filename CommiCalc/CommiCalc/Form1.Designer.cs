namespace CommiCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textChildDetail = new System.Windows.Forms.RichTextBox();
            this.textChildRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMainRate = new System.Windows.Forms.TextBox();
            this.textSaleRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalePercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMainDetail = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSubCommi = new System.Windows.Forms.TextBox();
            this.textSaleCommi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textChildSum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textMainSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textChildDetail
            // 
            this.textChildDetail.AllowDrop = true;
            this.textChildDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textChildDetail.Location = new System.Drawing.Point(137, 116);
            this.textChildDetail.Name = "textChildDetail";
            this.textChildDetail.Size = new System.Drawing.Size(183, 283);
            this.textChildDetail.TabIndex = 0;
            this.textChildDetail.Text = "";
            this.textChildDetail.DragDrop += new System.Windows.Forms.DragEventHandler(this.textChildDetail_DragDrop);
            this.textChildDetail.DragEnter += new System.Windows.Forms.DragEventHandler(this.textChildDetail_DragEnter);
            this.textChildDetail.TextChanged += new System.EventHandler(this.textChildDetail_TextChanged);
            this.textChildDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textChildDetail_KeyDown);
            // 
            // textChildRate
            // 
            this.textChildRate.Location = new System.Drawing.Point(137, 17);
            this.textChildRate.Name = "textChildRate";
            this.textChildRate.Size = new System.Drawing.Size(183, 21);
            this.textChildRate.TabIndex = 1;
            this.textChildRate.TextChanged += new System.EventHandler(this.textChildRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "子佣金费率：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "主佣金费率：";
            // 
            // textMainRate
            // 
            this.textMainRate.Location = new System.Drawing.Point(440, 17);
            this.textMainRate.Name = "textMainRate";
            this.textMainRate.Size = new System.Drawing.Size(183, 21);
            this.textMainRate.TabIndex = 3;
            this.textMainRate.TextChanged += new System.EventHandler(this.textMainRate_TextChanged);
            // 
            // textSaleRate
            // 
            this.textSaleRate.Location = new System.Drawing.Point(137, 58);
            this.textSaleRate.Name = "textSaleRate";
            this.textSaleRate.Size = new System.Drawing.Size(183, 21);
            this.textSaleRate.TabIndex = 1;
            this.textSaleRate.TextChanged += new System.EventHandler(this.textSaleRate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "业务佣金费率：";
            // 
            // textSalePercent
            // 
            this.textSalePercent.Location = new System.Drawing.Point(440, 58);
            this.textSalePercent.Name = "textSalePercent";
            this.textSalePercent.Size = new System.Drawing.Size(183, 21);
            this.textSalePercent.TabIndex = 3;
            this.textSalePercent.TextChanged += new System.EventHandler(this.textSalePercent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "业务员佣金%：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "子佣金明细：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "主佣金明细：";
            // 
            // textMainDetail
            // 
            this.textMainDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textMainDetail.Location = new System.Drawing.Point(440, 119);
            this.textMainDetail.Name = "textMainDetail";
            this.textMainDetail.ReadOnly = true;
            this.textMainDetail.Size = new System.Drawing.Size(183, 280);
            this.textMainDetail.TabIndex = 6;
            this.textMainDetail.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "子主佣金差额：";
            // 
            // textSubCommi
            // 
            this.textSubCommi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textSubCommi.Location = new System.Drawing.Point(137, 454);
            this.textSubCommi.Name = "textSubCommi";
            this.textSubCommi.ReadOnly = true;
            this.textSubCommi.Size = new System.Drawing.Size(183, 21);
            this.textSubCommi.TabIndex = 8;
            // 
            // textSaleCommi
            // 
            this.textSaleCommi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textSaleCommi.Location = new System.Drawing.Point(440, 453);
            this.textSaleCommi.Name = "textSaleCommi";
            this.textSaleCommi.ReadOnly = true;
            this.textSaleCommi.Size = new System.Drawing.Size(183, 21);
            this.textSaleCommi.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "业务员佣金：";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(358, 193);
            this.textNumber.Name = "textNumber";
            this.textNumber.ReadOnly = true;
            this.textNumber.Size = new System.Drawing.Size(52, 21);
            this.textNumber.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "条目数";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "子主佣金总额：";
            // 
            // textChildSum
            // 
            this.textChildSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textChildSum.Location = new System.Drawing.Point(136, 420);
            this.textChildSum.Name = "textChildSum";
            this.textChildSum.ReadOnly = true;
            this.textChildSum.Size = new System.Drawing.Size(183, 21);
            this.textChildSum.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "主佣金总额：";
            // 
            // textMainSum
            // 
            this.textMainSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textMainSum.Location = new System.Drawing.Point(439, 419);
            this.textMainSum.Name = "textMainSum";
            this.textMainSum.ReadOnly = true;
            this.textMainSum.Size = new System.Drawing.Size(183, 21);
            this.textMainSum.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 492);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textMainSum);
            this.Controls.Add(this.textSaleCommi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textChildSum);
            this.Controls.Add(this.textSubCommi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMainDetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSalePercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMainRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSaleRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textChildRate);
            this.Controls.Add(this.textChildDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "佣金计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textChildDetail;
        private System.Windows.Forms.TextBox textChildRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMainRate;
        private System.Windows.Forms.TextBox textSaleRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalePercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox textMainDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSubCommi;
        private System.Windows.Forms.TextBox textSaleCommi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textChildSum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textMainSum;
    }
}

