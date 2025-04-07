using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
            double tScore = 0;
            double tCredit = 0;

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != " ")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    tCredit += crd;
                    tScore += crd * GetScore(grds[i].SelectedItem.ToString());
                }
            }
            txtGrade.Text = (tScore / tCredit).ToString("0.00");
        }

        private double GetScore(string v)
        {
            if (v == "A+") return 4.5;
            else if (v == "A0") return 4.0;
            else if (v == "B+") return 3.5;
            else if (v == "B0") return 3.0;
            else if (v == "C+") return 2.5;
            else if (v == "C0") return 2.0;
            else if (v == "D+") return 1.5;
            else if (v == "D0") return 1.0;
            else return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "일반수학1";
            txt3.Text = "디지털공학 및 실험";
            txt4.Text = "비주얼 프로그래밍";
            txt5.Text = "설계 및 프로젝트 기본1";
            txt6.Text = "데이터 사이언스";

            crds = new ComboBox[] {crd1, crd2, crd3 ,crd4, crd5, crd6, crd7};
            grds = new ComboBox[] {grd1, grd2, grd3, grd4, grd5, grd6, grd7};
            titles = new TextBox[] {txt1, txt2, txt3, txt4, txt5, txt6, txt7};

            int[] arrCredit = {1,2,3,4,5};
            List<string> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };


            foreach (ComboBox c in crds)
            {
                foreach (int i in arrCredit)
                {
                    c.Items.Add(i);
                }
                c.SelectedItem = 2; // 선택된 아이탬은 2로 설정, 디톨트 넘버
            }

            foreach(ComboBox c in grds)
            {
                foreach(string s in lstGrade)
                {
                    c.Items.Add(s);
                }
                c.SelectedItem = "A+";
            }

            /*foreach (ComboBox c in grds)
            {
                c.Items.Add("A+");
                c.Items.Add("A0");
                c.Items.Add("B+");
                c.Items.Add("B0");
                c.Items.Add("C+");
                c.Items.Add("C0");
                c.Items.Add("D+");
                c.Items.Add("D0");
                c.Items.Add("F");

                c.SelectedItem = "A+";
            }*/

            /*foreach (ComboBox c in crds) 
            {
                c.Items.Add(1);
                c.Items.Add(2);
                c.Items.Add(3);
                c.Items.Add(4);
                c.Items.Add(5);

            }*/
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
