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

namespace Lommeregner_V2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }

        private void Adittion_ButtonClicked(object sender, RoutedEventArgs e) {
            CalculateWithOperators(0);
        }

        private void Subtraction_ButtonClick(object sender, RoutedEventArgs e) {
            CalculateWithOperators(1);

        }

        private void Multiplikation_ButtonClick(object sender, RoutedEventArgs e) {
            CalculateWithOperators(2);

        }

        private void Division_ButtonClick(object sender, RoutedEventArgs e) {
            CalculateWithOperators(3);

        }

        private void CalculateWithOperators(int Operator) {

            int firstInput = Convert.ToInt32(firstInput_TextBox.Text);
            int secondInput = Convert.ToInt32(secondInput_TextBox.Text);

            int result = 0;


            switch (Operator) {
                case 0:
                    result = firstInput + secondInput;
                    break;
                case 1:
                    result = firstInput - secondInput;
                    break;
                case 2:
                    result = firstInput * secondInput;
                    break;
                case 3:
                    result = firstInput / secondInput;
                    break;

            }

            result_TextBox.Text = result + "";
        }
    }
}
