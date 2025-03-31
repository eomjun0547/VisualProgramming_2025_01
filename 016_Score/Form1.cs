using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(txtK.Text)
                + Convert.ToDouble(txtM.Text)
                + Convert.ToDouble(txtE.Text);

            double avg = sum / 3;

            textBox4.Text = sum.ToString("#.##");
            textBox5.Text = avg.ToString("#.##");
        }
    }
}
