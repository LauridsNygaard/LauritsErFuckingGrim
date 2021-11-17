using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_22_gennemløb_Arrrays {
    class Program {
        static void Main(string[] args) {
            
            int[] numbers = { 1, 3, 5, 7, 9, 11 };
            int x = 0;

            for (int i=0; i < numbers.Length; i++) {
                x += numbers[i];

            }
            Console.WriteLine(x);


            string[] words = { "h", "e", "l", "l", "o" };

            for (int i = 0; i < words.Length; i++) {
                Console.WriteLine(words[i]);
            }
            
            List<int> myList = new List<int>();

            myList.Add(2);
            myList.Add(5);
            myList.Add(10);

            foreach (int i in myList) {

                Console.WriteLine(i);
            }


        }
    }
}
