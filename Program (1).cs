using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay2
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

            //Console.WriteLine("welcome");

            //3+5=8;
            //x+y=z;
            //datatype  variable =value
            //int x = 2;
            ////x = 3;
            //x = 5;

            //long y = 1234567;

            //float x = (float)1.2;
            ////float x = 1.2F; 

            //double d = 1.23;

            //decimal h = 1.23m;

            //   bool b = false;
            // int? x = null;
            // bool? z = null;

            // char c = 'd';

            // string txt = "mohamed hosney elshafei";
            // Console.WriteLine(txt);

            #endregion
            #region casting

            //implecit casting
            //int x = 45;
            //long y = x;

            //explicit casting
            //long x = 45;
            //// int y =Convert.ToInt32(x);
            //int y = (int)x;

            //float f = 1.2f;
            //int r = Convert.ToInt32( f);

            //Console.WriteLine(r);

            // string txt = "123";
            // int x = int.Parse(txt);
            // int x = Convert.ToInt32(txt);
            // x = x + 10;

            //int z = 123;
            //string x1 = z.ToString() + "ahmed";

            //Console.WriteLine(x1);

            //char c = 'a';
            //int x = Convert.ToInt32(c); //ascii
            //Console.WriteLine(x);

            //int x = 97;
            //char c = Convert.ToChar(x);
            //Console.WriteLine(c);


            // Console.ReadKey();
            #endregion

            #region read & write
            //string txt = "mohamed hosney elshafei";
            //string txt2 = "mohamed hosney elshafei";
            //Console.Write(txt);
            //Console.Write(txt2);
            //int id = 1;
            //string name = "mohamed elshafei";
            //int age = 30;

            //string txt ="id="+ id.ToString() +"-name= "+ name +" age="+ age.ToString();
            //Console.WriteLine(txt);

            //  Console.WriteLine("id=" + id.ToString() + "-name= " + name + " age=" + age.ToString());

            //string txt = string.Format("id:{0} , name:{1} , age:{2}", id, name, age);
            //Console.WriteLine(txt);

            //Console.WriteLine("your id:{0},your age={1},fullname:{2}",id,age ,name);

            //string txt = $"id:{id} , name={name} ,age={age}";
            //Console.WriteLine(txt);

            //  Console.WriteLine($"id={id},name={name} \n age={age}");

            // Console.WriteLine(@"C:\Users\MELshafey\Desktop\New folder");

            //Console.Write("enter your name ");
            //string txt = Console.ReadLine();

            //txt ="welcome "+ txt;
            //Console.WriteLine(txt);

            //string x = Console.ReadLine();
            //int z = int.Parse(x);
            //z = z + 10;
            //Console.WriteLine(z);


            //string x = Console.ReadLine();
            //int z = int.Parse(x);
            //int z = int.Parse(Console.ReadLine());
            //z = z + 10;
            //Console.WriteLine(z);

            //   Console.WriteLine("enter first num");
            //   int num1 = int.Parse(Console.ReadLine());

            //   Console.WriteLine("enter second num");
            //   int num2 = int.Parse(Console.ReadLine());

            ////   int z = num1 + num2;

            //   Console.WriteLine($"result={num1+num2}");

            //int x=   Console.Read();
            //   Console.WriteLine(Convert.ToChar(x));

            //  Console.WriteLine(x);

            #endregion

            #region ref vs value
            //int x = 5;
            //int y = 7;

            //Console.WriteLine($"x={x},y={y}");

            //x = y;
            //Console.WriteLine($"x={x},y={y}");

            //x = 9;
            //Console.WriteLine($"x={x},y={y}");

            //ref
            //student s = new student();
            //s.id = 1;
            //s.name = "ali";

            //student s2 = new student();
            //s2.id = 2;
            //s2.name = "mosatfa";


            ////Console.WriteLine($"s id={s.id} ,name={s.name}");
            ////Console.WriteLine($"s2 id={s2.id} ,name={s2.name}");

            //s = s2;

            //Console.WriteLine($"s id={s.id} ,name={s.name}");
            //Console.WriteLine($"s2 id={s2.id} ,name={s2.name}");

            //s.id = 9;

            //Console.WriteLine($"s id={s.id} ,name={s.name}");
            //Console.WriteLine($"s2 id={s2.id} ,name={s2.name}");


            ///

            //int x = new int();
            //Console.WriteLine(x);


            #endregion

            #region control statment

            // condational statment

            //if
            //if else
            //if else if ...... else
            //switch

            // int x = int.Parse(Console.ReadLine());

            //if(x != 0)
            // {
            //     Console.WriteLine("done");
            // }

            //int x = int.Parse(Console.ReadLine());

            //if (x != 0)
            //{
            //    Console.WriteLine("done");
            //}
            //else
            //{
            //    Console.WriteLine("zero value");
            //}

            //Console.WriteLine("enter your degree");
            //int degree = int.Parse(Console.ReadLine());

            //if (degree >= 50 && degree < 65)
            //{
            //    Console.WriteLine("fair");
            //}
            //else if (degree >= 65 && degree < 75)
            //{
            //    Console.WriteLine("good");
            //}
            //else if (degree >= 75 && degree < 85)
            //{
            //    Console.WriteLine("very good");
            //}
            //else if (degree >= 85 && degree <= 100)
            //{
            //    Console.WriteLine("excellent");
            //}
            //else if (degree < 50)
            //{
            //    Console.WriteLine("fail");
            //}
            //else
            //{
            //    Console.WriteLine("invalid degree");
            //}


            //Console.WriteLine("we have 3 package for you per day \n 1-breakfast 1000$  \n" +
            //    " 2-breakfast+ dinnner 1200$   \n 3-breakfast+ dinner +lunch 1400$");

            //Console.WriteLine("enter your package budget");
            //int budget = int.Parse(Console.ReadLine());
            //if(budget==1000)
            //{
            //    Console.WriteLine("breakfast");
            //}
            //else if (budget == 1200)
            //{
            //    Console.WriteLine("breakfast + dinner");
            //}
            //else if (budget == 1400)
            //{
            //    Console.WriteLine("breakfast + dinner+lunch");

            //}
            //else
            //{
            //    Console.WriteLine("your budget not supported in our packages");
            //}



            Console.WriteLine("we have 3 package for you per day \n 1-breakfast 1000$  \n" +
                " 2-breakfast+ dinnner 1200$   \n 3-breakfast+ dinner +lunch 1400$");

            Console.WriteLine("enter your package budget");
            int budget = int.Parse(Console.ReadLine());
            switch (budget)
            {
                case 1000:
                case 1100:
                    Console.WriteLine("breakfast");
                    break;
                case 1200:
                    Console.WriteLine("breakfast +dinner");
                    break;
                case 1400:
                    Console.WriteLine("breakfast+dinner+lunch");
                    break;
                default:
                    Console.WriteLine("your budget not supported in our packages");
                    break;
            }



            //loop statment

            //while
            //do while
            //for
            //foreach



            #endregion


        }
    }
}
