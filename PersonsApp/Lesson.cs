using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp
{
    class Lesson
    {
        private string name;
        private List<double> grades;

        public Lesson(string name)
        {
            Name = name;
            grades = new List<double>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<double> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

    }
}
