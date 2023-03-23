using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDB
{
    public partial class LoginDemo : Form
    {
        static SqlConnection SqlConnect()
        {
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }
        public LoginDemo()
        {
            InitializeComponent();
            
        }

        private void LoginB_Click_1(object sender, EventArgs e)
        {
            try
            {
                string UserLog = UELogTBox.Text;
                string PassLog = PassLogTBox.Text;
                if (UserLog != null && PassLog != null)
                {
                    bool isAccount = Login(UserLog, PassLog);
                    if (isAccount == true)
                    {
                        MessageBox.Show("Login Succesful");
                        AccountPDemo screen = new AccountPDemo(UELogTBox.Text);
                        this.Hide();   
                        screen.Show();
                    }
                }
                 if (UserLog == null && PassLog == null)
                {
                    MessageBox.Show("Please type in info");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        public bool Login(string User, string Pass)
        {
            string LogStatus = string.Empty;
            bool isLogin = false;
            SqlConnection con = SqlConnect();
            try
            {

                string CheckQ = "select * from Account";
                SqlDataAdapter da = new SqlDataAdapter(CheckQ, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Account");
                ds.Tables.Add(CheckQ);



                for (int Row = 0; Row < ds.Tables[0].Rows.Count; Row++)
                {
                    if (User == ds.Tables[0].Rows[Row]["Username"].ToString() && Pass == ds.Tables[0].Rows[Row]["Password"].ToString())
                    {

                        LogStatus = "Account right";
                        break;

                    }
                    else if (User == ds.Tables[0].Rows[Row]["Username"].ToString() && Pass != ds.Tables[0].Rows[Row]["Password"].ToString())
                    {
                        MessageBox.Show("Type in correct password.");
                        LogStatus = "Password wrong";
                        break;
                    }
                    else if (User != ds.Tables[0].Rows[Row]["Username"].ToString() && Pass != ds.Tables[0].Rows[Row]["Password"].ToString())
                    {
                        
                        LogStatus = "Account wrong";
                        isLogin = false;
                    }
                }
                if (LogStatus == "Account right")
                {
                    isLogin= true;
                }
                if (LogStatus == "Password wrong")
                {
                    isLogin = false;

                }
                if (LogStatus == "Account wrong")
                {
                    MessageBox.Show("Account does not exist.");
                    isLogin = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            return isLogin;

        }
        private void NewAB_Click(object sender, EventArgs e)
        {
            RegisterDemo screen = new RegisterDemo();
            this.Hide();
            screen.Show();  
        }

        private void ForgotPB_Click(object sender, EventArgs e)
        {
            ForgotPDemo screen= new ForgotPDemo(UELogTBox.Text);
            this.Hide();
            screen.Show();

        }
    }
}

