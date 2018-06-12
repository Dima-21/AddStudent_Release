using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Forms
{
    public partial class SendSMS : Form
    {
        private List<Student> students = new List<Student>();

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        private List<Teacher> teachers = new List<Teacher>();

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        private Teacher teacher;
        public Teacher _Teacher
        {
            get { return teacher; }
            set
            {
                teacher = value;
                TName.Text = value.Name;
                CBNumber.Text = value.PhoneNumber;
            }
        }
        public int CountSymbols { get; set; }
        public SendSMS()
        {
            InitializeComponent();
        }
        public String PhoneNumber
        {
            get { return CBNumber.SelectedItem.ToString(); }
            set { CBNumber.SelectedItem = value; }
        }
        public String SMSText
        {
            get { return TextSMS.Text; }
        }
        public int MyProperty { get; set; }

        private void Update()
        {
            TSymbols.Text = SMSText.Count().ToString();

        }

        private void TextSMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Update();
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TextSMS.Text = String.Empty;
        }

        private void BSend_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CBNumber_Click(object sender, EventArgs e)
        {
            TName.Text = String.Empty;
        }

        private void CBNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBNumber.Text == _Teacher.PhoneNumber)
            {
                TName.Text = _Teacher.Name;
            }
            else
                TName.Text = String.Empty;
        }
    }
}
