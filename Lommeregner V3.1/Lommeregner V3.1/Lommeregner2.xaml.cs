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
using System.Windows.Shapes;

namespace Lommeregner_V3._1 {
    /// <summary>
    /// Interaction logic for Lommeregner2.xaml
    /// </summary>
    public partial class Lommeregner2 : Window {
        public Lommeregner2() {
            InitializeComponent();

        }

        private void Button_1_Click(object sender, RoutedEventArgs e) {
            InputDisplay(1);
        }

        private void Button_2_Click(object sender, RoutedEventArgs e) {
            InputDisplay(2);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e) {
            InputDisplay(3);
        }

        private void Button_4_Click(object sender, RoutedEventArgs e) {
            InputDisplay(4);
        }

        private void Button_5_Click(object sender, RoutedEventArgs e) {
            InputDisplay(5);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e) {
            InputDisplay(6);
        }

        private void Button_7_Click(object sender, RoutedEventArgs e) {
            InputDisplay(7);
        }

        private void Button_8_Click(object sender, RoutedEventArgs e) {
            InputDisplay(8);
        }

        private void Button_9_Click(object sender, RoutedEventArgs e) {
            InputDisplay(9);
        }

        private void Button_0_Click(object sender, RoutedEventArgs e) {
            InputDisplay(0);
        }

        private void Adittion_ButtonClicked(object sender, RoutedEventArgs e) {

        }

        private void Subtraction_ButtonClick(object sender, RoutedEventArgs e) {

        }

        private void Multiplikation_ButtonClick(object sender, RoutedEventArgs e) {

        }

        private void Division_ButtonClick(object sender, RoutedEventArgs e) {

        }

        private void Start() {
        }

        private void InputDisplay(int num) {

            /*string input = "";
            switch (num) {
                case 0:
                   Input = Input + "0";
                    break;
                case 1:
                    Input = Input + "1";
                    break;
                case 2:
                    Input = Input + "2";
                    break;
                case 3:
                    Input = Input + "3";
                    break;
                case 4:
                    Input = Input + "4";
                    break;
                case 5:
                    Input = Input + "5";
                    break;
                case 6:
                    Input = Input + "6";
                    break;
                case 7:
                    Input = Input + "7";
                    break;
                case 8:
                    Input = Input + "8";
                    break;
                case 9:
                    Input = Input + "9";
                    break;

            }

            firstInput_TextBox.Text = Input;
            */
        }
    }
}
