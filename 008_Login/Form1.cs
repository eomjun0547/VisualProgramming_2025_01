using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblPS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)+
        {
            if (txtID.Text == "abcd" && txtPS.Text == "1234")
            {
                txtResult.Text = "로그인 성공";
            }
            else
            {
                txtResult.Text = "로그인 실패";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
