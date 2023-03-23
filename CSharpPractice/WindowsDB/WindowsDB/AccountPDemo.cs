using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDB
{
    public partial class AccountPDemo : Form
    {
        public SqlConnection SqlConnect()
        {
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }
        public AccountPDemo(string user)
        {
            InitializeComponent();
            AccountL.Text = user;
        }
        private void DeleteAB_Click(object sender, EventArgs e)
        {
            bool Delete = isDelete();
            if (Delete == true)
            {
                MessageBox.Show("Account Deleted");
                ReturnLogin();

            }
        }
        public bool isDelete()
        {

            string User = AccountL.Text.Trim().ToString();
            bool isDelete = false;
            
            SqlConnection conn = SqlConnect();
            try
            {
                conn.Open();
                string SelectQ = $"select AccountID from Account where Username = '{AccountL.Text}';";
                
                SqlCommand cmd = new SqlCommand(SelectQ, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) 
                {
                    AIDLabel.Text = rdr[0].ToString();
                   
                }
                rdr.Close();
                string DeleteQ = "delete from Account where AccountID=@ID";
                SqlCommand cmd2 = new SqlCommand(DeleteQ, conn);
                cmd2.Parameters.Add("@ID", SqlDbType.BigInt);
                cmd2.Parameters["@ID"].Value = AIDLabel.Text;
                SqlDataReader dr2 = cmd2.ExecuteReader();
                MessageBox.Show("Account has been deleted");
                dr2.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString()); 
            }
            finally
            {
                conn.Close();
            }

            return isDelete;
        }

        private void LogoutB_Click(object sender, EventArgs e)
        {
            ReturnLogin();
        }
        public void ReturnLogin()
        {
            LoginDemo screen = new LoginDemo();
            this.Hide();
            screen.Show();
        }


    }
}
