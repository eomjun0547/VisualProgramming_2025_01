using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_bmiForm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBMI_Click(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;
            double bmi = w / (h * h);
            lblBMI.Text = string.Format("당신의 bmi = {0:f1}", bmi);
            /*lblBMI.Text = "당신의 BMI = " + bmi.ToString();*/

            if (bmi <20)
            {
                lblResult.Text = "판정 : 저체중";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (/*20<= bmi && */bmi < 25)
            {
                lblResult.Text = "판정 : 정상체중";
                pictureBox1.BackColor = Color.Green;
            }
            else if (bmi < 30)
            {
                lblResult.Text = "판정 : 경도비만";
                pictureBox1.BackColor = Color.YellowGreen;
            }
            else if (bmi < 35)
            {
                lblResult.Text = "판정 : 비만";
                pictureBox1.BackColor = Color.OrangeRed;
            }
            else if (bmi >= 40)
            {
                lblResult.Text = "판정 : 고도비만";
                pictureBox1.BackColor = Color.Purple;
            }
        }
    }
}

