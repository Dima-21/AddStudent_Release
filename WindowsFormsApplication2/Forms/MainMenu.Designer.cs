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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.LBStudents = new System.Windows.Forms.ListBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTeachers = new System.Windows.Forms.ComboBox();
            this.BChange = new System.Windows.Forms.Button();
            this.BSMS = new System.Windows.Forms.Button();
            this.ToolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CountTeacher = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.CountStudent = new System.Windows.Forms.ToolStripLabel();
            this.FileMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.ToolStripBottom.SuspendLayout();
            this.ToolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBStudents
            // 
            this.LBStudents.FormattingEnabled = true;
            this.LBStudents.Location = new System.Drawing.Point(12, 106);
            this.LBStudents.Name = "LBStudents";
            this.LBStudents.Size = new System.Drawing.Size(118, 173);
            this.LBStudents.TabIndex = 0;
            this.LBStudents.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.Location = new System.Drawing.Point(136, 106);
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
            this.BRemove.Location = new System.Drawing.Point(136, 148);
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
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Студенты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Преподаватели:";
            // 
            // CBTeachers
            // 
            this.CBTeachers.FormattingEnabled = true;
            this.CBTeachers.Location = new System.Drawing.Point(12, 58);
            this.CBTeachers.Name = "CBTeachers";
            this.CBTeachers.Size = new System.Drawing.Size(118, 21);
            this.CBTeachers.TabIndex = 5;
            this.CBTeachers.SelectedIndexChanged += new System.EventHandler(this.CBTeachers_SelectedIndexChanged_1);
            // 
            // BChange
            // 
            this.BChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BChange.Location = new System.Drawing.Point(136, 188);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(91, 34);
            this.BChange.TabIndex = 6;
            this.BChange.Text = "Change";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // BSMS
            // 
            this.BSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSMS.Location = new System.Drawing.Point(136, 228);
            this.BSMS.Name = "BSMS";
            this.BSMS.Size = new System.Drawing.Size(91, 34);
            this.BSMS.TabIndex = 7;
            this.BSMS.Text = "SMS";
            this.BSMS.UseVisualStyleBackColor = true;
            this.BSMS.Click += new System.EventHandler(this.BSMS_Click);
            // 
            // ToolStripBottom
            // 
            this.ToolStripBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.CountTeacher,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.CountStudent});
            this.ToolStripBottom.Location = new System.Drawing.Point(0, 283);
            this.ToolStripBottom.Name = "ToolStripBottom";
            this.ToolStripBottom.Size = new System.Drawing.Size(249, 25);
            this.ToolStripBottom.TabIndex = 9;
            this.ToolStripBottom.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel1.Text = "К-во преподов: ";
            // 
            // CountTeacher
            // 
            this.CountTeacher.Name = "CountTeacher";
            this.CountTeacher.Size = new System.Drawing.Size(13, 22);
            this.CountTeacher.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel2.Text = "К-во студентов:";
            // 
            // CountStudent
            // 
            this.CountStudent.Name = "CountStudent";
            this.CountStudent.Size = new System.Drawing.Size(13, 22);
            this.CountStudent.Text = "0";
            // 
            // FileMenu
            // 
            this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.FileMenu.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu.Image")));
            this.FileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(41, 22);
            this.FileMenu.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveToolStripMenuItem.Text = "Save to file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ToolStripTop
            // 
            this.ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 0);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Size = new System.Drawing.Size(249, 25);
            this.ToolStripTop.TabIndex = 11;
            this.ToolStripTop.Text = "toolStrip2";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 308);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.ToolStripBottom);
            this.Controls.Add(this.BSMS);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.CBTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.LBStudents);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ToolStripBottom.ResumeLayout(false);
            this.ToolStripBottom.PerformLayout();
            this.ToolStripTop.ResumeLayout(false);
            this.ToolStripTop.PerformLayout();
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
        private System.Windows.Forms.Button BSMS;
        private System.Windows.Forms.ToolStrip ToolStripBottom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel CountTeacher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel CountStudent;
        private System.Windows.Forms.ToolStripSplitButton FileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripTop;
    }
}

