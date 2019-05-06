using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagement
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }
        int upe;
        public EntryForm(string a,string b,string c,string d,string y, int up)
        {
            InitializeComponent();
            upe = up;
            EntrySiteName.Text = a.ToString();
            EntryUsername.Text = b.ToString();
            EntryPassword.Text = c.ToString();
            EntryEmail.Text = d.ToString();
            EntryNumber.Text = y.ToString();
            if(upe== 0)
            {
                EntryCreate.Visible = true;
                EntryUpdate.Visible = false;
            }
            if (upe == 1)
            {
                EntryCreate.Visible = false;
                EntryUpdate.Visible = true;
            }

        }
        EntryFor EEF = new EntryFor();
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void EntryCreate_Click(object sender, EventArgs e)
        {
           
            EEF.EntryCreate(EntrySiteName.Text, EntryUsername.Text, EntryPassword.Text, EntryEmail.Text, EntryNumber.Text);
            //this.Hide();
            //UserDashboard usd = new UserDashboard();
            //usd.Show();
        }

        private void EntryUpdate_Click(object sender, EventArgs e)
        {         
            EEF.EntryUpdate(EntrySiteName.Text, EntryUsername.Text, EntryPassword.Text, EntryEmail.Text, EntryNumber.Text);
            //this.Hide();

            //UserDashboard usd = new UserDashboard();
            //usd.Show();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void EntryExit_Click(object sender, EventArgs e)
        {
            this.Close();
            UserDashboard usd = new UserDashboard();
            usd.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard obj = new UserDashboard();
            obj.Show();
        }
    }
}
