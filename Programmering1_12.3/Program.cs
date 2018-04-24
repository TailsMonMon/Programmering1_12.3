using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_12._3 {
    class Program {
        static void Main(string[] args) {

            double[] temperatur;

            Console.Write("Antalet datapunker att lägga in: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            temperatur = new double[Convert.ToInt32(Console.ReadLine())];

            //      INPUTS DATA FROM USER TO VECTOR
            for (int i = 0; i < temperatur.Length; i++) { // Since I'm working with vectorns, I'll make a for-loop
                Console.Write("Ange temperatur: ");
                temperatur[i] = Convert.ToDouble(Console.ReadLine());
            }

            //      WRITES OUT DATA
            for(int i = 0; i < temperatur.Length; i++) {
                Console.Write(temperatur[i] + " ");
            }
            Console.WriteLine();

            //      CALCULATES AVERAGE VALUE
            double sum = 0;
            for(int i = 0; i < temperatur.Length; i++) {
                sum = sum + temperatur[i];
            }
            sum = sum / temperatur.Length;
            Console.WriteLine("Medelvärdet blir {0} grader", sum);

            Console.ReadLine();
        }
    }
}
