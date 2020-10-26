using PersonsApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsApp
{
    public partial class Form1 : Form
    {
        private UserController userController = new UserController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            var personType = cbPersonType.Text;
            try 
            { 
                userController
                    .RegisterUser(personType, name, address, email,password, confirmPassword);

                txtName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (ArgumentException ex )
            {
                MessageBox.Show($"{ex.Message}", "ErrorMessage!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
