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
        List<Person> persons = new List<Person>();
        List<string> teachers = new List<string>();
        BindingSource bsStudents = new BindingSource();
        BindingSource bsTeachers = new BindingSource();
        public MainMenu()
        {
            InitializeComponent();
            bsStudents.DataSource = persons;
            LBStudents.DataSource = bsStudents;
            LBStudents.DisplayMember = "FIO";

            bsTeachers.DataSource = teachers;
            CBTeachers.DataSource = bsTeachers;
            CBTeachers.DisplayMember = "teachers";
           
            teachers.Add("Клепач В.Д.");
            teachers.Add("Чумак");
            teachers.Add("Хилько");
            bsTeachers.ResetBindings(false);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            var selItem = LBStudents.SelectedItem as Person;

            var wnd = new Dialog();
            wnd.NameP = selItem.Name;
            wnd.Surname = selItem.Surname;
            wnd.Patronymic = selItem.Patronymic;
            wnd.Birthday = selItem.Birthday;
            wnd.SelectTeacher = selItem.Teacher;
            wnd.Teachers = teachers;
            wnd.ShowDialog();
            wnd.Dispose();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            var wnd = new Dialog();
            wnd.Teachers = teachers;
            if (wnd.ShowDialog() == DialogResult.OK)
            {
                persons.Add(new Person(wnd.NameP, wnd.Surname, wnd.Patronymic, wnd.Birthday));
            }
            wnd.Dispose();
            bsStudents.ResetBindings(false);
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            persons.Remove(LBStudents.SelectedItem as Person);
            bsStudents.ResetBindings(false);
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            if (LBStudents.SelectedItems.Count != 0)
            {
                var selItem = LBStudents.SelectedItem as Person;
                var wnd = new Dialog();
                wnd.NameP = selItem.Name;
                wnd.Surname = selItem.Surname;
                wnd.Patronymic = selItem.Patronymic;
                wnd.Birthday = selItem.Birthday;
                wnd.ShowDialog();
                wnd.Dispose();
            }
        }
    }
}
