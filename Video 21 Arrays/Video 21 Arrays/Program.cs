using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_21_Arrays {
    class Program {
        static void Main(string[] args) {

            //int[] numbers = { -2, -1, 0, 10 };

            int[] numbers = new int[4];
            numbers[0] = -2;
            numbers[1] = -1;
            numbers[3] = 10;
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[3]);

            Console.WriteLine(numbers[0]+numbers[1]+numbers[2]+numbers[3]);
        }
    }
}
