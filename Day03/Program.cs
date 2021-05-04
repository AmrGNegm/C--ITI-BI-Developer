using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {


            #region while , do while ,for ,foreach

            //int sum = 0;
            //while (sum < 100)
            //{
            //    Console.WriteLine("enter number");
            //    sum += int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"sum={sum}");
            //string phone = " ";
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("enter phone num");
            //    phone = Console.ReadLine();
            //} while (phone.Length != 11);

            //Console.WriteLine("succefually added");



            //string name = "mohamed hosney";
            //Console.WriteLine(name.Length);



            //char c;
            //do
            //{

            //    Console.Clear();
            //    Console.WriteLine("A-add");
            //    Console.WriteLine("D-Display");
            //    Console.WriteLine("E-Edit");
            //    Console.WriteLine("x-Exit");
            //     c = char.Parse(Console.ReadLine());
            //    Console.Clear();
            //    switch (c)
            //    {
            //        case 'A':
            //        case 'a':
            //            Console.WriteLine("you can add new student");
            //            Console.ReadKey();
            //            break;
            //        case 'D':
            //        case 'd':
            //            Console.WriteLine("you can display student data");
            //            Console.ReadKey();

            //            break;

            //        case 'E':
            //        case 'e':
            //            Console.WriteLine("you can edit student data");
            //            Console.ReadKey();

            //            break;
            //        case 'X':
            //        case 'x':
            //            Console.WriteLine("you can exit from app");
            //            break;
            //        default:
            //            Console.WriteLine("invalid input ");
            //            break;
            //    }
            //} while (c!='X' && c!='x');


            //for
            //int x =5;
            //for (int x=1; x <= 12; x++ )
            //{

            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{x}*{i}={x*i}");
            //    }

            //   // x += 5;
            //}



            #endregion

            #region array

            ////int[] grades = new int[] { 1,3,5,7};
            //int[] grades =  { 1,3,5,7};
            ////grades[3] = 30;
            ////grades[1] = 20;
            //Console.WriteLine(grades[3]);

            //Console.WriteLine("enter num of student");
            //int numOfStudent = int.Parse(Console.ReadLine());
            //int[] degree = new int[numOfStudent];

            //for(int i=0; i < numOfStudent; i++)
            //{
            //    Console.WriteLine($"enter student num{i+1} degree");
            //    degree[i] = int.Parse(Console.ReadLine());

            //}

            //int sum = 0;
            //for(int i=0;i<numOfStudent; i++)
            //{
            //    sum += degree[i];
            //    Console.WriteLine($"degree of student num{i+1} ={degree[i]}");
            //}
            //Console.WriteLine($"total={sum}");


            //Console.WriteLine("enter num of student");
            //int numOfStudent = int.Parse(Console.ReadLine());
            //string[] students = new string[numOfStudent];
            //for (int i = 0; i < students.Length ; i++)
            //{
            //    Console.WriteLine($"enter name of student num {i+1}:");
            //    students[i] = Console.ReadLine();
            //}
            //Array.Sort(students);
            //Array.Reverse(students);
            //for (int i = 0; i < numOfStudent; i++)
            //{
            //    Console.WriteLine($"{i+1}-{students[i]} \t lenght={students[i].Length}");
            //}

            //foreach(string x in students)
            //{
            //    Console.WriteLine(x);
            //}

            //int[,] arr = new int[4, 3];
            //arr[1, 2] = 8;
            //Console.WriteLine( arr[1,3]);

            //Console.WriteLine("enter num of student");
            //int numOfStudent = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter num of subjects");
            //int numOfSubjects = int.Parse(Console.ReadLine());


            //int[,] grades = new int[numOfStudent, numOfSubjects];

            //for (int i = 0; i < numOfStudent; i++)
            //{
            //    for (int j = 0; j < numOfSubjects; j++)
            //    {
            //        Console.WriteLine($"enter grade of student num {i+1} in subject num {j+1}");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i <grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"grade of student num {i+1} in subject num {j+1}={grades[i,j]}");

            //    }
            //}


            #endregion


            #region value vs ref

            //int x = 5;
            //int y = 7;
            //Console.WriteLine($"x={x},y={y}");
            //x = y;
            //Console.WriteLine($"x={x},y={y}");

            //y = 9;
            //Console.WriteLine($"x={x},y={y}");

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[5] { 5, 6, 7, 8, 9 };
            Console.WriteLine($"arr1[0]={arr1[0]} ,arr2[0]={arr2[0]}");
            arr1 = arr2;
            Console.WriteLine($"arr1[0]={arr1[0]} ,arr2[0]={arr2[0]}");
            arr2[0] = 9;
            Console.WriteLine($"arr1[0]={arr1[0]} ,arr2[0]={arr2[0]}");


            #endregion
        }
    }
}
