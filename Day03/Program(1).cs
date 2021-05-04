using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region loop statment
            //while
            //do while
            //for
            //foreach
            //int sum = 0;

            //while (sum<100)
            //{
            //    Console.WriteLine("please enter num");
            //    int num = int.Parse(Console.ReadLine());
            //    sum = sum + num;
            //}

            //Console.WriteLine($"sum={sum}");

            //do while
            //string phone;
            //do
            //{
            //    Console.WriteLine("enter your phone num");
            //     phone = Console.ReadLine();

            //} while (phone.Length !=11);



            // for
            //int i = 0;
            //for(;i<=10 ;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        Console.WriteLine($"i={i} ,j={x}");
            //    }

            //}

            //Console.WriteLine(i);

            //int sum = 0;
            //int i = 0;
            //for (; i < 5; i++)
            //{
            //    Console.WriteLine("enter num");
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;

            //}

            //Console.WriteLine($"sum={sum}");

            #endregion

            #region array

            //int[] arr = new int[5];

            //arr[0]=1;
            //arr[1] = 30;
            //arr[4] = 60;
            //Console.WriteLine(arr[4]);

            //int[] arr2 = new int[] { 1, 5, 3, 9 };

            //int[] arr3 = { 1, 5, 6, 7, 8 };

            //   Console.WriteLine(arr[1]);

            //int[] arr = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    arr[i] = x;
            //}

            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sum += arr[i];
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine($"sum={sum}");

            //Console.WriteLine("enter num of subjects");
            //int numOfSubjects = int.Parse(Console.ReadLine());

            //int[] degrees = new int[numOfSubjects];

            //for (int i = 0; i < degrees.Length ; i++)
            //{
            //    Console.WriteLine($"enter degree of subject {i+1}");
            //    degrees[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < numOfSubjects; i++)
            //{
            //    Console.WriteLine($" degree of subject {i+1}={degrees[i]}");
            //    sum += degrees[i];
            //}

            //Console.WriteLine($"sum={sum} ,avg ={sum/numOfSubjects}");

            Console.WriteLine("enter num of student ");
            int numOfStudent = int.Parse(Console.ReadLine());

            string[] names = new string[numOfStudent];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"enter name of student num {i+1}");
                names[i] = Console.ReadLine();
            }

            Array.Sort(names);
            Array.Reverse(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"name of student num {i+1} : {names[i]}");
            }


            #endregion


        }
    }
}
