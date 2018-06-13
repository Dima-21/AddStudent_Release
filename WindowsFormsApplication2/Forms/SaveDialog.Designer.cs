namespace WindowsFormsApplication2.Forms
{
    partial class SaveDialog
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
            this.BSave = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите выйти без сохранения?";
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(176, 74);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Save";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(257, 74);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // SaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 109);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.label1);
            this.Name = "SaveDialog";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BCancel;
    }
}