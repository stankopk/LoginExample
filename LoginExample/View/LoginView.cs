using LoginExample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginExample.View
{
    public partial class LoginView : Form
    {
        LoginController loginController = new LoginController();

        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var password = loginController.UserPassword(txtUsername.Text);
            if(password == null)
            {
                MessageBox.Show("No such user!");
            }
            else if(password != txtPassword.Text)
            {
                MessageBox.Show("Wrong Password!");
            }
            else
            {
                MainView mv = new MainView();
                this.Hide();
                mv.Show();
            }
        }
    }
}
