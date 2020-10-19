using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp
{
    class Student : Person
    {
        private List<Lesson> lessons;

        public Student(string name, string address) 
            : base(name, address)
        {
            this.Lessons = new List<Lesson>();
        }

        public List<Lesson> Lessons
        {
            get { return lessons; }
            set { lessons = value; }
        }

    }
}
