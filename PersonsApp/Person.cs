using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp
{
    class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }
}
