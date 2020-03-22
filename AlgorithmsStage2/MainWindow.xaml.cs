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

namespace AlgorithmsStage2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Movement flags   
        bool testFlag1X = true;
        bool testFlag1Y = true;
        bool testFlag2X = true;
        bool testFlag2Y = true;
        #endregion
        
        #region Key Pressed Flags

        bool flagA = false;
        bool flagD = false;
        bool flagW = false;
        bool flagS = false;

        #endregion

        #region Random Number

        // Add code here

        #endregion


        public MainWindow()
        {
            InitializeComponent();

            #region Random Number

            // Add code here

            #endregion

            // Set game loop timer
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(10000); // 10000 ticks = 1 milisecond
            dispatcherTimer.Start();
        }

        /// <summary>
        /// Our time event that fires the movement
        /// </summary>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            
            #region Move using a key press
            Move(testImage1, flagA, flagD, flagW, flagS, 5.00);
            #endregion

            #region Lock_To_Grid

            Walls(testImage1);

            #endregion

            #region Move_Lock_To_Grid

            Bounce(testImage1);

            #endregion

            #region Follow

            Follow(testImage1, testImage2);

            #endregion

            #region Runaway

            Runaway(testImage1, testImage3);

            #endregion

            #region Collide

            // Add code here

            #endregion

            #region Random Number

            // Add code here

            #endregion

        }

        #region Move using a key press
        /// <summary>
        /// Move an Image
        /// </summary>
        public void Move(Image anImage, bool left, bool right, bool top, bool bottom, double speed)
        {
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;


            if (left == true) leftMargin = leftMargin - speed;
            if (right == true) leftMargin = leftMargin + speed;
            if (top == true) topMargin = topMargin - speed;
            if (bottom == true) topMargin = topMargin + speed;

            anImage.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }
        #endregion

        #region Lock_To_Grid

        public void Walls(Image anImage)
        {
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;

            if ((leftMargin + anImage.Width) > TestGrid.Width) leftMargin = TestGrid.Width - anImage.Width; //Right side
            if (leftMargin <= 0) leftMargin = 0; //Left side
            if ((topMargin + anImage.Height) > TestGrid.Height) topMargin = TestGrid.Height - anImage.Height; //Bottom
            if (topMargin <= 0) topMargin = 0; //Top 

            testImage1.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }

        #endregion

        #region Move_Lock_To_Grid

        public void Bounce(Image anImage)
        {
            //Find the location of the object
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;

            // Set the move direction
            if (testFlag1X == true) leftMargin = leftMargin - 2;
            if (testFlag1X == false) leftMargin = leftMargin + 2;
            if (testFlag1Y == true) topMargin = topMargin - 2;
            if (testFlag1Y == false) topMargin = topMargin + 2;

            if (leftMargin <= 0) //Stop at left and bounce back
            {
                leftMargin = 0;
                testFlag1X = false;
            }

            if ((leftMargin + anImage.Width) > TestGrid.Width) //Stop at right side and bounce back
            {
                leftMargin = TestGrid.Width - anImage.Width;
                testFlag1X = true;
            }

            if ((topMargin + anImage.Height) > TestGrid.Height) //Stop at bottom and bounce back
            {
                topMargin = TestGrid.Height - anImage.Height;
                testFlag1Y = true;
            }

            if (topMargin <= 0) //Stop at top and bounce back
            {
                topMargin = 0;
                testFlag1Y = false;
            }

            anImage.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }

        #endregion

        #region Follow

        public void Follow(Image image1, Image image2)
        {
            double leftMargin = image1.Margin.Left;
            double topMargin = image1.Margin.Top;
            double rightMargin = image1.Margin.Right;
            double bottomMargin = image1.Margin.Bottom;

            double jelly2leftMargin = image2.Margin.Left;
            double jelly2topMargin = image2.Margin.Top;
            double jelly2rightMargin = image2.Margin.Right;
            double jelly2bottomMargin = image2.Margin.Bottom;

            if (jelly2leftMargin < leftMargin)
            {
                jelly2leftMargin += 1;
            }

            if (jelly2leftMargin > leftMargin)
            {
                jelly2leftMargin -= 1;
            }

            if (jelly2topMargin < topMargin) //Stop at bottom and bounce back
            {
                jelly2topMargin += 1;
            }

            if (jelly2topMargin > topMargin) //Stop at top and bounce back
            {
                jelly2topMargin -= 1;
            }
                   
            image2.Margin = new Thickness(jelly2leftMargin, jelly2topMargin, jelly2rightMargin, jelly2bottomMargin);

        }

        #endregion

        #region Runaway

        public void Runaway(Image image1, Image image2)
        {
            double leftMargin = image1.Margin.Left;
            double topMargin = image1.Margin.Top;
            double rightMargin = image1.Margin.Right;
            double bottomMargin = image1.Margin.Bottom;

            double jelly3leftMargin = image2.Margin.Left;
            double jelly3topMargin = image2.Margin.Top;
            double jelly3rightMargin = image2.Margin.Right;
            double jelly3bottomMargin = image2.Margin.Bottom;

            if (testFlag2X == true) jelly3leftMargin = jelly3leftMargin - .2;
            if (testFlag2X == false) jelly3leftMargin = jelly3leftMargin + .2;
            if (testFlag2Y == true) jelly3topMargin = jelly3topMargin - .2;
            if (testFlag2Y == false) jelly3topMargin = jelly3topMargin + .2;

            #region Lock to grid
            // Lock to grid
            if ((jelly3leftMargin + testImage3.Width) > TestGrid.Width) //Right side
            {
                jelly3leftMargin = TestGrid.Width - testImage3.Width;
                testFlag2X = true;
            }

            if (jelly3leftMargin <= 0) //Left side
            {
                jelly3leftMargin = 0;
                testFlag2X = false;
            }

            if ((jelly3topMargin + testImage3.Height) > TestGrid.Height) //Bottom
            {
                jelly3topMargin = TestGrid.Height - testImage3.Height;
                testFlag2Y = true;
            }

            if (jelly3topMargin <= 0) //Top 
            {
                jelly3topMargin = 0;
                testFlag2Y = false;
            }
            #endregion

            if (jelly3leftMargin + testImage3.Width > (leftMargin)) // Right - Runaway
            {
                jelly3leftMargin += .5;
            }

            if (jelly3leftMargin < leftMargin) //Left - Runaway
            {
                jelly3leftMargin -= .5;
            }

            if (jelly3topMargin < (topMargin)) // Top - Runaway
            {
                jelly3topMargin -= .5;
            }

            if (jelly3topMargin > (topMargin)) // Bottom - Runaway
            {
                jelly3topMargin += .5;
            }

            testImage3.Margin = new Thickness(jelly3leftMargin, jelly3topMargin, jelly3rightMargin, jelly3bottomMargin);

        }

        #endregion

        #region Collide

        // Add code here

        #endregion

        /// <summary>
        /// Resizes the grid to the screen size
        /// </summary>
        private void TestWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            TestGrid.Width = TestWindow.Width - 30;
            TestGrid.Height = TestWindow.Height - 50;
        }

        #region Key Pressed test

        private void TestWindow_KeyDown(object sender, KeyEventArgs e)
        {

            flagA = false;
            flagD = false;
            flagW = false;
            flagS = false;

            if (e.Key == Key.A) flagA = true;
            if (e.Key == Key.D) flagD = true;
            if (e.Key == Key.W) flagW = true;
            if (e.Key == Key.S) flagS = true;
        }

        #endregion
    }
}
