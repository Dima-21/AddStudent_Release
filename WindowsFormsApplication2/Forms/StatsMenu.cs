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
    public partial class StatsMenu : Form
    {
        EventHandler<MarkEventArgs> _markChanged;

        public event EventHandler<MarkEventArgs> MarkChanged
        {
            add
            {
                _markChanged += value;
            }
            remove
            {
                _markChanged -= value;
            }
        }

        

        public StatsMenu()
        {
            InitializeComponent();
            
        }

             
        public string TeacherName
        {
            set
            {
                LTeacher.Text = value;
            }
            get
            {
                return LTeacher.Text;
            }
        }

        public string StudentName
        {

            set
            {
                LStudent.Text = value;
            }
            get
            {
               return LStudent.Text;
            }
        }

        public String SelectedMark
        {
            get { return CBMarks.SelectedItem as string; }
        }

        public List<int> Marks
        {
            get
            {
                return LBMarks.Items.OfType<String>().Select(x => int.Parse(x)).ToList();
            }
            set
            {
                LBMarks.Items.Clear();
                LBMarks.Items.AddRange(value.Select(x => x.ToString()).ToArray());
            }
        }

        private MarkEventArgs InfoMarks()
        {
            return new MarkEventArgs { StudentName = this.StudentName, _Marks = Marks };
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            Marks.Add(int.Parse(CBMarks.Text));
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            _markChanged?.Invoke(this, InfoMarks());
            this.DialogResult = DialogResult.OK;
        }
    }
}
