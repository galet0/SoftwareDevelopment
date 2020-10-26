using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp
{
    class Teacher : User
    {
        public Teacher(string name, string address, string email) 
            : base(name, address, email)
        {
        }


    }
}
