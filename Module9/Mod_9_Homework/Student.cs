using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student : Person
    {
        Stack<int> grades = new Stack<int>();
        public Student(string fName, string lName, string city) : base(fName, lName, city)
        {
            this.firstName = fName; this.lastName = lName; this.city = city;

        }

        public void takeATest()
        {
            Random r = new Random();
            grades.Push(r.Next());
        }
    }
}
