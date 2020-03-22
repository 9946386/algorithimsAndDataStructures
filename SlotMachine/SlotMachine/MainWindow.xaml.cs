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

namespace SlotMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dollars;
        Random number;
        int wheel1;
        int wheel2;
        int wheel3;
        Boolean wheel1Clicked = false;
        Boolean wheel2Clicked = false;
        Boolean wheel3Clicked = false;

        public MainWindow()
        {
            InitializeComponent();
            number = new Random(DateTime.Now.Millisecond);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonAddCash_Click(object sender, RoutedEventArgs e)
        {
            dollars = dollars + 10; // Add $10 to the total
            textBlockDollars.Text = "You have $" + dollars;
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            wheel1 = number.Next(1, 7);
            wheel2 = number.Next(1, 7);
            wheel3 = number.Next(1, 7);
            buttonPlay.Content = "You spun a " + wheel1;

            #region wheel1
            //Images on wheel 1
            if (wheel1 == 1) imageWheel1.Source = new BitmapImage(new Uri("lose.png", UriKind.RelativeOrAbsolute));
            else if (wheel1 == 2) imageWheel1.Source = new BitmapImage(new Uri("spade.png",UriKind.RelativeOrAbsolute));
            else if (wheel1 == 3) imageWheel1.Source = new BitmapImage(new Uri("club.png",UriKind.RelativeOrAbsolute));
            else if (wheel1 == 4) imageWheel1.Source = new BitmapImage(new Uri("heart.png",UriKind.RelativeOrAbsolute));
            else if (wheel1 == 5) imageWheel1.Source = new BitmapImage(new Uri("diamond.png",UriKind.RelativeOrAbsolute));
            else imageWheel1.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            #endregion

            #region wheel2
            //Images on wheel 2
            if (wheel2 == 1) imageWheel2.Source = new BitmapImage(new Uri("lose.png", UriKind.RelativeOrAbsolute));
            else if (wheel2 == 2) imageWheel2.Source = new BitmapImage(new Uri("spade.png", UriKind.RelativeOrAbsolute));
            else if (wheel2 == 3) imageWheel2.Source = new BitmapImage(new Uri("club.png", UriKind.RelativeOrAbsolute));
            else if (wheel2 == 4) imageWheel2.Source = new BitmapImage(new Uri("heart.png", UriKind.RelativeOrAbsolute));
            else if (wheel2 == 5) imageWheel2.Source = new BitmapImage(new Uri("diamond.png", UriKind.RelativeOrAbsolute));
            else imageWheel2.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            #endregion

            #region wheel3
            //Images on wheel 3
            if (wheel3 == 1) imageWheel3.Source = new BitmapImage(new Uri("lose.png", UriKind.RelativeOrAbsolute));
            else if (wheel3 == 2) imageWheel3.Source = new BitmapImage(new Uri("spade.png", UriKind.RelativeOrAbsolute));
            else if (wheel3 == 3) imageWheel3.Source = new BitmapImage(new Uri("club.png", UriKind.RelativeOrAbsolute));
            else if (wheel3 == 4) imageWheel3.Source = new BitmapImage(new Uri("heart.png", UriKind.RelativeOrAbsolute));
            else if (wheel3 == 5) imageWheel3.Source = new BitmapImage(new Uri("diamond.png", UriKind.RelativeOrAbsolute));
            else imageWheel3.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            #endregion

            #region wheel1Clicked
            if (wheel1Clicked == false)
            {
                if (wheel1 == 1) imageWheel1.Source = new BitmapImage(new Uri("lose.png",
                                                                      UriKind.RelativeOrAbsolute));
                else if (wheel1 == 2) imageWheel1.Source = new BitmapImage(new Uri("spade.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel1 == 3) imageWheel1.Source = new BitmapImage(new Uri("club.png",
                                                                       UriKind.RelativeOrAbsolute));
                else if (wheel1 == 4) imageWheel1.Source = new BitmapImage(new Uri("heart.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel1 == 5) imageWheel1.Source = new BitmapImage(new Uri("diamond.png",
                                                                           UriKind.RelativeOrAbsolute));
                else imageWheel1.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            }
            #endregion

            #region wheel2Clicked
            if (wheel2Clicked == false)
            {
                if (wheel1 == 2) imageWheel2.Source = new BitmapImage(new Uri("lose.png",
                                                                      UriKind.RelativeOrAbsolute));
                else if (wheel2 == 2) imageWheel2.Source = new BitmapImage(new Uri("spade.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel2 == 3) imageWheel2.Source = new BitmapImage(new Uri("club.png",
                                                                       UriKind.RelativeOrAbsolute));
                else if (wheel2 == 4) imageWheel2.Source = new BitmapImage(new Uri("heart.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel2 == 5) imageWheel2.Source = new BitmapImage(new Uri("diamond.png",
                                                                           UriKind.RelativeOrAbsolute));
                else imageWheel2.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            }
            #endregion

            #region wheel3Clicked
            if (wheel3Clicked == false)
            {
                if (wheel3 == 1) imageWheel3.Source = new BitmapImage(new Uri("lose.png",
                                                                      UriKind.RelativeOrAbsolute));
                else if (wheel3 == 2) imageWheel3.Source = new BitmapImage(new Uri("spade.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel3 == 3) imageWheel3.Source = new BitmapImage(new Uri("club.png",
                                                                       UriKind.RelativeOrAbsolute));
                else if (wheel3 == 4) imageWheel3.Source = new BitmapImage(new Uri("heart.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel3 == 5) imageWheel3.Source = new BitmapImage(new Uri("diamond.png",
                                                                           UriKind.RelativeOrAbsolute));
                else imageWheel3.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            }
            #endregion

            dollars = dollars - 1;
            textBlockDollars.Text = "You have $" + dollars;

            if (wheel1Clicked == false) wheel1 = number.Next(1, 7);
            if (wheel2Clicked == false) wheel2 = number.Next(1, 7);
            if (wheel3Clicked == false) wheel3 = number.Next(1, 7);

            if (wheel1Clicked == true) dollars = dollars - 20;
            if (wheel2Clicked == true) dollars = dollars - 20;
            if (wheel3Clicked == true) dollars = dollars - 20;

            //imageWheel1.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            //imageWheel2.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            //imageWheel3.Source = new BitmapImage(new Uri("win.png", UriKind.RelativeOrAbsolute));
            imageWinLose.Source = new BitmapImage(new Uri("WinGame.png", UriKind.RelativeOrAbsolute));
        }

        private void imageWheel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (wheel1Clicked == false)
            {
                wheel1Clicked = true;
                imageWheel1.Opacity = 0.5f;
            }
            else
            {
                wheel1Clicked = false;
                imageWheel1.Opacity = 1f;
            }
        }

        private void imageWheel2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (wheel2Clicked == false)
            {
                wheel2Clicked = true;
                imageWheel2.Opacity = 0.5f;
            }
            else
            {
                wheel2Clicked = false;
                imageWheel2.Opacity = 1f;
            }
        }

        private void imageWheel3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (wheel3Clicked == false)
            {
                wheel3Clicked = true;
                imageWheel3.Opacity = 0.5f;
            }
            else
            {
                wheel3Clicked = false;
                imageWheel3.Opacity = 1f;
            }
        }
    }
}
