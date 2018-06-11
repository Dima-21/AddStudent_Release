namespace WindowsFormsApplication2
{
    partial class StatsMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBMarks = new System.Windows.Forms.ComboBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.LBMarks = new System.Windows.Forms.ListBox();
            this.LTeacher = new System.Windows.Forms.Label();
            this.LStudent = new System.Windows.Forms.Label();
            this.BOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Препод:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценки:";
            // 
            // CBMarks
            // 
            this.CBMarks.FormattingEnabled = true;
            this.CBMarks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CBMarks.Location = new System.Drawing.Point(16, 130);
            this.CBMarks.Name = "CBMarks";
            this.CBMarks.Size = new System.Drawing.Size(43, 21);
            this.CBMarks.TabIndex = 3;
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(65, 128);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(43, 23);
            this.BAdd.TabIndex = 4;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // LBMarks
            // 
            this.LBMarks.FormattingEnabled = true;
            this.LBMarks.Location = new System.Drawing.Point(65, 74);
            this.LBMarks.Name = "LBMarks";
            this.LBMarks.Size = new System.Drawing.Size(96, 30);
            this.LBMarks.TabIndex = 5;
            // 
            // LTeacher
            // 
            this.LTeacher.AutoSize = true;
            this.LTeacher.Location = new System.Drawing.Point(69, 13);
            this.LTeacher.Name = "LTeacher";
            this.LTeacher.Size = new System.Drawing.Size(10, 13);
            this.LTeacher.TabIndex = 6;
            this.LTeacher.Text = "-";
            // 
            // LStudent
            // 
            this.LStudent.AutoSize = true;
            this.LStudent.Location = new System.Drawing.Point(69, 35);
            this.LStudent.Name = "LStudent";
            this.LStudent.Size = new System.Drawing.Size(10, 13);
            this.LStudent.TabIndex = 7;
            this.LStudent.Text = "-";
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(114, 128);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(57, 23);
            this.BOk.TabIndex = 8;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // StatsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 177);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.LStudent);
            this.Controls.Add(this.LTeacher);
            this.Controls.Add(this.LBMarks);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.CBMarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatsMenu";
            this.Text = "StatsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBMarks;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.ListBox LBMarks;
        private System.Windows.Forms.Label LTeacher;
        private System.Windows.Forms.Label LStudent;
        private System.Windows.Forms.Button BOk;
    }
}