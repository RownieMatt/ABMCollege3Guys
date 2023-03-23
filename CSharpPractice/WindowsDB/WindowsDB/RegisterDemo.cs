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
    public partial class RegisterDemo : Form
    {
        public RegisterDemo()
        {
            InitializeComponent();
        }
        static SqlConnection SqlConnect()
        {
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }

        private void RegisterB_Click(object sender, EventArgs e)
        {
            SqlConnection con = SqlConnect();
            try
            {
                string NewUserN = UserNTBox.Text.Trim().ToString();
                string NewEmailN = EmailTBox.Text.Trim().ToString();
                string NewPassN = PasswordTBox.Text;
                
                string InsertAccountN = $"insert into Account(Username,Email,Password) values('{NewUserN}','{NewEmailN}','{NewPassN}');";
                SqlDataAdapter da = new SqlDataAdapter(InsertAccountN, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Account");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString()); 
            }
            finally
            {
                con.Close();
            }
            LoginDemo screen = new LoginDemo();
            this.Hide();
            screen.Show();  
            

        }
    }

}
