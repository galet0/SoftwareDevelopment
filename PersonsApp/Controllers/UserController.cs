using PersonsApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsApp.Controllers
{
    public class UserController : IUserController
    {
        private List<User> users = new List<User>();
        
        public void RegisterUser(string userType, string name, string address, string email, string password, string confirmPassword)
        {

            switch (userType)
            {
                case "Student":
                    Student student = new Student(name, address, email);
                    student.Password = password;
                    student.ConfirmPassword = confirmPassword;
                    users.Add(student);
                    break;
                case "Teacher":
                    Teacher teacher = new Teacher(name, address, email);
                    teacher.Password = password;
                    teacher.ConfirmPassword = confirmPassword;
                    users.Add(teacher);
                    break;
            }
        }

        public bool LoginUser(string email, string password)
        {
            
            User user = GetUserByEmail(email);
            if (user == null)
            {
                throw new ArgumentException("User not found!");
            }
            if (!user.Password.Equals(password))
            {
                throw new ArgumentException("Password is not valid!");
            }

            return true;
        }
        public User GetUserByEmail(string email)
        {
            User newUser = new User("user1", "user address", "useremail@abv.bg");
            newUser.Password = "1234567";

            users.Add(newUser);
            User user = this.users.Where(u => u.Email.Equals(email)).FirstOrDefault();            

            return user;
        }


    }
}
