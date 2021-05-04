using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    struct complex
    {
        int real;
       //public void set_real(int _real)
       // {
       //     if (_real > 0)
       //         real = _real;
       //     else real = 1;
       // }
       // public int get_real()
       // {
       //     return real;
       // } 

        public int Real
        {
            get { return real; }
            set {
                if (value > 0)
                    real = value;
                else
                    real = 1;
            
            }
        }



         public int img { get; set; }

        // int img;
        //public int Img
        // {
        //     set { img = value; }
        //     get { return img; }
        // }




        //int img;

        //public int Img
        //{
        //    set { img = value; }
        //    get {
        //        if (img > 0)
        //            return img;
        //        else
        //            return 0;
        //    }
        //}

        //public void set_img(int _img)
        //{
        //    img = _img;
        //}

        //public int get_img()
        //{
        //    if (img > 0)
        //        return img;
        //    else
        //        return 0;
        //}

        //action


        //constractor

        public complex(int  _real , int  _img)
        {
            real = _real;
            img = _img;
        }

        public complex (int _real)
        {
            real = _real;
            img = 0;
        }

        public void print()
        {
            Console.WriteLine($"{real}+{img}i");
        }

        public override string ToString()
        {
            return $"{real}+{img}i";
        }

    }

    struct calc
    {
        public int sum(int num1 ,int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int sum (int num1  ,int num2  ,int num3)
        {
            return num1 + num2 + num3;
        }

        public int sum (int num1 , int num2 ,int num3 ,int num4)
        {
            return num1 + num2 + num3 + num4;
        }

        //public void test ( string  name  , int id)
        //{

        //}

        //public void test (int id , string name)
        //{

        //}


        //public  void test ( int id)
        //{

        //}
        // public void test (string id)
        //{

        //}
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            #region struct 
            //calc cl;
            //    int re=cl.sum(1, 2)
            // Console.WriteLine( cl.sum(1,3));

            //  int result = cl.sum(1, 5);
            //  Console.WriteLine(result);

            //  int x;
            //  complex c;
            //  c.real = 12;
            //  c.img = 4;
            ////  c.print();

            //  complex c2;
            //  c2.real = 7;
            //  c2.img = 8;
            //  c2.print();

            #endregion
            #region setter & getter fun



            //complex c2 = new complex();
            //c2.set_real(5);
            //Console.WriteLine(c2.get_real());


            //complex c = new complex();
            //c.set_real(10);
            //c.set_img(6);


            //int r = c.get_real();
            //r++;
            //c.set_real(r);

            //c.Real = 4;
            //c.Real++;

            //Console.WriteLine(c.Real);


            // Console.WriteLine($"{c.get_real()}+ {c.get_img()}i");
            //  Console.WriteLine(c.get_real());
            //c.print();
            #endregion
            #region prop 

            //complex c = new complex();
            //c.Real = 5;
            //c.img = 3;
            //Console.WriteLine($"{c.Real}+{c.img}i");



            #endregion


            #region constractor
            //   complex c = new complex();
            //complex c = new complex(2, 2);
            //   complex c = new complex(1);

            //complex c2 = new complex();

            #endregion
            #region overload
            //calc c;
            //c.sum(1, 2, 3,4); // break point 
            //c.sum(1,2,3)

            #endregion

            #region  array of struct
            //int[] arr = new int[5];
            //complex[] arr2 = new complex[5];
            //arr2[0].Real = 2;
            //arr2[0].img = 1;
            //arr2[0].print();

            //Console.WriteLine("enter size");
            //int size = int.Parse(Console.ReadLine());

            //complex[] arr = new complex[size];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter rael for complex {i+1}");
            // arr[i].Real  = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"enter img for complex {i + 1}");

            //    arr[i].img = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i].print();
            //}


            #endregion

            #region tostring

            complex c = new complex(4,5);
            Console.WriteLine(c.ToString());

            #endregion

        }
    }
}
