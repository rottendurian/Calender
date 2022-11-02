using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class eventcreator : Form
    {
        public eventcreator()
        {
            InitializeComponent();
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {
            string i = EventName.Text;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EventName.Text + "\n" + dateTimePicker1.Value);
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;

        }
    }
}
