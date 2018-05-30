namespace WindowsFormsApplication2
{
    partial class MainMenu
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
            this.LBStudents = new System.Windows.Forms.ListBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTeachers = new System.Windows.Forms.ComboBox();
            this.BChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBStudents
            // 
            this.LBStudents.FormattingEnabled = true;
            this.LBStudents.Location = new System.Drawing.Point(12, 77);
            this.LBStudents.Name = "LBStudents";
            this.LBStudents.Size = new System.Drawing.Size(118, 173);
            this.LBStudents.TabIndex = 0;
            this.LBStudents.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.Location = new System.Drawing.Point(136, 77);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(91, 36);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BRemove
            // 
            this.BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRemove.Location = new System.Drawing.Point(136, 119);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(91, 34);
            this.BRemove.TabIndex = 2;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Студенты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Преподаватели:";
            // 
            // CBTeachers
            // 
            this.CBTeachers.FormattingEnabled = true;
            this.CBTeachers.Location = new System.Drawing.Point(12, 29);
            this.CBTeachers.Name = "CBTeachers";
            this.CBTeachers.Size = new System.Drawing.Size(118, 21);
            this.CBTeachers.TabIndex = 5;
            // 
            // BChange
            // 
            this.BChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BChange.Location = new System.Drawing.Point(136, 159);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(91, 34);
            this.BChange.TabIndex = 6;
            this.BChange.Text = "Change";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 267);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.CBTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.LBStudents);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBStudents;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBTeachers;
        private System.Windows.Forms.Button BChange;
    }
}

