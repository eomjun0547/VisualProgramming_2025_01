﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmiForm
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //btn_BMI가 Click 되었을 때 생기는 이벤트를 처리하는 함수
        private void btn_BMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;
            double bmi = w / (h * h);
            lblBMI.Text = "BMI = " + bmi.ToString();
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
