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
using System.Speech.Synthesis;

namespace fortunePredictor
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random randy = new Random();

            SpeechSynthesizer talk = new SpeechSynthesizer();

            string[] timeArray = new string[9] { "thirty minutes", "an hour", "eight hours", "twelve hours", "a day", "a week", "a month", "a year", "a decade" };
            string[] aspectArray = new string[5] { "finances", "love life", "career prospects", "travel plans", "relationships" };
            string[] effectArray = new string[6] { "fall apart", "exceed your expectation", "become awkward in an unexpected way", "become manageable", "become spectacular", "come to a positive outcome" };
            string[] personaArray = new string[9] { "man", "boy", "woman", "girl", "dog", "bird", "hedgehog", "singer", "relative" };
            string[] featureArray = new string[6] { "pink hair", "a broken golden chain", "scary eyes", "long blond nose hair", "very red lips", "silver feet" };
            string[] consequenceArray = new string[6] { "avoid looking at directly", "sing a sad song with", "stop and talk to", "dance with", "tell a secret", "buy a coffee" };

            textBlock.Text = $"Over a period of {timeArray[randy.Next(0, timeArray.Length)]} your {aspectArray[randy.Next(0, aspectArray.Length)]} will {effectArray[randy.Next(0, effectArray.Length)]}. " +
                $"This will come to pass after you meet a {personaArray[randy.Next(0, personaArray.Length)]} with {featureArray[randy.Next(0, featureArray.Length)]} who for " +
                $"some reason you find yourself obliged to {consequenceArray[randy.Next(0, consequenceArray.Length)]}.";

            talk.Speak(textBlock.Text);
        }
    }
}
