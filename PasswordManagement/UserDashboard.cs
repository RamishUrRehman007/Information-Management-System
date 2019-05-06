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
    public partial class UserDashboard : Form
    {
        string abc;
        
        public UserDashboard()
        {
            InitializeComponent();
            abc = LoginFor.name();
            timer1.Start();
        }
        public string a = "", b = "", c = "", y = "", d = "", strEntryFormID;
        

        /*public UserDashboard(string abcd)
        {
            textBox2.Text = abcd;
        }*/
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int up = 1;
            this.Hide();
            EntryForm obj = new EntryForm(a,b,c,d,y,up);
            obj.Show();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            this.textBox1.Text = DT.ToString();
        }

        private void DashDataGrid_Click(object sender, EventArgs e)
        {
            int rowUpdate = DashDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            strEntryFormID = DashDataGrid.Rows[rowUpdate].Cells["Entry_Email"].Value.ToString();


            try
            {
                DataTable dtEntryFormInfobyID = new DataTable();
                dtEntryFormInfobyID = GetEntryFormInfoByID();
                DataRow row = dtEntryFormInfobyID.Rows[0];

                a = row["Entry_Site_Name"].ToString();
                b = row["Entry_Username"].ToString();
                c = row["Entry_Password"].ToString();
                d = row["Entry_Email"].ToString();
                y = row["Entry_Number"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private DataTable GetEntryFormInfoByID()
        {

            DataTable dtEntryFormInfo = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string strQuery = "Select Entry_Site_Name, Entry_Username, Entry_Password, Entry_Email, Entry_Number, Entry_SignUpMail from EntryForm where Entry_Email=@Entry_Email";
            try
            {
                using (OleDbConnection con = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strQuery, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Entry_Email", strEntryFormID);
                        OleDbDataReader reader = cmd.ExecuteReader();
                        dtEntryFormInfo.Load(reader);

                        con.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtEntryFormInfo;
        }
        private DataTable GetEntryFormList()
        {
            DataTable dtEntryForm = new DataTable();
            dtEntryForm.Rows.Clear();

            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string strQuery = "Select * from EntryForm where Entry_SignUpMail ='" + abc + "'";

            using (OleDbConnection con = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand(strQuery, con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtEntryForm.Load(reader);
                    con.Close();
                }
            }
            return dtEntryForm;
        }
        private void LoadDataIntoGridView()
        {

            DashDataGrid.DataSource = GetEntryFormList();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void DashDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ( e.KeyChar == (char)13)
           {
               if (string.IsNullOrEmpty(textBox2.Text))
               {
                   DashDataGrid.DataSource = GetEntryFormList();
               }
               else
               {
                   try
                   {
                       int count = 0;

                       string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                       OleDbConnection con = new OleDbConnection(connstring);

                       con.Open();
                       OleDbCommand cmd = con.CreateCommand();
                       cmd.CommandType = CommandType.Text;
                       cmd.CommandText = "select * from EntryForm where Entry_Site_Name = '" + textBox2.Text + "' and Entry_SignUpMail='" + abc + "';";
                       cmd.ExecuteNonQuery();
                       DataTable dtBatchInfo = new DataTable();
                       OleDbDataAdapter daBatchInfo = new OleDbDataAdapter(cmd);
                       daBatchInfo.Fill(dtBatchInfo);
                       count = Convert.ToInt32(dtBatchInfo.Rows.Count.ToString());
                       DashDataGrid.DataSource = dtBatchInfo;
                       con.Close();

                       if (count == 0)
                       {
                           MessageBox.Show("Record Does Not Exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
           }
       
        }

        private void DashExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text file(*.txt)|*.txt";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            string dirLocationString = sfd.FileName;
            TextWriter writer = new StreamWriter(dirLocationString);
            for (int i = 0; i < DashDataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DashDataGrid.Columns.Count; j++)
                {
                    writer.Write("\t" + DashDataGrid.Rows[i].Cells[j].Value.ToString() + "\t" + " | ");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Your data has been exported");
        }

        private void DashNew_Click(object sender, EventArgs e)
        {
            int up = 0;
            this.Hide();
            EntryForm obj = new EntryForm(a, b, c, d, y,up);
            obj.Show();
        }

        private void DashLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lgf = new LoginForm();
            lgf.Show();
        }

        private void DashDelete_Click(object sender, EventArgs e)
        {
            UserDashboar a = new UserDashboar();
            a.DashUpdate(strEntryFormID);
            LoadDataIntoGridView();

        }

        private void DashDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

       
       
    }
}
