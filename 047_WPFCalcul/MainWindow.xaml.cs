using System;
using System.Windows;
using System.Windows.Controls;

namespace _047_WPFCalcul
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double saved; // 연산자 버튼이 눌렸을 때, txtResult에 있던 값을 저장하는 곳
        string op; // 연산자 버튼이 눌렸을 때, 어떤 연산자인지 저장
        bool opFlag = false; // 연산자 버튼이 눌렸을 때, 숫자가 새로 써지게 한다
        bool afterCalc = false; // = 버튼이 눌려서 계산이 끝났을 때, 숫자가 새로 써지게 한다
        double memory = 0;
        bool memFlag = false; // 메모리 버튼이 눌린 후, 새로 숫자

        public MainWindow()
        {
            InitializeComponent();
        }

        // 숫자1 버튼
        // 버튼의 Content가 버튼의 이름으로 설정되어 있음
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (txtResult.Text == "0" 
                || opFlag == true
                || afterCalc == true
                || memFlag == true)
            {
                txtResult.Text = btn.Content.ToString();
                opFlag = false;
                afterCalc = false;
                memFlag = false;
            }
            else
            {
                txtResult.Text += btn.Content.ToString();
            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else 
                txtResult.Text += ".";
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (-1 * double.Parse(txtResult.Text)).ToString(); // 문자열을 double로 변환 후 * -1을 곱함 -> 다시 문자열로 변환
        }

        // ＋ － × ÷
        // 버튼의 Content가 연산자의 이름으로 설정되어 있음
        private void opClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            saved = double.Parse(txtResult.Text);
            op = btn.Content.ToString();
            opFlag = true;
            txtExp.Text += saved.ToString() + " " + op + " ";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            txtExp.Text += txtResult.Text + " = ";
            switch (op)
            {
                case "＋":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "－":
                    txtResult.Text = (saved - v).ToString();
                    break;
                case "×":
                    txtResult.Text = (saved * v).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved / v).ToString();
                    break;
            }
            afterCalc = true;
        }

        private void btnReci_Click(object sender, RoutedEventArgs e)
        {
           if (txtExp.Text== "")
                txtExp.Text += "1/(" + txtResult.Text + ")";
           else
                txtExp.Text += "1/(" + txtExp.Text + ")";
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (1 / v).ToString();
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text += "sqr(" + txtResult.Text + ")";
            else
                txtExp.Text += "sqr(" + txtExp.Text + ")";
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (v * v).ToString();
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text += "√(" + txtResult.Text + ")";
            else
                txtExp.Text += "√(" + txtExp.Text + ")";
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (Math.Sqrt(v)).ToString();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
            op = "";
            opFlag = false;
            saved= 0;
            txtExp.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);

            if (txtResult.Text.Length == 0 )
            {
                txtResult.Text = "0";
            }
        }

        // Memory Save 
        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            memory = v;
            btnMC.IsEnabled = true;
            btnMR.IsEnabled = true;
            memFlag = true;
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
            memFlag = true;
            memory = 0;
        }

        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = memory.ToString();
            memFlag = true;
        }

        private void btnMPlus_Click(object sender, RoutedEventArgs e)
        {
            memory += double.Parse(txtResult.Text);
            memFlag = true;
        }

        private void btnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
            memFlag = true;
        }
    }
}
