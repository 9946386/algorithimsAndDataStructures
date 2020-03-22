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

namespace week2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void castExercises_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Casting Exercises\n";

            int a = 20 * (int)1.5; //20
            textBlock.Text = textBlock.Text + "\na = " + a.ToString();

            int b = (int)(2 + 2.2); //4
            textBlock.Text = textBlock.Text + "\nb = " + b.ToString();

            int c = 2 + (int)(5.5 - 5); //2
            textBlock.Text = textBlock.Text + "\nc = " + c.ToString();

            int d = (int)((double)(2.2 + 2.1 + 2) + 2); //8
            textBlock.Text = textBlock.Text + "\nd = " + d.ToString();

            double ee = 20 * 1.5; //30
            textBlock.Text = textBlock.Text + "\ne = " + ee.ToString();

            double f = (double)2 * 1.5; //3
            textBlock.Text = textBlock.Text + "\nf = " + f.ToString();

            double g = 2 * (int)(1.5 * 10.0); //30
            textBlock.Text = textBlock.Text + "\ng = " + g.ToString();

            double h = (2 + 2 + 2 + 2) * (int)2.8; //16
            textBlock.Text = textBlock.Text + "\nh = " + h.ToString();

            double i = (int)2.2222; //2
            textBlock.Text = textBlock.Text + "\ni = " + i.ToString();

            double j = (double)2; //2
            textBlock.Text = textBlock.Text + "\nj = " + j.ToString();

        }

        private void operatorExercises_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Operator Exercises\n";

            //int a = 2 + 3 - 2 * 3 + 2 * 6;
            //textBlock.Text = textBlock.Text + "\na = " + a.ToString();

            //int b = 2 + 3 % 2 * 3 + 2 + 6;
            //textBlock.Text = textBlock.Text + "\nb = " + b.ToString();

            //int c = 2 * (2 + 3) * 2 % 3 % 2 + 6;
            //textBlock.Text = textBlock.Text + "\nc = " + c.ToString();

            //int d = 2;
            //d = d - 2 + d * ((2 + 3) * d) + (6 - 3 * 2) *2;
            //textBlock.Text = textBlock.Text + "\nd = " + d.ToString();

            //int ee = 2;
            //ee /= 2; //1
            //ee *= 2; //2
            //ee *= ee + 8; //20
            //ee %= 2; //0
            //textBlock.Text = textBlock.Text + "\ne = " + ee.ToString();

            int a = 5;
            int b = 10;
            int ee = 20;
            int f = 40;
            if((a == 5) || (b <= 10) && (ee < f) || (a == f) || (a == 5) || (a == 5))
            {
                textBlock.Text = "True";
            }
            else
            {
                textBlock.Text = "False";
            }  

        }

        private void iterationExercises_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Iteration Exercises\n";
            for (int loop = 0; loop < 5; loop++) //0, 1, 2, 3, 4
            {
                textBlock.Text = textBlock.Text + loop + ", ";
            }
            textBlock.Text = textBlock.Text + "\n";

            for (int loop = 0; loop <= 5; loop++) //0, 1, 2, 3, 4, 5
            {
                textBlock.Text = textBlock.Text + loop + ", ";
            }
            textBlock.Text = textBlock.Text + "\n";

            for (int loop = 10; loop >= 0; loop--) //10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0
            {
                textBlock.Text = textBlock.Text + loop + ", ";
            }
            textBlock.Text = textBlock.Text + "\n";

            for (int loop = 10; loop > 0; loop--) //10, 9, 8, 7, 6, 5, 4, 3, 2, 1
            {
                textBlock.Text = textBlock.Text + loop + ", ";
            }
            textBlock.Text = textBlock.Text + "\n";

            for (int loop = 9; loop > 0; loop = loop - 3) //9, 6, 3
            {
                textBlock.Text = textBlock.Text + loop + ", ";
            }
            textBlock.Text = textBlock.Text + "\n";

            for (int loop = 2; loop >= -3; loop--) //2, 1, 0, -1, -2, -3
            {
                textBlock.Text = textBlock.Text + loop + ", ";
            }
            textBlock.Text = textBlock.Text + "\n";
        }
    }
}
