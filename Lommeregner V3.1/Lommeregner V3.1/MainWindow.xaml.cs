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

namespace Lommeregner_V3._1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }

        private void Lommeregner_1_Button(object sender, RoutedEventArgs e) {
            Lommeregner1 lom1 = new Lommeregner1();
            lom1.Show();
        }

        private void Lommeregner_2_Button(object sender, RoutedEventArgs e) {
            Lommeregner2 lom2 = new Lommeregner2();
            lom2.Show();
        }
    }
}
