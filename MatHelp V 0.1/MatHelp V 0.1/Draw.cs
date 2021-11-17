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
    class Draw {
        public PointCollection points(double A, double B, double C, double a, double b, double c) {

            //Vi beregner de koordinater vi skal bruge
            double B_x = c;
            double C_x = b * Math.Cos(Math.PI / 180 * A);
            double C_y = b * Math.Sin(Math.PI / 180 * A);

            //Vi skriver nogle informationer ud i en txt fil, så vi kan hente den fra alle andre steder
            StreamWriter sw = new StreamWriter("Triangle_pic.txt", false);
            sw.WriteLine(B_x);
            sw.WriteLine(C_x);
            sw.WriteLine(C_y);
            sw.Flush();
            sw.Close();
            //for at sørge for vores tegnede trekant ikke går udover skærmen, finder vi vores største sidelængde og sørger for den på skærmen ikke er længere end 300 pixels
            //udfra den længste, bestemmer vi den pixel længden på de andre sider, vi bestemmer den 2 gange, fordi jeg skal bruge den 2 steder
            double scale;
            if (a > b && a > c)
                scale = 300 / a;
            else if (b > a && b > c)
                scale = 300 / b;
            else
                scale = 300 / c;

            //vi bestemmer koordinaterne i vores wpf for vores punkter, der skal bruges
            //og returnere points til en pointCollection og sender den tilbage med metoden
            Point PointA = new Point(450, 200);
            Point PointB = new Point(450 + B_x * scale, 200);
            Point PointC = new Point(450 + C_x * scale, 200 - C_y * scale);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(PointA);
            myPointCollection.Add(PointB);
            myPointCollection.Add(PointC);
            return myPointCollection;


            

        }
    }
}
