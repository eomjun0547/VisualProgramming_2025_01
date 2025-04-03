using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            chart1.Titles.Add("성적"); // 그래프 타이틀

            for(int i = 0; i < 30; i++) // 막대 갯수
            {
                //chart1.Series[0].Points.Add((i + 1) * 10);
                chart1.Series[0].Points.Add(r.Next(101)); 
            }
            chart1.Series[0].LegendText = "비주얼\n프로그래밍"; //그래프 범례
        }
    }
}
