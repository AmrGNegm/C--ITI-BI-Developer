using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    class student
    {
        public int id;
        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region variable

            // datatype variablename;
            //variablename=10;

            //int x1 = 10;
            //x = x + 1;

            //string x1= "10";
            //x1 = x1 + "1";
            //int num;
            //num = 12;
            //long num2 = 12344585757;
            //Console.WriteLine(num2);

            //float f = (float)1.2;
            //decimal d = 1.22m;
            //Console.WriteLine(f);

            //  bool t = false;

            //string x = "welcome to c#";
            //Console.WriteLine(x);


            //  int? x = 25;
            // Nullable<int> x = null;

            #endregion

            #region casting

            //int x = 3444555;
            //long y = x; //implicit casting

            //long x = 12345678;
            //int y = (int)x;//explicit casting

            //Console.WriteLine(y);

            //string x = "123";
            //int y = int.Parse(x);

            //int z = 123;
            //string txt = z.ToString() + "ahmed";
            //Console.WriteLine(z);

            //int x = Convert.ToInt32(1.2);

            // char c = 'A';
            // int d = (int)c;


            // //int x = 65;
            //c = (char)d;
            // Console.WriteLine(c);

            #endregion


            #region write & read & string format

            //string name = "mohamed elshafei";
            //int age = 30;
            //string address = "monufia";

            //    string print = "name=" + name + ", age=" + age + ", address=" + address;
            //string print = string.Format("name= {0} ,age={1},address={2}", name, age, address);
            //  string print = $"name={name},age={age},address={address}";
            //Console.WriteLine($"name={name}, \n age={age}, \t address={address}");
            //Console.WriteLine(@"D:\ITI Courses\OOPC# fullstack\OOPDay2");
            //  Console.WriteLine("name= {0} ,age={1},address={2}", name, age, address);
            //Console.WriteLine("welcome");
            //Console.Write(" C#");

            //int x = Console.Read();
            //  Console.WriteLine("enter student grade");
            //  int x = int.Parse(Console.ReadLine());
            ////string read=  Console.ReadLine();
            ////  int x = int.Parse(read);

            //  Console.WriteLine( x);

            //Console.WriteLine("enter your name");
            //string name = Console.ReadLine();

            //Console.WriteLine($"name={name}");

            //Console.WriteLine("enter first num");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second num");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"sum={num1+num2}");

            //  ConsoleKeyInfo c = Console.ReadKey();

            //    Console.WriteLine( c.Key);

            #endregion


            #region value vs ref

            //int x=5;
            //Console.WriteLine(x);
            //int num = new int();
            //Console.WriteLine(num);

            //int x = 5; int y = 7;

            //x = y;
            //Console.WriteLine($"x={x},y={y}");
            //y = 10;
            //Console.WriteLine($"x={x},y={y}");

            //student s = new student();
            //s.id = 1; s.name = "ahmed";


            //student s1 = new student();
            //s1.id = 2; s1.name = "mostafa";

            //Console.WriteLine($"s id={s.id} , name={s.name}");
            //Console.WriteLine($"s1 id={s1.id} , name={s1.name}");


            //s = s1;

            //Console.WriteLine("after equal");
            //Console.WriteLine($"s id={s.id} , name={s.name}");
            //Console.WriteLine($"s1 id={s1.id} , name={s1.name}");

            //s1.name = "mohamed";

            //Console.WriteLine("after change");
            //Console.WriteLine($"s id={s.id} , name={s.name}");
            //Console.WriteLine($"s1 id={s1.id} , name={s1.name}");


            #endregion



            #region control statment(conditional & loop)
            //conditional

            //Console.WriteLine("enter num");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine("postive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}

            //Console.WriteLine("enter budget");
            //int budget = int.Parse(Console.ReadLine());
            //if(budget>1000 && budget < 1200)
            //{
            //    Console.WriteLine("breakfast");
            //}
            //else if(budget>=1200 && budget < 1400)
            //{
            //    Console.WriteLine("breakfast+lunch");
            //}
            //else if (budget > 1400)
            //{
            //    Console.WriteLine("breakfast+lunch+dinner");
            //}
            //else
            //{
            //    Console.WriteLine("invalid budget");
            //}


            //Console.WriteLine("enter budget");
            //int budget = int.Parse(Console.ReadLine());
            //if (budget == 1000)
            //{
            //    Console.WriteLine("breakfast");
            //}
            //else if (budget == 1200 )
            //{
            //    Console.WriteLine("breakfast+lunch");
            //}
            //else if (budget == 1400)
            //{
            //    Console.WriteLine("breakfast+lunch+dinner");
            //}
            //else
            //{
            //    Console.WriteLine("invalid budget");
            //}

            //Console.WriteLine("enter budget");
            //int budget = int.Parse(Console.ReadLine());
            //switch (budget)
            //{
            //    case 1000:
            //        Console.WriteLine("breakfast");
            //        break;
            //    case 1200:
            //        Console.WriteLine( "breakfast+lunch");
            //        break;
            //    case 1400:
            //        Console.WriteLine("breakfast+lunch+dinner");
            //        break;
            //    default:
            //        Console.WriteLine("invalid budget");
            //        break;
            //}


            // loop


            //int sum = 0;
            //while(sum < 100)
            //{
            //    Console.WriteLine("enter num");
            //   sum += int.Parse(Console.ReadLine());
            //    //sum += x;
            //}

            //  Console.WriteLine(sum);
            //string phone = "";
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("enter your phone num");
            //    phone = Console.ReadLine();
            //} while (phone.Length != 11);

            //int i = 10;
            //for (; i>0; )
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }

            }

            #endregion

        }
    }
}
