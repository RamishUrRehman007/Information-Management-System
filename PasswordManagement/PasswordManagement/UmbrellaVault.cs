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
    public class UmbrellaVault
    {
        public void Load()
        {

        }
        public void CloseButton()
        {

        }
    }
    
    public class LoginFor : UmbrellaVault
    {
        public string loginusername, loginpassword;
        public LoginFor()
        {
            loginusername = null;
            loginpassword = null;
        }

        public void LoginButton(string loginusername, string loginpassword)
        {
            try
                {
                    string constring = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\ramis\Desktop\Hamza\PasswordManagement.accdb;";
            OleDbConnection conDataBase = new OleDbConnection(constring);
            OleDbCommand cmdDataBase = new OleDbCommand("Select * from SignUpForm where Sign_Up_Name='" + loginusername + "' and Sign_Up_Password='" + loginpassword + "';", conDataBase);
            OleDbDataReader myReader;
           
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count=count+1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successful","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SplashScreen obj = new SplashScreen();
                    obj.Show();
                    
                }
                else
                {
                    MessageBox.Show("Username or Password do not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        /*
        public void LoginSignUp()
        {

        }
        public void LoginForgotPass()
        {

        }*/
    }
    public class SignUpForm : UmbrellaVault
    {
        public string signupname, signupsurname, signupemail, signuppassword, signupconfirmpassword, signupnumber;
        DataTable dtSignUp = new DataTable();
        string strSignUp;
        public SignUpForm()
        {
            signupname = null; 
            signupsurname = null; 
            signupemail = null; 
            signuppassword = null; 
            signupconfirmpassword = null;
            signupnumber = null;

        }
        /*public void Load ()
        {

        }*/
        public void SignUpRegister(string signupname, string signupsurname, string signupemail, string signuppassword, string confirmpassword, string signupnumber)
        {
            try
            {

                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string strQuery = "INSERT INTO SignUpForm (Sign_Up_Name,Sign_Up_Surname,Sign_Up_Email,Sign_Up_Password,Sign_Up_Number) values (@Sign_Up_Name,@Sign_Up_Surname,@Sign_Up_Email,@Sign_Up_Password,@Sign_Up_Numbe)";

                using (OleDbConnection con = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strQuery, con))
                    {
                        if (signuppassword == confirmpassword)
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@Sign_Up_Name", signupname);
                            cmd.Parameters.AddWithValue("@Sign_Up_Surname", signupsurname);
                            cmd.Parameters.AddWithValue("@Sign_Up_Email", signupemail);
                            cmd.Parameters.AddWithValue("@Sign_Up_Password", signuppassword);
                            cmd.Parameters.AddWithValue("@Sign_Up_Number", signupnumber);

                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record is saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    /*
    class ForgotPas : UmbrellaVault
    {
        public int fpnumber, fpcode;
        public void SMSSend(int fpnumber)
        {

        }
        public void fpContinue()
        {

        }
    }
    class UserDashboar : UmbrellaVault
    {
        public string search;
        public void DashSearch(string search)
        {

        }
        public void DashDataGrid()
        {

        }
        public void DashNew()
        {

        }
        public void DashUpdate()
        {

        }
        public void DashDelete()
        {

        }
        public void DashExport()
        {

        }
        public void DashImport()
        {

        }
        public void DashLogout()
        {

        }
    }*/
    class EntryFor : UmbrellaVault
    {
        public string entrysitename, entryusername, entrypassword, entryemail, entrynumber;
        public EntryFor()
        {
            entrysitename = null;
            entryusername = null;
            entrypassword = null;
            entryemail = null;
            entrynumber = null;
        }
        public void EntryCreate(string entrysitename, string entryusername, string entrypassword, string entryemail, string entrynumber)
        {
            try
            {

                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string strQuery = "INSERT INTO EntryForm (Entry_Site_Name,Entry_Username,Entry_Password,Entry_Email,Entry_Number) values (@Entry_Site_Name,@Entry_Username,@Entry_Password,@Entry_Email,@Entry_Number)";

                using (OleDbConnection con = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strQuery, con))
                    {
                            con.Open();
                            cmd.Parameters.AddWithValue("@Entry_Site_Name", entrysitename);
                            cmd.Parameters.AddWithValue("@Entry_Username", entryusername);
                            cmd.Parameters.AddWithValue("@Entry_Password", entrypassword);
                            cmd.Parameters.AddWithValue("@Entry_Email", entryemail);
                            cmd.Parameters.AddWithValue("@Entry_Number", entrynumber);

                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record is saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EntryUpdate(string entrysitename, string entryusername, string entrypassword, string entryemail, string entrynumber)
        {
            try
            {

                string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string strQuery = "UPDATE EntryForm SET Entry_Site_Name=@Entry_Site_Name, Entry_Username=@Entry_Username, Entry_Password=@Entry_Password, Entry_Email=@Entry_Email, Entry_Number=@Entry_Number WHERE Entry_Email=@Entry_Email";

                using (OleDbConnection con = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strQuery, con))
                    {
                            con.Open();
                            cmd.Parameters.AddWithValue("@Entry_Site_Name", entrysitename);
                            cmd.Parameters.AddWithValue("@Entry_Username", entryusername);
                            cmd.Parameters.AddWithValue("@Entry_Password", entrypassword);
                            cmd.Parameters.AddWithValue("@Entry_Email", entryemail);
                            cmd.Parameters.AddWithValue("@Entry_Number", entrynumber);

                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record is saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
    /*
    class Expor : UmbrellaVault
    {

    }
    class Impor : UmbrellaVault
    {

    }*/
}
