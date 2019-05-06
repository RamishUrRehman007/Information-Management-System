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
        public EntryForm(string a,string b,string c,string d,string y)
        {
            InitializeComponent();
            EntrySiteName.Text = a.ToString();
            EntryUsername.Text = b.ToString();
            EntryPassword.Text = c.ToString();
            EntryEmail.Text = d.ToString();
            EntryNumber.Text = y.ToString();
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
        }

        private void EntryUpdate_Click(object sender, EventArgs e)
        {
            
            EEF.EntryUpdate(EntrySiteName.Text, EntryUsername.Text, EntryPassword.Text, EntryEmail.Text, EntryNumber.Text);
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
