namespace WindowsFormsApplication2
{
    partial class Dialog
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
            this.components = new System.ComponentModel.Container();
            this.LSurname = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LPatronymic = new System.Windows.Forms.Label();
            this.TSurname = new System.Windows.Forms.TextBox();
            this.TName = new System.Windows.Forms.TextBox();
            this.TPatronymic = new System.Windows.Forms.TextBox();
            this.LDate = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.BApply = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.Check1 = new System.Windows.Forms.Label();
            this.Check3 = new System.Windows.Forms.Label();
            this.Check2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CBTeachers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LSurname
            // 
            this.LSurname.AutoSize = true;
            this.LSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSurname.Location = new System.Drawing.Point(18, 53);
            this.LSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSurname.Name = "LSurname";
            this.LSurname.Size = new System.Drawing.Size(85, 20);
            this.LSurname.TabIndex = 0;
            this.LSurname.Text = "Фамилия:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(18, 96);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(44, 20);
            this.LName.TabIndex = 1;
            this.LName.Text = "Имя:";
            // 
            // LPatronymic
            // 
            this.LPatronymic.AutoSize = true;
            this.LPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPatronymic.Location = new System.Drawing.Point(18, 142);
            this.LPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPatronymic.Name = "LPatronymic";
            this.LPatronymic.Size = new System.Drawing.Size(87, 20);
            this.LPatronymic.TabIndex = 2;
            this.LPatronymic.Text = "Отчество:";
            // 
            // TSurname
            // 
            this.TSurname.Location = new System.Drawing.Point(125, 50);
            this.TSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TSurname.Name = "TSurname";
            this.TSurname.Size = new System.Drawing.Size(210, 26);
            this.TSurname.TabIndex = 3;
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(125, 93);
            this.TName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(210, 26);
            this.TName.TabIndex = 4;
            // 
            // TPatronymic
            // 
            this.TPatronymic.Location = new System.Drawing.Point(125, 139);
            this.TPatronymic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TPatronymic.Name = "TPatronymic";
            this.TPatronymic.Size = new System.Drawing.Size(210, 26);
            this.TPatronymic.TabIndex = 5;
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDate.Location = new System.Drawing.Point(18, 178);
            this.LDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(132, 20);
            this.LDate.TabIndex = 6;
            this.LDate.Text = "Дата рождения:";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(22, 212);
            this.Calendar.Margin = new System.Windows.Forms.Padding(14);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 7;
            // 
            // BApply
            // 
            this.BApply.Location = new System.Drawing.Point(203, 284);
            this.BApply.Name = "BApply";
            this.BApply.Size = new System.Drawing.Size(130, 42);
            this.BApply.TabIndex = 8;
            this.BApply.Text = "Подтвердить";
            this.BApply.UseVisualStyleBackColor = true;
            this.BApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(205, 332);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(130, 42);
            this.BCancel.TabIndex = 9;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check1.ForeColor = System.Drawing.Color.Red;
            this.Check1.Location = new System.Drawing.Point(337, 48);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(17, 24);
            this.Check1.TabIndex = 10;
            this.Check1.Text = "*";
            this.toolTip1.SetToolTip(this.Check1, "Введите корректную фамилию");
            this.Check1.Visible = false;
            // 
            // Check3
            // 
            this.Check3.AutoSize = true;
            this.Check3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check3.ForeColor = System.Drawing.Color.Red;
            this.Check3.Location = new System.Drawing.Point(337, 139);
            this.Check3.Name = "Check3";
            this.Check3.Size = new System.Drawing.Size(17, 24);
            this.Check3.TabIndex = 11;
            this.Check3.Text = "*";
            this.toolTip1.SetToolTip(this.Check3, "Введите корректное отчество");
            this.Check3.Visible = false;
            // 
            // Check2
            // 
            this.Check2.AutoSize = true;
            this.Check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check2.ForeColor = System.Drawing.Color.Red;
            this.Check2.Location = new System.Drawing.Point(337, 93);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(17, 24);
            this.Check2.TabIndex = 12;
            this.Check2.Text = "*";
            this.toolTip1.SetToolTip(this.Check2, "Введите корректное имя");
            this.Check2.Visible = false;
            // 
            // toolTip1
            // 
            // 
            // CBTeachers
            // 
            this.CBTeachers.FormattingEnabled = true;
            this.CBTeachers.Location = new System.Drawing.Point(125, 12);
            this.CBTeachers.Name = "CBTeachers";
            this.CBTeachers.Size = new System.Drawing.Size(210, 28);
            this.CBTeachers.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Препод:";
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBTeachers);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check3);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BApply);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.LDate);
            this.Controls.Add(this.TPatronymic);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.TSurname);
            this.Controls.Add(this.LPatronymic);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSurname;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LPatronymic;
        private System.Windows.Forms.TextBox TSurname;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TPatronymic;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button BApply;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label Check1;
        private System.Windows.Forms.Label Check3;
        private System.Windows.Forms.Label Check2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CBTeachers;
        private System.Windows.Forms.Label label1;
    }
}