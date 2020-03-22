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

namespace Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Create an array
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //Process the array with a for loop
            textBox.Text = "For Loop\n";

            for (int i = 0; i < numbers.Length; i++)
            {
                textBox.Text += numbers[i].ToString();
            }

            //Line break
            textBox.Text += "\n\n";

            //Process the array with a foreach
            textBox.Text += "Foreach\n";

            foreach (int number in numbers)
            {
                textBox.Text = textBox.Text + number.ToString() + " ";
            }

            //Line break
            textBox.Text += "\n\n";

            //Reverse method
            textBox.Text += "Reverse\n";
            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                textBox.Text = textBox.Text + number.ToString() + " ";
            }

            //Line break
            textBox.Text += "\n\n";

            //Sort method
            textBox.Text += "Sort\n";
            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                textBox.Text = textBox.Text + number.ToString() + " ";
            }

            //Line break
            textBox.Text += "\n\n";

            //Another array method.
            textBox.Text += "Get Value\n";
            textBox.Text += numbers.GetValue(5);

        }
        //Clear the text box
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = null;

            //Multidimensional

            //2D array
            int[,] numbers2 = new int[4, 3] { { 1, 10, 100 },
                                              { 2, 20, 200 },
                                              { 3, 30, 300 },
                                              { 4, 40, 400} };

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    textBox.Text += numbers2[row, col].ToString() + " | ";
                }
                textBox.Text += "\n";
            }

            foreach (int num2 in numbers2)
            {
                textBox.Text +=  num2.ToString() + " ";
            }
            textBox.Text += "\n";
        }


    }
}
