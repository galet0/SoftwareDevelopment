using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp.Contracts
{
    interface IUserController
    {
        void RegisterUser(string userType, string name, string address,string email, string password, string confirmPassword);


    }
}
