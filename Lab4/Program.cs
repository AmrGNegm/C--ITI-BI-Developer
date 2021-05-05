using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    struct subject
    {
        // Members
        int id;
        string name;
        int duration;
        // Properties
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Duration
        {
            set
            {
                duration = value;
            }
            get
            {
                return duration;
            }
        }

        // Constractors
        public subject (int _id, int _duration, string _name)
        {
            id = _id;
            duration = _duration;
            name = _name;
        }
 
        // register Print Fn
        public void register()
        {
            Console.WriteLine($"Name of Subject is {name}");

        }

        // ToString
        public override string ToString()
        {
            return $"{id}-{name}\t{duration}Hours";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 Task subject from user and print it using tostring

            //subject subjX = new subject();

            //Console.WriteLine("Enter Your Subject Name");
            //subjX.Name = Console.ReadLine();
            //Console.WriteLine("Enter Your Subject Id");
            //subjX.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your Subject Duration");
            //subjX.Duration = int.Parse(Console.ReadLine());
            //Console.WriteLine(subjX.ToString());

            #endregion

            #region Task 2 Array of subjects


            Console.WriteLine("Enter Your Numbers of Subjects");
            int Numofsubj = int.Parse(Console.ReadLine());


            subject[] subjects = new subject[Numofsubj];

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("Enter Your Subject Name");
                subjects[i].Name = (Console.ReadLine());

                Console.WriteLine("Enter Your Subject id");
                subjects[i].Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Subject Duration");
                subjects[i].Duration = int.Parse(Console.ReadLine());

                 //subjects[i] = new subject();

            }

            for (int i = 0; i < subjects.Length; i++)
            {
                //Console.WriteLine($"Your Subject {subjects[i].ToString()}");

                Console.WriteLine(subjects[i].ToString());
            }

            
            #endregion

        }
    }
}
