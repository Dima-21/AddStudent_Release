﻿namespace WindowsFormsApplication2.Forms
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TSymbols = new System.Windows.Forms.Label();
            this.BSend = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // TName
            // 
            this.TName.AutoSize = true;
            this.TName.Location = new System.Drawing.Point(53, 57);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 103);
            this.textBox1.TabIndex = 4;
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
            this.BSend.Location = new System.Drawing.Point(116, 226);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(75, 23);
            this.BSend.TabIndex = 7;
            this.BSend.Text = "Send";
            this.BSend.UseVisualStyleBackColor = true;
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(197, 226);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(75, 23);
            this.BClear.TabIndex = 8;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            // 
            // SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.TSymbols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "SendSMS";
            this.Text = "Отправка SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TSymbols;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Button BClear;
    }
}