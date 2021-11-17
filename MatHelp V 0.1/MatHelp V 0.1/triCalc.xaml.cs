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
    /// Interaction logic for triCalc.xaml
    /// </summary>
    public partial class triCalc : Window {

        public triCalc() {
            InitializeComponent();
            
        }
        //Vi deffinere de doubles vi skal bruge i programmet
        double a, b, c, A, B, C, B_x, C_x, C_y;

        //Vi instansiere 2 nye objekter af mine klasser
        TriCalcMethods calc = new TriCalcMethods();
        Draw draw = new Draw();



        private void Button_Click(object sender, RoutedEventArgs e) {
            
            // Vi kalder her vores metode, som vi bruger til at udregne alle vores værdier, vi har i vores trekant
            calc.triCalc(a_Input.Text, b_Input.Text, c_Input.Text, A_Input.Text, B_Input.Text, C_Input.Text);

            //Her tager vi alle vores værdier fra vores trekant, a, b, c, A, B og C, fra en txt fil og putter det ind i en liste, og tager disse værdier fra en liste og putter dem i double variabler
            List<string> values = new List<string>();
            foreach (string line in File.ReadLines("TriAnswer.txt")) {
                values.Add(line);
            }
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            A = double.Parse(values[3]);
            B = double.Parse(values[4]);
            C = double.Parse(values[5]);

            //Vi udfylder vores svar label og enabler more info knappen
            answer_lbl.Content = "a: " + Math.Round(a, 5, MidpointRounding.AwayFromZero) + "\nb: " + Math.Round(b, 5, MidpointRounding.AwayFromZero) + "\nc: " + Math.Round(c, 5, MidpointRounding.AwayFromZero) + "\nA: " + Math.Round(A, 5, MidpointRounding.AwayFromZero) + "\nB: " + Math.Round(B, 5, MidpointRounding.AwayFromZero) + "\nC: " + Math.Round(C, 5, MidpointRounding.AwayFromZero);

            moreInfo.IsEnabled = true;

            //Her kalder vi en metode, vi bruger til at finde koordinaterne, vi bruger til at tegne trekanten, vi har regnet på
            //Vi laver trekants punkterne til vores pointColletion vi får returnere fra metoden
            triangle.Points = draw.points(A, B, C, a, b, c);

            //Her gør vi som før, og henter du bare koordinaterne fra en txt fil og putter dem ind i double variabler
            //egentligt ville jeg have puttet dem ind i den anden txt fil, men det fungerede ikke, derfor ligger de nu i en anden txt fil og bliver hentet derfra
            //Derfor bliver de bare hentet fra en ny fil
            List<string> points = new List<string>();
            foreach (string line in File.ReadLines("Triangle_pic.txt")) {
                points.Add(line);
            }

            B_x = double.Parse(points[0]);
            C_x = double.Parse(points[1]);
            C_y = double.Parse(points[2]);

            //for at sørge for vores tegnede trekant ikke går udover skærmen, finder vi vores største sidelængde og sørger for den på skærmen ikke er længere end 300 pixels
            //udfra den længste, bestemmer vi den pixel længden på de andre sider, vi bestemmer den 2 gange, fordi jeg skal bruge den 2 steder
            double scale;
            if (a > b && a > c)
                scale = 300 / a;
            else if (b > a && b > c)
                scale = 300 / b;
            else
                scale = 300 / c;


            //Jeg vil nu placere mine bogstav labels, de korrekte steder over for de korrekte punkter
            //for at placere dem, skal vi bestemme deres margins, dette gøres ved at lave et objekt, der hedder Thickness, kan ikke fortælle hvorfor den hedder det, men efter mange google søgninger, er det sådan man laver dem
            //Til sidst laves marginsne, ved labels, så de er placeret korrekt
            Thickness mB = B_pic.Margin;
            mB.Left = 450 + (B_x * scale);
            B_pic.Margin = mB;

            Thickness mC = C_pic.Margin;
            mC.Left = 440 + C_x * scale;
            mC.Top = 160 - (C_y * scale);
            C_pic.Margin = mC;



        }

        private void moreInfo_Click(object sender, RoutedEventArgs e) {

            //her kalder vi vores metode, der giver os en mere detaljeret visning af resultaterne
            calc.detailedCalc(a, b, c, A, B, C);
            
        }


    }

    
}
