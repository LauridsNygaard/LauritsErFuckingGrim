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
using System.IO;

namespace MatHelp_V_0._1 {
    /// <summary>
    /// Interaction logic for Pythagoras_History.xaml
    /// </summary>
    public partial class Pythagoras_History : Window {

        StreamReader sr = new StreamReader("Pythagoras_History.txt");
        public Pythagoras_History() {
            InitializeComponent();
            dataReading();
        }
        private void dataReading() {
            string data = sr.ReadToEnd();
            History.Content = data;
            sr.Close();
        }

        private void Window_Closed(object sender, EventArgs e) {
            pythago pythagoras = new pythago();
            pythagoras.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            File.WriteAllText("Pythagoras_History.txt", string.Empty);
            History.Content = string.Empty;
        }
    }
}
