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
    public partial class UserControl1 : UserControl
    {
        public UserControl1(int id,Form1 form,DateTime date)
        {
            InitializeComponent(id,form,date);
            InitializeComponentsManual(form,date);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void UserControlClicked(object sender, EventArgs e)
        {
            eventcreator ec = new eventcreator(this.date,this.formRef);
            ec.Show();
        }
    }
}
