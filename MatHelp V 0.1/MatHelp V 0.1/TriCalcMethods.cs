using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MatHelp_V_0._1 {
    class TriCalcMethods {

        //Her har vi vores metode, der regner sider og vinkler
        public void triCalc(string a, string b, string c, string A, string B, string C) {
            //vi instansiere en ny streamwriter
            StreamWriter sw = new StreamWriter("TriAnswer.txt", false);

            //Her kører vi en do while sætning, der kører så længe nogle af værdierne er ukendte, så den fortsætter med at køre til vi kender alle sider og vinkler i trekanten
            do {
                //Her ned af, har jeg en masse if sætninger, der regner a, b, c, A, B og C, på flere forskellige måder, så uanset hvilke 3 værdier vi kender, så kan den regne værdier
                //fungere specielt godt fordi vi kører den som et loop indtil det hele er kendte
                if (string.IsNullOrEmpty(a)) {
                    if (A != "" && b != "" && B != "") {
                        a = "" + (Math.Sin(Math.PI / 180 * double.Parse(A)) * double.Parse(b)) / Math.Sin(Math.PI / 180 * double.Parse(B));
                    }
                    if (A != "" && c != "" & C != "") {
                        a = "" + (Math.Sin(Math.PI / 180 * double.Parse(A)) * double.Parse(c)) / Math.Sin(Math.PI / 180 * double.Parse(C));
                    }
                    if (b != "" && c != "" && A != "") {
                        a = "" + Math.Sqrt(Math.Pow(double.Parse(b), 2) + Math.Pow(double.Parse(c), 2) - 2 * double.Parse(b) * double.Parse(c) * Math.Cos(Math.PI / 180 * double.Parse(A)));
                    }
                }
                if (string.IsNullOrEmpty(A)) {
                    if (B != "" && C != "") {
                        A = "" + (180 - double.Parse(B) - double.Parse(C));
                    }
                    if (a != "" && b != "" && c != "") {
                        A = "" + (180 / Math.PI) * Math.Acos((Math.Pow(double.Parse(b), 2) + Math.Pow(double.Parse(c), 2) - Math.Pow(double.Parse(a), 2)) / (2 * double.Parse(b) * double.Parse(c)));
                    }
                    if (a != "" && b != "" && B != "") {
                        A = "" + (180 / Math.PI) * Math.Asin((double.Parse(a) * Math.Sin(Math.PI / 180 * double.Parse(B))) / double.Parse(b));
                    }
                    if (a != "" && c != "" && C != "") {
                        A = "" + (180 / Math.PI) * Math.Asin((double.Parse(a) * Math.Sin(Math.PI / 180 * double.Parse(C))) / double.Parse(c));
                    }
                }
                if (string.IsNullOrEmpty(b)) {
                    if (B != "" && a != "" && A != "") {
                        b = "" + (Math.Sin(Math.PI / 180 * double.Parse(B)) * double.Parse(a)) / Math.Sin(Math.PI / 180 * double.Parse(A));
                    }
                    if (B != "" && c != "" && C != "") {
                        b = "" + (Math.Sin(Math.PI / 180 * double.Parse(B)) * double.Parse(c)) / Math.Sin(Math.PI / 180 * double.Parse(C));
                    }
                    if (a != "" && c != "" && B != "") {
                        b = "" + Math.Sqrt(Math.Pow(double.Parse(a), 2) + Math.Pow(double.Parse(c), 2) - 2 * double.Parse(a) * double.Parse(c) * Math.Cos(Math.PI / 180 * double.Parse(B)));
                    }
                }
                if (string.IsNullOrEmpty(B)) {
                    if (A != "" && C != "") {
                        B = "" + (180 - double.Parse(A) - double.Parse(C));
                    }
                    if (a != "" && b != "" && c != "") {
                        B = "" + (180 / Math.PI) * Math.Acos((Math.Pow(double.Parse(a), 2) + Math.Pow(double.Parse(c), 2) - Math.Pow(double.Parse(b), 2)) / (2 * double.Parse(a) * double.Parse(c)));
                    }
                    if (b != "" && a != "" && A != "") {
                        B = "" + (180 / Math.PI) * Math.Asin((double.Parse(b) * Math.Sin(Math.PI / 180 * double.Parse(A))) / double.Parse(a));
                    }
                    if (b != "" && c != "" && C != "") {
                        B = "" + (180 / Math.PI) * Math.Asin((double.Parse(b) * Math.Sin(Math.PI / 180 * double.Parse(C))) / double.Parse(c));
                    }
                }
                if (string.IsNullOrEmpty(c)) {
                    if (C != "" && a != "" && A != "") {
                        c = "" + (Math.Sin( Math.PI / 180 * double.Parse(C)) * double.Parse(a)) / Math.Sin(Math.PI / 180 * double.Parse(A));
                    }
                    if (C != "" && b != "" && B != "") {
                        c = "" + (Math.Sin(Math.PI / 180 * double.Parse(C)) * double.Parse(b)) / Math.Sin(Math.PI / 180 * double.Parse(B));
                    }
                    if (a != "" && b != "" && C != "") {
                        c = "" + Math.Sqrt((Math.Pow(double.Parse(a), 2) + Math.Pow(double.Parse(b), 2)) - 2 * (double.Parse(a) * double.Parse(b) * Math.Cos(Math.PI / 180 * double.Parse(C))));
                        //c=\sqrt(a^2+b^2-2*a*b*Cos(C))
                    }
                }
                if (string.IsNullOrEmpty(C)) {
                    if (A != "" && B != "") {
                        C = "" + (180 - double.Parse(A) - double.Parse(B));
                    }
                    if (a != "" && b != "" && c != "") {
                        C = "" + (180 / Math.PI) * Math.Acos((Math.Pow(double.Parse(a), 2) + Math.Pow(double.Parse(b), 2) - Math.Pow(double.Parse(c), 2)) / (2 * double.Parse(a) * double.Parse(b)));
                    }
                    if (c != "" && a != "" && A != "") {
                        C = "" + (180 / Math.PI) * Math.Asin((double.Parse(c) * Math.Sin(Math.PI / 180 * double.Parse(A))) / double.Parse(a));
                    }
                    if (c != "" && b != "" && B != "") {
                        C = "" + (180 / Math.PI) * Math.Asin((double.Parse(c) * Math.Sin(Math.PI / 180 * double.Parse(B))) / double.Parse(b));
                    }
                }
                //Her sørger vi for at køre den indtil vi kender alle variablers værdier
            } while (a == "" || b == "" || c == "" || A == "" || B == "" || C == "");

            //vi skriver alle informationer ind i en txt fil og flusher det
            sw.WriteLine(a);
            sw.WriteLine(b);
            sw.WriteLine(c);
            sw.WriteLine(A);
            sw.WriteLine(B);
            sw.WriteLine(C);
            sw.Flush();
            sw.Close();
            //Process.Start("notepad.exe", "TriAnswer.txt");

        }
        
        //Her har vi metoden, der kan bruges til at regne højder og areal for trekanter og printer det ud i en txt fil
        public void detailedCalc(double a, double b, double c, double A, double B, double C) {

            StreamWriter detail = new StreamWriter("answerDetail", false);

            double h_a;
            double h_b;
            double h_c;
            //h_a=Sin(C)*b

            //Vi beregner højder og areal
            h_a = Math.Sin(Math.PI / 180 * C) * b;
            h_b = Math.Sin(Math.PI / 180 * A) * c;
            h_c = Math.Sin(Math.PI / 180 * B) * a;

            double Area;

            Area = 0.5 * a * b * (Math.Sin(Math.PI / 180 * C));

            //Vi skriver det ind i en txt fil
            detail.WriteLine("længder og vinkler \na: " + Math.Round(a, 5, MidpointRounding.AwayFromZero) + "\nb: " + Math.Round(b, 5, MidpointRounding.AwayFromZero) + "\nc: " + Math.Round(c, 5, MidpointRounding.AwayFromZero) + "\nA: " + Math.Round(A, 5, MidpointRounding.AwayFromZero) + "\nB: " + Math.Round(B, 5, MidpointRounding.AwayFromZero) + "\nC: " + Math.Round(C, 5, MidpointRounding.AwayFromZero));
            detail.WriteLine("\nHøjder \nh_a: " + Math.Round(h_a, 5, MidpointRounding.AwayFromZero) + "\nh_b: " + Math.Round(h_b, 5, MidpointRounding.AwayFromZero) + "\nh_c: " + Math.Round(h_c, 5, MidpointRounding.AwayFromZero));
            detail.WriteLine("\nAreal: " + Math.Round(Area, 5,MidpointRounding.AwayFromZero));

            detail.Flush();
            detail.Close();
            //Vi åbner denne her txt fil, så det kan kopieres direkte fra den til hvor det skal bruges
            Process.Start("notepad.exe", "answerDetail");

        }

    }
}
