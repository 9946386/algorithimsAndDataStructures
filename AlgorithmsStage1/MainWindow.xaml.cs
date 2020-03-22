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

namespace AlgorithmsStage1
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

        bool testFlag3X = true;
        bool testFlag3Y = true;
        #endregion

        #region Key Pressed Flags
        bool flagA = false;
        bool flagD = false;
        bool flagW = false;
        bool flagS = false;
        #endregion

        #region Object location
        double leftMargin;
        double topMargin;
        double rightMargin;
        double bottomMargin;

        double jelly2leftMargin;
        double jelly2topMargin;
        double jelly2rightMargin;
        double jelly2bottomMargin;

        double jelly3leftMargin;
        double jelly3topMargin;
        double jelly3rightMargin;
        double jelly3bottomMargin;
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
            //Find the location of the object
            leftMargin = testImage1.Margin.Left;
            topMargin = testImage1.Margin.Top;
            rightMargin = testImage1.Margin.Right;
            bottomMargin = testImage1.Margin.Bottom;

            //Moving the location
            if (flagA == true)  leftMargin = leftMargin - 5.00;
            if (flagD == true)  leftMargin = leftMargin + 5.0;
            if (flagW == true)  topMargin = topMargin - 5.00;
            if (flagS == true)  topMargin = topMargin + 5.00;

            //Reset the location of the object
            testImage1.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);

            #endregion

            #region Lock_To_Grid
            //leftMargin = testImage1.Margin.Left;
            //topMargin = testImage1.Margin.Top;
            //rightMargin = testImage1.Margin.Right;
            //bottomMargin = testImage1.Margin.Bottom;

            //testImage1.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);

            //if ((leftMargin + testImage1.Width) > TestGrid.Width) leftMargin = TestGrid.Width - testImage1.Width; //Right side
            //if (leftMargin <= 0) leftMargin = 0; //Left side
            //if ((topMargin + testImage1.Height) > TestGrid.Height) topMargin = TestGrid.Height - testImage1.Height; //Bottom
            //if (topMargin <= 0) topMargin = 0; //Top 

            //testImage1.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);

            #endregion

            #region Move_Lock_To_Grid

            ////Find the location of the object
            //leftMargin = testImage1.Margin.Left;
            //topMargin = testImage1.Margin.Top;
            //rightMargin = testImage1.Margin.Right;
            //bottomMargin = testImage1.Margin.Bottom;

            //// Set the move direction
            //if (testFlag1X == true) leftMargin = leftMargin - 2;
            //if (testFlag1X == false) leftMargin = leftMargin + 2;
            //if (testFlag1Y == true) topMargin = topMargin - 2;
            //if (testFlag1Y == false) topMargin = topMargin + 2;

            //if (leftMargin <= 0) //Stop at left and bounce back
            //{
            //    leftMargin = 0;
            //    testFlag1X = false;
            //}

            //if ((leftMargin + testImage1.Width) > TestGrid.Width) //Stop at right side and bounce back
            //{
            //    leftMargin = TestGrid.Width - testImage1.Width;
            //    testFlag1X = true;
            //}

            //if ((topMargin + testImage1.Height) > TestGrid.Height) //Stop at bottom and bounce back
            //{
            //    topMargin = TestGrid.Height - testImage1.Height;
            //    testFlag1Y = true;                
            //}

            //if (topMargin <= 0) //Stop at top and bounce back
            //{
            //    topMargin = 0;
            //    testFlag1Y = false;                
            //}

            #endregion

            #region Follow

            #region Jelly1

            //Find the location of the object
            leftMargin = testImage1.Margin.Left;
            topMargin = testImage1.Margin.Top;
            rightMargin = testImage1.Margin.Right;
            bottomMargin = testImage1.Margin.Bottom;

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

            if ((leftMargin + testImage1.Width) > TestGrid.Width) //Stop at right side and bounce back
            {
                leftMargin = TestGrid.Width - testImage1.Width;
                testFlag1X = true;
            }

            if ((topMargin + testImage1.Height) > TestGrid.Height) //Stop at bottom and bounce back
            {
                topMargin = TestGrid.Height - testImage1.Height;
                testFlag1Y = true;
            }

            if (topMargin <= 0) //Stop at top and bounce back
            {
                topMargin = 0;
                testFlag1Y = false;
            }

            #endregion

            #region Jelly2

            //Find the location of the second object
            jelly2leftMargin = testImage2.Margin.Left;
            jelly2topMargin = testImage2.Margin.Top;
            jelly2rightMargin = testImage2.Margin.Right;
            jelly2bottomMargin = testImage2.Margin.Bottom;

            //if (testFlag2X == true) jelly2leftMargin = jelly2leftMargin - 3;
            //if (testFlag2X == false) jelly2leftMargin = jelly2leftMargin + 3;
            //if (testFlag2Y == true) jelly2topMargin = jelly2topMargin - 3;
            //if (testFlag2Y == false) jelly2topMargin = jelly2topMargin + 3;

            //if (jelly2leftMargin <= 0) //Stop at left and bounce back
            //{
            //    jelly2leftMargin = 0;
            //    testFlag2X = false;
            //}

            //if ((jelly2leftMargin + testImage2.Width) > TestGrid.Width) //Stop at right side and bounce back
            //{
            //    jelly2leftMargin = TestGrid.Width - testImage2.Width;
            //    testFlag2X = true;
            //}

            //if ((jelly2topMargin + testImage2.Height) > TestGrid.Height) //Stop at bottom and bounce back
            //{
            //    jelly2topMargin = TestGrid.Height - testImage2.Height;
            //    testFlag2Y = true;
            //}

            //if (jelly2topMargin <= 0) //Stop at top and bounce back
            //{
            //    jelly2topMargin = 0;
            //    testFlag2Y = false;
            //}

            //When the object is left of the target move right
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
            
            #endregion

            testImage1.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
            testImage2.Margin = new Thickness(jelly2leftMargin, jelly2topMargin, jelly2rightMargin, jelly2bottomMargin);
            testImage3.Margin = new Thickness(jelly3leftMargin, jelly3topMargin, jelly3rightMargin, jelly3bottomMargin);

            #endregion

            #region Runaway

            //Find the location of the runaway object
            jelly3leftMargin = testImage3.Margin.Left;
            jelly3topMargin = testImage3.Margin.Top;
            jelly3rightMargin = testImage3.Margin.Right;
            jelly3bottomMargin = testImage3.Margin.Bottom;

            if (testFlag3X == true) jelly3leftMargin = jelly3leftMargin - 2;
            if (testFlag3X == false) jelly3leftMargin = jelly3leftMargin + 2;
            if (testFlag3Y == true) jelly3topMargin = jelly3topMargin - 2;
            if (testFlag3Y == false) jelly3topMargin = jelly3topMargin + 2;

            #region Lock to grid
            // Lock to grid
            if ((jelly3leftMargin + testImage3.Width) > TestGrid.Width) //Right side
            {
                jelly3leftMargin = TestGrid.Width - testImage3.Width;
                testFlag3X = true; 
            }

            if (jelly3leftMargin <= 0) //Left side
            {
                jelly3leftMargin = 0;
                testFlag3X = false;
            }

            if ((jelly3topMargin + testImage3.Height) > TestGrid.Height) //Bottom
            {
                jelly3topMargin = TestGrid.Height - testImage3.Height;
                testFlag3Y = true;
            }

            if (jelly3topMargin <= 0) //Top 
            {
                jelly3topMargin = 0;
                testFlag3Y = false;
            }
            #endregion

            //Run away
            if (jelly3leftMargin < (leftMargin)) //Left - Runaway
            {
                jelly3leftMargin += 2;
            }

            if (jelly3leftMargin + testImage3.Width > (rightMargin)) // Right - Runaway
            {
                jelly3leftMargin -= 2;
            }

            if (jelly3topMargin > (topMargin)) // Top - Runaway
            {
                jelly3topMargin += 2;
            }

            if (jelly3topMargin + testImage3.Width < (bottomMargin)) // Bottom - Runaway
            {
                jelly3topMargin -= 2;               
            }            

            testImage3.Margin = new Thickness(jelly3leftMargin, jelly3topMargin, jelly3rightMargin, jelly3bottomMargin);


            #endregion

            #region Collide

            // Add code here

            #endregion

            #region Random Number

            // Add code here

            #endregion

        }


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
