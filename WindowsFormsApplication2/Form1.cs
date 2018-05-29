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
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = persons;
            listBox.DataSource = bs;
            listBox.DisplayMember = "FIO";
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            var wnd = new Dialog();
            if (wnd.ShowDialog() == DialogResult.OK)
            {
                persons.Add(new Person(wnd.NameP, wnd.Surname, wnd.Patronymic, wnd.Birthday));
            }
            wnd.Dispose();
            bs.ResetBindings(false);
        }



        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            var selItem = listBox.SelectedItem as Person;

            var wnd = new Dialog();
            wnd.NameP = selItem.Name;
            wnd.Surname = selItem.Surname;
            wnd.Patronymic = selItem.Patronymic;
            wnd.Birthday = selItem.Birthday;
            wnd.ShowDialog();
            wnd.Dispose();
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            persons.Remove(listBox.SelectedItem as Person);
            bs.ResetBindings(false);
        }
    }
}
