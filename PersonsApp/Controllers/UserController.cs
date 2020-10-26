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
    }
}
