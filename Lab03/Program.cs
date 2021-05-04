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


            //Console.WriteLine("Multiplication Table for Numbers From 1 to 12, Press Enter To Go") ;
            //Console.ReadKey();

            //for (int i = 1; i <= 12; i++) 
            //{
            //    for (int m = 1; m <= 12; m++) 
            //    {
            //        Console.WriteLine($"{i} * {m} = {i * m}");
            //    }
            //}
            #endregion

            #region 1.Take num of subjects from user and store their names and display it

            //Console.WriteLine("Please Enter Number of Your Subjects");
            //int NumOfSubjest = int.Parse(Console.ReadLine());

            //string[] arr_names = new string[NumOfSubjest];

            //for (int i = 0; i < NumOfSubjest; i++)
            //{
            //    Console.WriteLine($"Enter Your Subjest Name No.{i + 1}");
            //    arr_names[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Your Subjects Names are: \n");
            //for (int n = 0; n < arr_names.Length; n++)
            //{
            //    Console.WriteLine($"{n + 1}- Subject No.{n + 1} is {arr_names[n]}");
            //}

            #endregion

            #region 2. Take num of subjects from user and store their grades and calculate sum ,avg

            //Console.WriteLine("Please Enter Numbers of your subjects:");

            //int Num_of_Subjects = int.Parse(Console.ReadLine());

            //int[] grades = new int[Num_of_Subjects];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter Your No.{i + 1} subject Grade from 0 to 100:");

            //        do
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Enter Your subject Grade Again From 0 to 100:");
            //            x = int.Parse(Console.ReadLine());
            //        } while (x <= 100 && x >= 0);

            //}


            //for (int b = 0; b < grades.Length; b++)
            //{
            //    Console.WriteLine($"Your No.{b + 1} subject Grade is :{grades[b]}");
            //}


            //int sum = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    sum += grades[i];
            //}

            //int avg = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    avg = sum / grades.Length;
            //}
            //Console.WriteLine($"Sum Of Your Grads is: {sum}");
            //Console.WriteLine($"Average Of Your Grads is: {avg}");

            #endregion

            #region 3.Store sudents grades in different subjects, take numofstudents and numofsubjects from user,display it

            //Console.WriteLine("Please Enter Numbers of Students:");

            //int numofstudents = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Numbers of subjects:");

            //int numofsubjects = int.Parse(Console.ReadLine());

            //int[,] grades_of_students = new int[numofstudents, numofsubjects];


            //for (int i = 0; i < numofstudents; i++)
            //{
            //    for (int j = 0; j < numofsubjects; j++)
            //    {
            //        Console.WriteLine($"Enter grade of student No.{i + 1} in Subject No.{j + 1}:");
            //        grades_of_students[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < grades_of_students.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades_of_students.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Grade of student No.{i + 1} in subject No.{j + 1}={grades_of_students[i, j]}");

            //    }
            //}


            #endregion

            #region 4.Store players names in different teams ,take num of teams and num of players from user, enter players name ,then print it.

            //Console.WriteLine("Please Enter Numbers of Teams:");

            //int numofTeams = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Numbers of Players:");

            //int numofPlayers = int.Parse(Console.ReadLine());

            //string[] nameofPlayer = new string[numofPlayers];

            //int[,] Players_of_teams = new int[numofTeams, numofPlayers];


            //for (int i = 0; i < numofTeams; i++)
            //{
            //    for (int j = 0; j < numofPlayers; j++)
            //    {
            //        Console.WriteLine($"Enter Number of Player No.{j + 1} in Teams No.{i + 1}:");
            //        Players_of_teams[i, j] = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Enter Name of Player No.{j + 1} in Teams No.{i + 1}:");
            //        nameofPlayer[j] = Console.ReadLine();
            //    }
            //}

            //for (int i = 0; i < Players_of_teams.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Players_of_teams.GetLength(1); j++)
            //    {
            //        Console.WriteLine($" Name of Player No{j + 1} in Team No.{i+1} is {nameofPlayer[j]}");

            //    }
            //}

            #endregion

            #region 5.bouns: in task 3 - we need to calculate every student total grade;

            Console.WriteLine("Please Enter Numbers of Students:");

            int numofstudents = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Numbers of subjects:");

            int numofsubjects = int.Parse(Console.ReadLine());

            int[,] grades_of_students = new int[numofstudents, numofsubjects];


            for (int i = 0; i < numofstudents; i++)
            {
                for (int j = 0; j < numofsubjects; j++)
                {
                    Console.WriteLine($"Enter grade of student No.{i + 1} in Subject No.{j + 1}:");
                    grades_of_students[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < grades_of_students.GetLength(0); i++)
            {
                int sum = 0;
                for (int x = 0; x < grades_of_students.GetLength(1); x++)
                {
                    sum += grades_of_students[i,x];
                }
                  Console.WriteLine($"Sum of Grades of student No.{i + 1} is {sum} ");
            }

            

            #endregion

        }
    }
}
