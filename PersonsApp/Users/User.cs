using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp
{
    public class User
    {
        private string name;
        private string address;
        private string email;
        private string password;
        private string confirmPassword;       

        public User(string name, string address, string email)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Password
        {
            get { return password; }
            set 
            {
                if(value.Length < 6)
                {
                    throw new ArgumentException("Password must be more than 6 symbols!");
                }
                password = value;
            }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set 
            {
                if (!value.Equals(this.Password))
                {
                    throw new ArgumentException("Confirming password not match!");
                }
                confirmPassword = value; 
            }
        }
    }
}
