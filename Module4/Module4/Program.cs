using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program4
    {

        public struct Student
        {
            public string name, sname;
        }

        public struct Teacher
        {
            public string name, sname;
        }

        public struct Program
        {
            public int input, output;
        }

        public struct Course
        {
            public string name, tipe;
        }

        static void Main(string[] args)
        {
            Student[] arr = new Student[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter StudentName");
                arr[i].name = Console.ReadLine();
                Console.WriteLine("Please enter Surname");
                arr[i].sname = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}: {1} {2}", i + 1, arr[i].name, arr[i].sname);
            }

            Console.ReadKey();
        }
    }
}