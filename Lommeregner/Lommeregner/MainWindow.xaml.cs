using System;
using System.Windows;
using System.Diagnostics;

namespace Lommeregner {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Debug.WriteLine("HEJ1");
            
        }

        private void Adittion_buttonClicked(object sender, RoutedEventArgs e) {
            Debug.WriteLine("HEJ");
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Console.WriteLine("YEET");
        }
    }
}
