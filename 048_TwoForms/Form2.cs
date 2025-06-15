using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _048_TwoForms
{
    public partial class Form2: Form
    {
        Form1 f = null;
        public Form2(Form1 form)
        {
            InitializeComponent();
            f = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Hide();
        }
    }
}
