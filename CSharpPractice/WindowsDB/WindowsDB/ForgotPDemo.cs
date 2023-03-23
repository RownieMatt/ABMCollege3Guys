using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsDB
{
    public partial class ForgotPDemo : Form
    {
        static SqlConnection SqlConnect()
        {
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }
        public ForgotPDemo(string Username)
        {
            InitializeComponent();
            UECTbox.Text = Username;
        }
        public bool isConfirmed(string password)
        {
            bool isCon = false;
            string ConfirmPass= CPCTBox.Text;
            if (ConfirmPass == password )
            {
                isCon = true;
            }
            else
            {
                isCon = false;
            }

            return isCon;
        }

        private void CPButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = SqlConnect();   
            string Username = UECTbox.Text.Trim().ToString();
            string Password = PCTBox.Text.Trim().ToString();
            try
            {
                string ChangeQ = "select * from Account";
                SqlDataAdapter da = new SqlDataAdapter(ChangeQ, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Account");
                ds.Tables.Add(ChangeQ);
                if (Username != null && Password != null)
                {
                    bool isPC = isConfirmed(Password);
                    for (int Row = 0; Row < ds.Tables[0].Rows.Count; Row++)
                    {
                        if (Username == ds.Tables[0].Rows[Row]["Username"].ToString() && isPC)
                        {
                            ChangeQ = $"Update Account set Password = '{Password}' where Username = '{Username}';";
                            SqlDataAdapter daa = new SqlDataAdapter(ChangeQ, con);
                            daa.Fill(ds, "Account");
                            ds.Tables.Add(ChangeQ);
                            MessageBox.Show("Password changed succesfully");
                            break;
                        }
                    }
                }
               // ChangeLogin();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void ChangeLogin()
        {
            LoginDemo screen = new LoginDemo();
            
            this.Hide();
            screen.Show();
        }
    }
}
