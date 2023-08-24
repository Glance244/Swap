using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Swap
            int num1 = 5;
            int num2 = 6;
            Console.WriteLine("Original: ");
            Console.WriteLine("\tNumber1: "+num1);
            Console.WriteLine("\tNumber2: "+num2);
            Swap<int>(ref num1, ref num2);
            Console.WriteLine("Swapped: ");
            Console.WriteLine("\tNumber1: "+num1);
            Console.WriteLine("\tNumber2: "+num2);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
        private static void Swap<B>(ref B element1, ref B element2)
        {
            B temp = element1;
            element1 = element2;
            element2 = temp;
        }
    }
}
