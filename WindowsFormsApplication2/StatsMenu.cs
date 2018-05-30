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
        }

        public Person StudentName
        {

            set
            {
                LStudent.Text = $"{value.Surname} {value.Name}";
            }
        }

        public List<int> Marks
        {
            get
            {
                return LBMarks.Items.AddRange(value.Select(x => x.ToString()).ToArray());
            }
            set
            {
                LBMarks.Items.Clear();
                LBMarks.Items.AddRange(value.Select(x=>x.ToString()).ToArray());
            }
        }

    }
}
