using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Include for the image and grid objects
using System.Windows;
using System.Windows.Controls;

namespace AlgorithmsStage3
{
    public static class Utils
    {
        #region Move using a key press
        /// <summary>
        /// Move an Image
        /// </summary>
        public static void Move(Image anImage, bool left, bool right, bool top, bool bottom, double speed)
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

        public static void Walls(Image anImage, Grid aGrid)
        {
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;

            if ((leftMargin + anImage.Width) > aGrid.Width) leftMargin = aGrid.Width - anImage.Width; //Right side
            if (leftMargin <= 0) leftMargin = 0; //Left side
            if ((topMargin + anImage.Height) > aGrid.Height) topMargin = aGrid.Height - anImage.Height; //Bottom
            if (topMargin <= 0) topMargin = 0; //Top 

            anImage.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }

        #endregion

        #region Move_Lock_To_Grid

        public static void Bounce(Image anImage, Grid aGrid, ref bool testFlagX, ref bool testFlagY)
        {
            //Find the location of the object
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;

            // Set the move direction
            if (testFlagX == true) leftMargin = leftMargin - 2;
            if (testFlagX == false) leftMargin = leftMargin + 2;
            if (testFlagY == true) topMargin = topMargin - 2;
            if (testFlagY == false) topMargin = topMargin + 2;

            if (leftMargin <= 0) //Stop at left and bounce back
            {
                leftMargin = 0;
                testFlagX = false;
            }

            if ((leftMargin + anImage.Width) > aGrid.Width) //Stop at right side and bounce back
            {
                leftMargin = aGrid.Width - anImage.Width;
                testFlagX = true;
            }

            if ((topMargin + anImage.Height) > aGrid.Height) //Stop at bottom and bounce back
            {
                topMargin = aGrid.Height - anImage.Height;
                testFlagY = true;
            }

            if (topMargin <= 0) //Stop at top and bounce back
            {
                topMargin = 0;
                testFlagY = false;
            }

            anImage.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }

        #endregion

        #region Follow

        public static void Follow(Image image1, Image image2)
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

        public static void Runaway(Image image1, Image image2)
        {

        }

        #endregion

        #region Collide

        // Add code here

        #endregion



    }
}
