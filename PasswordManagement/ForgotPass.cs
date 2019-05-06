using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using System.IO;
using PasswordManagement.Properties;

namespace PasswordManagement
{
    public partial class ForgotPass : Form
    {
        NetworkCredential log;
        SmtpClient client;
        MailMessage mailmsg;
        int[] cd = new int[6];
        int nu=0;
        string Cod;
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = @"Purovider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\Dell\Documents\PasswordManagement.accdb;";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdDataBase = new OleDbCommand("Select * from SignUpForm where Sign_Up_Email='" + CodeSend.Text + "';", conDataBase);
                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    log = new NetworkCredential("UmbrellaVault@gmail.com", "umbrella@1997");
                    client = new SmtpClient("smtp.gmail.com");
                    client.Port = Convert.ToInt32(587);
                    client.EnableSsl = true;
                    client.Credentials = log;
                    mailmsg = new MailMessage { From = new MailAddress("Umbrella Vault" + "UmbrellaVault@gmail.com", "UmbrellaVault", Encoding.UTF8) };
                    mailmsg.To.Add(new MailAddress(CodeSend.Text));
                    for (int i = 0; i < 6; i++)
                    {
                        cd[i] = (GetRandomNumber(1, 10));
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        nu = cd[i];
                        CodeMessage.Text = CodeMessage.Text + nu;

                    }
                    Cod = CodeMessage.Text;
                    mailmsg.Body = CodeMessage.Text;
                    mailmsg.BodyEncoding = Encoding.UTF8;
                    mailmsg.IsBodyHtml = true;
                    mailmsg.Priority = MailPriority.Normal;
                    mailmsg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.SendCompleted += new SendCompletedEventHandler(SendCompleteCallBack);
                    string userstate = "Sending...";
                    client.SendAsync(mailmsg, userstate);
                }
                else
                {
                    MessageBox.Show("The Email ID Has Not Been Registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private static void SendCompleteCallBack(object sender, AsyncCompletedEventArgs q)
        {
            if (q.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send cancelled", q.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (q.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", q.UserState, q.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your message has been sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {

            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        private void CodeContinue_Click(object sender, EventArgs e)
        {
            if(Cod==CodeConfirm.Text)
            {
                this.Hide();
                SplashScreen s = new SplashScreen();
                s.Show();
            }
            else
            {
                MessageBox.Show("Invalid Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void CodeExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lgf = new LoginForm();
            lgf.Show();
        }

        private void CodeSend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
