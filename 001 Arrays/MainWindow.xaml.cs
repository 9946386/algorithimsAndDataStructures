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
        #region Example 1
        // Example 1
        int[] Numbers1;
        #endregion

        #region Example 2
        // Example 2
        int[] Numbers2 = new int[6];
        #endregion

        #region Example 3
        // Example 3
        int[] Numbers3 = new int[6] { 7, 8, 9, 10, 11, 12 };
        #endregion

        #region Example 4
        // Example 4
        int[] Numbers4 = { 13, 14, 15, 16, 17, 18 };
        #endregion

        #region Multidimensional Arrays 2D

        // Example 1
        int[ , ] Numbers5 = new int[4, 2];

        // Example 2
        int[,] Numbers7;

        // Example 3
        int[,] Numbers8 = new int[4, 2];

        // Example 4
        int[,] Numbers9 = new int[,] { { 1, 2 }, { 11, 12 }, { 21, 22 }, { 31, 32 } };

        // Example 5
        int[,] Numbers10 = new int[4,2] { { 1, 2 }, { 11, 12 }, { 21, 22 }, { 31, 32 } };

        // Example 6
        int[,] Numbers11 = { { 1, 2 }, { 11, 12 }, { 21, 22 }, { 31, 32 } };

        #endregion

        #region Multidimensional Arrays 3D
        // int[ , , ] Numbers6 = new int[4, 2, 3];
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            #region Example 1
            // Example 1
            Numbers1 = new int[6];
            #endregion

            #region Multidimensional Arrays 2D

            // Example 2
            Numbers7 = new int[4, 2];

            #endregion
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            #region Example 1
            // Example 1
            Numbers1[0] = 20;
            Numbers1[1] = 100;
            Numbers1[2] = 999;
            Numbers1[3] = 10;
            Numbers1[4] = 4;
            Numbers1[5] = 3333;

            int Temp1 = Numbers1.Length;
            int Temp2 = Numbers1[3];
            #endregion

            #region Example 2
            // Example 2
            Numbers2[0] = 1;
            Numbers2[1] = 2;
            Numbers2[2] = 3;
            Numbers2[3] = 4;
            Numbers2[4] = 5;
            Numbers2[5] = 6;
            #endregion

            #region Exmple 5
            // Example 5
            var Numbers5 = new[] { 19, 20, 21, 22, 23, 24 };
            #endregion

            #region Example 1
            // Processing an Arrays
            textBlock1.Text = "Array 1 : ";
            for (int loop = 0; loop < Numbers1.Length; loop++) textBlock1.Text = textBlock1.Text + Numbers1[loop].ToString() + " ";
            textBlock1.Text = textBlock1.Text + "\n";
            #endregion

            #region Example 2
            textBlock1.Text = textBlock1.Text + "\nArray 2 : ";
            for (int loop = 0; loop < Numbers2.Length; loop++) textBlock1.Text = textBlock1.Text + Numbers2[loop].ToString() + " ";
            textBlock1.Text = textBlock1.Text + "\n";
            #endregion

            #region Example 3
            textBlock1.Text = textBlock1.Text + "\nArray 3 : ";
            for (int loop = 0; loop < Numbers3.Length; loop++) textBlock1.Text = textBlock1.Text + Numbers3[loop].ToString() + " ";
            textBlock1.Text = textBlock1.Text + "\n";
            #endregion

            #region Example 4            
            textBlock1.Text = textBlock1.Text + "\nArray 4 : ";
            for (int loop = 0; loop < Numbers4.Length; loop++) textBlock1.Text = textBlock1.Text + Numbers4[loop].ToString() + " ";
            textBlock1.Text = textBlock1.Text + "\n";
            #endregion

            #region Example 5
            textBlock1.Text = textBlock1.Text + "\nArray 5 : ";
            for (int loop = 0; loop < Numbers5.Length; loop++) textBlock1.Text = textBlock1.Text + Numbers5[loop].ToString() + " ";
            textBlock1.Text = textBlock1.Text + "\n";
            #endregion

            #region foreach statement

            textBlock1.Text = textBlock1.Text + "\ntestArray : ";
            String[] testArray = { "Tom", "Tina", "Sue" };

            foreach (String test in testArray)
            {
                textBlock1.Text = textBlock1.Text + test + " ";
            }


            textBlock1.Text = textBlock1.Text + "\nnumArray : ";
            int[] numArray = { 5, 5, 5, 5, 5 };

            foreach (int number in numArray)
            {
                textBlock1.Text = textBlock1.Text + number.ToString() + " ";
            }
            textBlock1.Text = textBlock1.Text + "\n";

            #endregion

            #region Class Methods
            // Array Methods

            textBlock1.Text = textBlock1.Text + "\nstrArray : ";

            String[] strArray = { "Blue", "Red", "Green", "Gray", "Silver", "Gold", "Pink" };

            foreach (String str in strArray) textBlock1.Text = textBlock1.Text + str + " ";

            textBlock1.Text = textBlock1.Text + "\nSorted : ";
            Array.Sort(strArray);
            foreach (String str in strArray) textBlock1.Text = textBlock1.Text + str + " ";

            textBlock1.Text = textBlock1.Text + "\nReversed : ";
            Array.Reverse(strArray);
            foreach (String str in strArray) textBlock1.Text = textBlock1.Text + str + " ";

            textBlock1.Text = textBlock1.Text + "\n";

            int[] lotto = { 57, 22, 1, 17, 45, 48 };

            textBlock1.Text = textBlock1.Text + "\nlotto : ";
            foreach (int lot in lotto) textBlock1.Text = textBlock1.Text + lot.ToString() + " ";

            textBlock1.Text = textBlock1.Text + "\nSorted : ";
            Array.Sort(lotto);
            foreach (int lot in lotto) textBlock1.Text = textBlock1.Text + lot.ToString() + " ";
            #endregion

            #region Passing Arrays to Methods

            int[] passArray = new int[3] { 1, 1, 1 };

            testMethod(passArray);

            int testingArray = passArray[1];

            // To allocate a whole array use the ref
            //testMethodByRef(ref passArray);
            //int testingArrayByRef1 = passArray[0];
            //int testingArrayByRef2 = passArray[1];
            //int testingArrayByRef3 = passArray[1];

            #endregion

            #region Multidimensional Arrays 2D

            // Example 2
            Numbers7[0,0] = 1;
            Numbers7[0,1] = 2;
           
            Numbers7[1,0] = 11;
            Numbers7[1,1] = 12;
                       
            Numbers7[2,0] = 21;
            Numbers7[2,1] = 22;
            
            Numbers7[3,0] = 31;
            Numbers7[3,1] = 32;


            // Example 3
            Numbers8[0, 0] = 1;
            Numbers8[0, 1] = 2;

            Numbers8[1, 0] = 11;
            Numbers8[1, 1] = 12;

            Numbers8[2, 0] = 21;
            Numbers8[2, 1] = 22;

            Numbers8[3, 0] = 31;
            Numbers8[3, 1] = 32;

            // Example 7
            var Numbers12 = new[,] { { 1, 2 }, { 11, 12 }, { 21, 22 }, { 31, 32 } };



            // int[,] Numbers9 = new int[,] { { 1, 2 }, 
            //                                { 11, 12 }, 
            //                                { 21, 22 }, 
            //                                { 31, 32 } };

            for (int row = 0; row < 4; row++)
            {
                for (int columb = 0; columb < 2; columb++)
                {
                    textBlock2.Text = textBlock2.Text + "Row " + row.ToString() + " Columb " + columb.ToString() + " = " + Numbers9[row, columb] + "\n";
                }

                textBlock2.Text = textBlock2.Text + "\n";
            }

            textBlock2.Text = textBlock2.Text + "\n";

 
            foreach (int number in Numbers9)
            {
                textBlock2.Text = textBlock2.Text + number.ToString() + " ";
            }

            textBlock2.Text = textBlock2.Text + "\n";

            int lengthTest = Numbers9.Length;

            #endregion

            #region Multidimensional Arrays Jagged 2D

            int[][] NumbersJagged = new int[4][];

            NumbersJagged[0] = new int[2];
            NumbersJagged[1] = new int[3];
            NumbersJagged[2] = new int[4];
            NumbersJagged[3] = new int[2];

            NumbersJagged[0][0] = 1;
            NumbersJagged[0][1] = 2;

            NumbersJagged[1][0] = 11;
            NumbersJagged[1][1] = 12;
            NumbersJagged[1][2] = 13;

            NumbersJagged[2][0] = 21;
            NumbersJagged[2][1] = 22;
            NumbersJagged[2][2] = 23;
            NumbersJagged[2][3] = 24;

            NumbersJagged[3][0] = 31;
            NumbersJagged[3][1] = 32;


            //int[][] NumbersJagged = new int[4][];

            //NumbersJagged[0] = new int[] { 1, 2 };
            //NumbersJagged[1] = new int[] { 11, 12, 13 };
            //NumbersJagged[2] = new int[] { 21, 22, 23, 24 };
            //NumbersJagged[3] = new int[] { 31, 32 };


            //int[][] NumbersJagged = new int[][]
            //{
            //    new int[] { 1, 2 },
            //    new int[] { 11, 12, 13 },
            //    new int[] { 21, 22, 23, 24 },
            //    new int[] { 31, 32 }
            //};


            //int[][] NumbersJagged =
            //{
            //    new int[] { 1, 2 },
            //    new int[] { 11, 12, 13 },
            //    new int[] { 21, 22, 23, 24 },
            //    new int[] { 31, 32 }
            //};

            //// Assign 77 to the second element ([1]) of the first array ([0]):
            //NumbersJagged[0][1] = 77;

            //// Assign 88 to the second element ([1]) of the third array ([2]):
            //NumbersJagged[2][1] = 88;

            // Display the array elements.
            for (int row = 0; row < NumbersJagged.Length; row++)
            {
                for (int columb = 0; columb < NumbersJagged[row].Length; columb++)
                {
                    textBlock3.Text = textBlock3.Text + "Row " + row.ToString() + " Columb " + columb.ToString() + " = " + NumbersJagged[row][columb] + "\n";
                }
                textBlock3.Text = textBlock3.Text + "\n";
            }

            // int temp;
            //temp = NumbersJagged.Length;
            //temp = NumbersJagged[0].Length;
            //temp = NumbersJagged[1].Length;
            //temp = NumbersJagged[2].Length;
            //temp = NumbersJagged[3].Length;

            #endregion

            #region Multidimensional Arrays 3D


            //int[,,] Array3D = new int[4, 2, 3] {   { { 1,  101, 1001 }, { 2, 102, 1002 } },
            //                                       { { 11, 111, 1111 }, { 12, 112, 1112 } },
            //                                       { { 21, 121, 1121 }, { 22, 122, 1122 } },
            //                                       { { 31, 131, 1131 }, { 32, 132, 1132 } }  };


            //for (int row = 0; row < 4; row++)
            //{
            //    for (int columb = 0; columb < 2; columb++)
            //    {
            //        for (int index = 0; index < 3; index++)
            //        {
            //            textBlock4.Text = textBlock4.Text + "Row " + row.ToString() + " Columb " +
            //                                    columb.ToString() + " index " + index.ToString() + " = " + Array3D[row, columb, index] + "\n";

            //        }
            //    }
            //    textBlock3.Text = textBlock3.Text + "\n";
            //}

            //int temp = Array3D.Length;

            #endregion

        }

        #region Passing Arrays to Methods

        public void testMethod(int[] inputArray)
        {
            inputArray[0] = 10;
            inputArray[1] = 10;
            inputArray[2] = 10;
        }

        // To allocate a whole array the ref needs to be used
        //public void testMethodByRef(ref int[] inputArray)
        //{
        //    int[] passArray1 = new int[3] { 3, 3, 3 };

        //    inputArray = passArray1;
        //}
        #endregion


    }
}
