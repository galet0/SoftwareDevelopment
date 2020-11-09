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
    public partial class Login : Form
    {
        UserController controller = new UserController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                bool isLoggedIn = controller.LoginUser(email, password);
                if (isLoggedIn)
                {
                    MessageBox.Show("Message", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error Message", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
