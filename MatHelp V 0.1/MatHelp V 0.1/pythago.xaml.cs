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
using System.Windows.Threading;
using System.IO;
using WpfMath;

namespace MatHelp_V_0._1 {
    /// <summary>
    /// Interaction logic for pythago.xaml
    /// </summary>
    public partial class pythago : Window {
        public pythago() {
            InitializeComponent();
            formel.Content = "a\u00B2+b\u00B2=c\u00B2";
            sw.AutoFlush = true;
        }

        StreamWriter sw = new StreamWriter("Pythagoras_History.txt", true);
        private void calculate_Button_Click(object sender, RoutedEventArgs e) {

            if (string.IsNullOrEmpty(A_Input.Text)) {
                double B = double.Parse(B_Input.Text);
                double C = double.Parse(C_Input.Text);

                answer.Content = "A = " + Math.Sqrt(Math.Pow(C, 2) - Math.Pow(B, 2));
                formel.Content = "\u221A(c\u00B2-b\u00B2)=a";
                
                sw.WriteLine(formel.Content + ", " + answer.Content);
            }
            if (string.IsNullOrEmpty(B_Input.Text)) {
                double A = double.Parse(A_Input.Text);
                double C = double.Parse(C_Input.Text);

                answer.Content = "B = " + Math.Sqrt(Math.Pow(C, 2) - Math.Pow(A, 2));

                formel.Content = "\u221A(c\u00B2-a\u00B2)=b";
                sw.WriteLine(formel.Content + ", " + answer.Content);
            }
            if (string.IsNullOrEmpty(C_Input.Text)) {
                double A = double.Parse(A_Input.Text);
                double B = double.Parse(B_Input.Text);

                answer.Content = "C = " + Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

                formel.Content = "\u221A(a\u00B2+b\u00B2)=c";
                sw.WriteLine(formel.Content + ", " + answer.Content);
            }            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            sw.Flush();
            sw.Close();
            Pythagoras_History pyhis = new Pythagoras_History();
            pyhis.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e) {
            
        }
        
    }
}
