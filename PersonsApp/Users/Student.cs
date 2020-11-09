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
        private int numberInClass;
        private string classStr;

        public string ClassStr
        {
            get { return classStr; }
            set { classStr = value; }
        }

        public int NumberInClass
        {
            get { return numberInClass; }
            set { numberInClass = value; }
        }

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
