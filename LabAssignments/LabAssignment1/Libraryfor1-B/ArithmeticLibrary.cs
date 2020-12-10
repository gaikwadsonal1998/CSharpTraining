using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryfor1_B
{
    public class ArithmeticLibrary
    {
        public Double num1 { get; set; }
        public Double num2 { get; set; }

        // public string opera { get; set; }


        public static void Addition(double num1, double num2)
        {
            Console.WriteLine("Addition is : {0}", (num1 + num2));
        }
        public static void Subtraction(double num1, double num2)
        {
            Console.WriteLine("Subtraction is : {0}", (num1 - num2));
        }
        public static void Multiplication(double num1, double num2)
        {
            Console.WriteLine("Multiplication is : {0}", (num1 * num2));
        }
        public static void Division(double num1, double num2)
        {
            Console.WriteLine("Division is : {0}", (num1 / num2));
        }
        public static void Modulus(double num1, double num2)
        {
            Console.WriteLine("Modulus is : {0}", (num1 % num2));
        }


    }
}
