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
    public partial class MainMenu : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Student> FilterStudent = new List<Student>();
        BindingSource bsStudents = new BindingSource();
        BindingSource bsTeachers = new BindingSource();
        public MainMenu()
        {
            InitializeComponent();
            bsStudents.DataSource = FilterStudent;
            LBStudents.DataSource = bsStudents;
            LBStudents.DisplayMember = "FIO";

            bsTeachers.DataSource = teachers;
            CBTeachers.DataSource = bsTeachers;
            CBTeachers.DisplayMember = "Name";
           
            teachers.Add(new Teacher { Name = "Клепач В.Д."});
            teachers.Add(new Teacher { Name = "Чумак" });
            teachers.Add(new Teacher { Name = "Хилько" });
            bsTeachers.ResetBindings(false);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            var selItem = LBStudents.SelectedItem as Student;

            var wnd = new Dialog();
            wnd.NameP = selItem.Name;
            wnd.Surname = selItem.Surname;
            wnd.Patronymic = selItem.Patronymic;
            wnd.Birthday = selItem.Birthday;
            //wnd.Teachers = teachers;
            wnd.ShowDialog();
            wnd.Dispose();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            var wnd = new Dialog();
            wnd.Teachers = teachers;
            if (wnd.ShowDialog() == DialogResult.OK)
            {
                students.Add(new Student { Name = wnd.NameP,  Surname = wnd.Surname, Patronymic = wnd.Patronymic, Birthday = wnd.Birthday});
                foreach (var teacher in teachers)
                {
                    if (teacher.Name == wnd.SelectTeacher)
                        teacher.Students.Add(students.Last());
                }
            }
            wnd.Dispose();
            bsStudents.ResetBindings(false);
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            students.Remove(LBStudents.SelectedItem as Student);
            bsStudents.ResetBindings(false);
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            if (LBStudents.SelectedItems.Count != 0)
            {
                var selItem = LBStudents.SelectedItem as Student;
                var wnd = new Dialog();
                wnd.NameP = selItem.Name;
                wnd.Surname = selItem.Surname;
                wnd.Patronymic = selItem.Patronymic;
                wnd.Birthday = selItem.Birthday;
                wnd.ShowDialog();
                wnd.Dispose();
            }
        }

        private void CBTeachers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FilterStudent.Clear();
            foreach (var item in teachers)
                if (item == (CBTeachers.SelectedItem as Teacher))
                    foreach (var item1 in item.Students)
                        if(item.Students.Count > 0)
                            FilterStudent.Add(item1);

            bsStudents.ResetBindings(false);
        }
    }
}
