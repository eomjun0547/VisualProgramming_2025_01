using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_Grade
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "일반수학1";
            txt3.Text = "디지털공학 및 실험";
            txt4.Text = "비주얼 프로그래밍";
            txt5.Text = "설계 및 프로젝트 기본1";
            txt6.Text = "데이터 사이언스";
        }
    }
}
