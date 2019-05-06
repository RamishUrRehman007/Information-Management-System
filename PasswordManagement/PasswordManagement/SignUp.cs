using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using PasswordManagement.Properties;

namespace PasswordManagement
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpRegister_Click(object sender, EventArgs e)
        {
            SignUpForm o = new SignUpForm();
            o.SignUpRegister(SignUpName.Text, SignUpSurname.Text,SignUpEmail.Text,SignUpPassword.Text,SignUpConfirmPassword.Text,SignUpNumber.Text);
        }

        private void SignUpName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
