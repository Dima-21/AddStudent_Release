namespace WindowsFormsApplication2
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
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
            this.Check4 = new System.Windows.Forms.Label();
            this.Check5 = new System.Windows.Forms.Label();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LSurname
            // 
            resources.ApplyResources(this.LSurname, "LSurname");
            this.LSurname.Name = "LSurname";
            this.toolTip1.SetToolTip(this.LSurname, resources.GetString("LSurname.ToolTip"));
            // 
            // LName
            // 
            resources.ApplyResources(this.LName, "LName");
            this.LName.Name = "LName";
            this.toolTip1.SetToolTip(this.LName, resources.GetString("LName.ToolTip"));
            // 
            // LPatronymic
            // 
            resources.ApplyResources(this.LPatronymic, "LPatronymic");
            this.LPatronymic.Name = "LPatronymic";
            this.toolTip1.SetToolTip(this.LPatronymic, resources.GetString("LPatronymic.ToolTip"));
            // 
            // TSurname
            // 
            resources.ApplyResources(this.TSurname, "TSurname");
            this.TSurname.Name = "TSurname";
            this.toolTip1.SetToolTip(this.TSurname, resources.GetString("TSurname.ToolTip"));
            this.TSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressKey);
            // 
            // TName
            // 
            resources.ApplyResources(this.TName, "TName");
            this.TName.Name = "TName";
            this.toolTip1.SetToolTip(this.TName, resources.GetString("TName.ToolTip"));
            // 
            // TPatronymic
            // 
            resources.ApplyResources(this.TPatronymic, "TPatronymic");
            this.TPatronymic.Name = "TPatronymic";
            this.toolTip1.SetToolTip(this.TPatronymic, resources.GetString("TPatronymic.ToolTip"));
            // 
            // LDate
            // 
            resources.ApplyResources(this.LDate, "LDate");
            this.LDate.Name = "LDate";
            this.toolTip1.SetToolTip(this.LDate, resources.GetString("LDate.ToolTip"));
            // 
            // Calendar
            // 
            resources.ApplyResources(this.Calendar, "Calendar");
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.toolTip1.SetToolTip(this.Calendar, resources.GetString("Calendar.ToolTip"));
            // 
            // BApply
            // 
            resources.ApplyResources(this.BApply, "BApply");
            this.BApply.Name = "BApply";
            this.toolTip1.SetToolTip(this.BApply, resources.GetString("BApply.ToolTip"));
            this.BApply.UseVisualStyleBackColor = true;
            this.BApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // BCancel
            // 
            resources.ApplyResources(this.BCancel, "BCancel");
            this.BCancel.Name = "BCancel";
            this.toolTip1.SetToolTip(this.BCancel, resources.GetString("BCancel.ToolTip"));
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // Check1
            // 
            resources.ApplyResources(this.Check1, "Check1");
            this.Check1.ForeColor = System.Drawing.Color.Red;
            this.Check1.Name = "Check1";
            this.toolTip1.SetToolTip(this.Check1, resources.GetString("Check1.ToolTip"));
            // 
            // Check3
            // 
            resources.ApplyResources(this.Check3, "Check3");
            this.Check3.ForeColor = System.Drawing.Color.Red;
            this.Check3.Name = "Check3";
            this.toolTip1.SetToolTip(this.Check3, resources.GetString("Check3.ToolTip"));
            // 
            // Check2
            // 
            resources.ApplyResources(this.Check2, "Check2");
            this.Check2.ForeColor = System.Drawing.Color.Red;
            this.Check2.Name = "Check2";
            this.toolTip1.SetToolTip(this.Check2, resources.GetString("Check2.ToolTip"));
            // 
            // CBTeachers
            // 
            resources.ApplyResources(this.CBTeachers, "CBTeachers");
            this.CBTeachers.FormattingEnabled = true;
            this.CBTeachers.Name = "CBTeachers";
            this.toolTip1.SetToolTip(this.CBTeachers, resources.GetString("CBTeachers.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // Check4
            // 
            resources.ApplyResources(this.Check4, "Check4");
            this.Check4.ForeColor = System.Drawing.Color.Red;
            this.Check4.Name = "Check4";
            this.toolTip1.SetToolTip(this.Check4, resources.GetString("Check4.ToolTip"));
            // 
            // Check5
            // 
            resources.ApplyResources(this.Check5, "Check5");
            this.Check5.ForeColor = System.Drawing.Color.Red;
            this.Check5.Name = "Check5";
            this.toolTip1.SetToolTip(this.Check5, resources.GetString("Check5.ToolTip"));
            // 
            // TPhone
            // 
            resources.ApplyResources(this.TPhone, "TPhone");
            this.TPhone.Name = "TPhone";
            this.toolTip1.SetToolTip(this.TPhone, resources.GetString("TPhone.ToolTip"));
            this.TPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // AddStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Check5);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Check4);
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
            this.Name = "AddStudent";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private System.Windows.Forms.Label Check4;
        private System.Windows.Forms.Label Check5;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label label3;
    }
}