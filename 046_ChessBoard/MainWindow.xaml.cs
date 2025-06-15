using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _046_ChessBoard
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() //생성자 함수
        {
            InitializeComponent();

            // 코딩으로 체스판 만들기 (Rectangle 64개를 만들어서 ChessBoard에 추가)
            // 0, 2, 4, 6 줄은 검은색 빨간색으로 반복
            // 1 ,3, 5, 7 줄은 빨간색 검은색으로 반복

            ChessBoard.Rows = 8;
            ChessBoard.Columns = 8;

            for (int i = 0; i < 8; i++)  // 8줄 반복 , i가 세로 줄
            {
                for (int j = 0; j < 4; j++) // 각 줄에 대해서 4번 반복
                {
                    if (i % 2 == 0) // 짝수줄 , 짝수줄이면 검은색 먼저
                    {
                        Rectangle r1 = new Rectangle();
                        r1.Fill = Brushes.Black;
                        ChessBoard.Children.Add(r1);

                        Rectangle r2 = new Rectangle();
                        r2.Fill = Brushes.Red;
                        ChessBoard.Children.Add(r2);
                    }
                    else // 홀수줄 , 홀수줄이면 빨간색 먼저
                    {
                        Rectangle r1 = new Rectangle();
                        r1.Fill = Brushes.Red;
                        ChessBoard.Children.Add(r1);

                        Rectangle r2 = new Rectangle();
                        r2.Fill = Brushes.Black;
                        ChessBoard.Children.Add(r2);
                    }
                }
            }
        }
    }
}
