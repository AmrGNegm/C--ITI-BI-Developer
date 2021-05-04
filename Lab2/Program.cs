using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task - Multiplication Table for Numbers From 1 to 12


            Console.WriteLine("Multiplication Table for Numbers From 1 to 12, Press Enter To Go") ;
            Console.ReadKey();

            for (int i = 1; i <= 12; i++) 
            {
                for (int m = 1; m <= 12; m++) 
                {
                    Console.WriteLine($"{i} * {m} = {i * m}");
                }
            }
            #endregion

        }
    }
}
