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
        public SendSMS()
        {
            InitializeComponent();
        }
        public String PhoneNumber {
            get{ return CBNumber.SelectedItem.ToString(); }
            set { CBNumber.SelectedItem = value; }
        }
        public String SMSText { get; set; }
        public int MyProperty { get; set; }
    }
}
