namespace WindowsFormsApplication2.Forms
{
    partial class SendSMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBNumber = new System.Windows.Forms.ComboBox();
            this.TName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextSMS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TSymbols = new System.Windows.Forms.Label();
            this.BSend = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TCountSms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер телефона:";
            // 
            // CBNumber
            // 
            this.CBNumber.FormattingEnabled = true;
            this.CBNumber.Location = new System.Drawing.Point(15, 25);
            this.CBNumber.Name = "CBNumber";
            this.CBNumber.Size = new System.Drawing.Size(134, 21);
            this.CBNumber.TabIndex = 1;
            this.CBNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBNumber_KeyPress);
            // 
            // TName
            // 
            this.TName.AutoSize = true;
            this.TName.Location = new System.Drawing.Point(20, 57);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(0, 13);
            this.TName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст сообщения:";
            // 
            // TextSMS
            // 
            this.TextSMS.Location = new System.Drawing.Point(15, 105);
            this.TextSMS.Multiline = true;
            this.TextSMS.Name = "TextSMS";
            this.TextSMS.Size = new System.Drawing.Size(257, 103);
            this.TextSMS.TabIndex = 4;
            this.TextSMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSMS_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Symbols:";
            // 
            // TSymbols
            // 
            this.TSymbols.AutoSize = true;
            this.TSymbols.Location = new System.Drawing.Point(66, 211);
            this.TSymbols.Name = "TSymbols";
            this.TSymbols.Size = new System.Drawing.Size(10, 13);
            this.TSymbols.TabIndex = 6;
            this.TSymbols.Text = "-";
            // 
            // BSend
            // 
            this.BSend.Location = new System.Drawing.Point(116, 250);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(75, 23);
            this.BSend.TabIndex = 7;
            this.BSend.Text = "Send";
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(197, 250);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(75, 23);
            this.BClear.TabIndex = 8;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SMS:";
            // 
            // TCountSms
            // 
            this.TCountSms.AutoSize = true;
            this.TCountSms.Location = new System.Drawing.Point(194, 211);
            this.TCountSms.Name = "TCountSms";
            this.TCountSms.Size = new System.Drawing.Size(10, 13);
            this.TCountSms.TabIndex = 10;
            this.TCountSms.Text = "-";
            // 
            // SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.TCountSms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.TSymbols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextSMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.CBNumber);
            this.Controls.Add(this.label1);
            this.Name = "SendSMS";
            this.Text = "Отправка SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBNumber;
        private System.Windows.Forms.Label TName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextSMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TSymbols;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TCountSms;
    }
}