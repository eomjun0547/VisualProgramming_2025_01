using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtC.Text != " " && txtF.Text != " ")
                return;

            else if (txtC.Text != " " && txtF.Text == " ") // txtC가 빈칸이 아니고 txtF가 빈칸일 때
            {
                double c = double.Parse(txtC.Text);
                double f = c * 9 / 5 + 32;
                txtF.Text = f.ToString();
            }
            else if (txtC.Text == " " && txtF.Text != " ") // txtC가 빈칸이고 txtF가 빈칸이 아닐 때
            {
                double f = double.Parse(txtF.Text);
                double c = (f - 32) / 5 / 9;
                txtC.Text = c.ToString();
            }
 
        }
    }
}
