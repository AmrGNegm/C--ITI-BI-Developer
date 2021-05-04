using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1-take-Char-Return-ASCII
            Console.WriteLine("1- Enter one character between A to Z Capitial or Small return ASCII:");
            char x = char.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToInt32(x));

            #endregion

            #region Task2-take-ASCII-Return-Char
            Console.WriteLine("Enter ASCII Code:");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToChar(z));

            #endregion

            #region Task3-num-odd-or-even
            Console.WriteLine("Enter Num Odd or Even:");
            int w = int.Parse(Console.ReadLine());
            if (w % 2 == 0)
            {
                Console.WriteLine("this Number is Even");
            }
            else
            {
                Console.WriteLine("this Number is Odd");
            }

            #endregion

            #region Task4 - take 2numbers print +, -, *
            Console.WriteLine("Enter first Num");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Num");
            int num2 = int.Parse(Console.ReadLine());



            Console.WriteLine($"result of sum= {num1 + num2} \n result of subtraction= {num1 - num2} \n result of multiplication= {num1 * num2}");
            #endregion

            #region Task5 - Grades of Students
            Console.WriteLine("Enter your degree between 0 to 100");
            int degree = int.Parse(Console.ReadLine());

            if (degree >= 50 && degree < 65)
            {
                Console.WriteLine("Fair");
            }
            else if (degree >= 65 && degree < 75)
            {
                Console.WriteLine("Good");
            }
            else if (degree >= 75 && degree < 85)
            {
                Console.WriteLine("Very Good");
            }
            else if (degree >= 85 && degree <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (degree < 50)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("invalid degree");
            }

            #endregion
            Console.ReadKey();
        }
    }
}
