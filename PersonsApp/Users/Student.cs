using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp
{
    class Student : User
    {
        private List<Lesson> lessons;

        public Student(string name, string address, string email) 
            : base(name, address, email)
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
