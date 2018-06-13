using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }



        public string SelectTeacher
        {
            get { return CBTeachers.SelectedItem as String; }
            set { CBTeachers.SelectedItem = value; }
        }

        public List<Teacher> Teachers
        {
            set
            {
                CBTeachers.Items.Clear();
                CBTeachers.Items.AddRange(value.Select(x => x.Name).ToArray());
            }
        }

        public DateTime Birthday
        {
            get
            {
                return Calendar.SelectionStart;
            }
            set
            {
                Calendar.BoldedDates = new DateTime[] { value };
                Calendar.SelectionStart = value;
            }
        }

        public String NameP
        {
            get
            {
                return TName.Text;
            }
            set
            {
                TName.Text = value;
            }
        }
        public String Surname
        {
            get
            {
                return TSurname.Text;
            }
            set
            {
                TSurname.Text = value;
            }
        }
        public String Patronymic
        {
            get
            {
                return TPatronymic.Text;
            }
            set
            {
                TPatronymic.Text = value;
            }
        }

        public String Phone
        {
            get
            {
                if (TPhone.Text[0] == '0')
                    return TPhone.Text.Insert(0, "+38");
                else
                    return TPhone.Text.Insert(0, "+");
            }
            set { TPhone.Text = value; }
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private bool CheckNumber()
        {
            if ((TPhone.Text.Length == 10 && TPhone.Text[0] == '0') ||
                (TPhone.Text.Length == 12 && TPhone.Text.Substring(0, 3) == "380"))
                return true;
            return false;
        }

        private bool Check()
        {
            if (Surname == "" || NameP == "" || Patronymic == "" || !CheckNumber())
            {
                if (Surname == "")
                    Check1.Visible = true;
                else
                    Check1.Visible = false;
                if (NameP == "")
                    Check2.Visible = true;
                else
                    Check2.Visible = false;
                if (Patronymic == "")
                    Check3.Visible = true;
                else
                    Check3.Visible = false;
                if (!CheckNumber())
                    Check5.Visible = true;
                else
                    Check5.Visible = false;
                return false;
            }
            return true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || TPhone.Text.Length > 13)
                e.Handled = true;
        }

        private void PressKey(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

    }
}
