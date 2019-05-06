using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PasswordManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string abcd;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPass fgp = new ForgotPass();
            fgp.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LoginFor obj = new LoginFor();
            obj.LoginButton(LoginUsername.Text, LoginPassword.Text);
            this.Hide();
        }

        private void LoginUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LoginPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }

        private void LoginExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Email(string abc)
        {
            return abc;
        }
    }
}
