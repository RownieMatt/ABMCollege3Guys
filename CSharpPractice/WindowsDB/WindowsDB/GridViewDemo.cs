using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDB
{
    public partial class GridViewDemo : Form
    {
        public GridViewDemo()
        {
            InitializeComponent();

        }
        public SqlConnection SqlConnect()
        {
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }

        private void GridViewDemo_Load(object sender, EventArgs e)
        {
            GridView();

        }

        void GridView()
        {
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EmployeeTable", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AccountG.DataSource = dt;
                cmd.ExecuteNonQuery();
                //string SelectQ = "select * from Account;";
                //con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(SelectQ, con);
                //DataSet ds = new DataSet();
                //da.Fill(ds, "Account");
                //AccountG.DataSource = ds.Tables["Account"];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            SearchAccount();
        }
        void SearchAccount()
        {
            SqlConnection conn = SqlConnect();

            try
            {
                conn.Open();
                string Search = SearchTBox.Text.Trim().ToString();
                SqlCommand cmd = new SqlCommand("SearchAccount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = Search;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AccountG.DataSource = dt;
                cmd.ExecuteNonQuery();
                //string Search = SearchTBox.Text.Trim().ToString();
                //string SearchQ = $"Select * from Account where Username like '%{Search}%'";
                //UsernameTBox.Text = Search;
                //SqlCommand cmd2 = new SqlCommand(SearchQ, conn);
                //cmd2.Parameters.AddWithValue("@Username", Search);
                //SqlDataAdapter da = new SqlDataAdapter(SearchQ, conn);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //AccountG.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void ResetB_Click(object sender, EventArgs e)
        {
            GridView();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            InsertEmployee();
        }
        bool UsernameTaken(string User)
        {
            SqlConnection con = SqlConnect();
            bool isTaken = false;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("NameCount",con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = User;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
 
                foreach(DataRow row in dt.Rows) 
                { 
                    string Row = row[0].ToString();
                    if (Row == "0" )
                    {
                        isTaken = true;
                        break;
                    }
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
            GridView();
            return isTaken;
        }
        void InsertEmployee()
        {
            SqlConnection conn = SqlConnect();
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("InsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (!string.IsNullOrEmpty(UsernameTBox.Text.Trim().ToString()))
                {
                    bool isAvailable = UsernameTaken(UsernameTBox.Text.Trim().ToString());
                    if(isAvailable==true) 
                    {
                        cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = UsernameTBox.Text.Trim().ToString();
                    }
                    else if (isAvailable==false) 
                    {
                        MessageBox.Show("Name already exists");
                        return;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Name",DBNull.Value);
                }
                if (!string.IsNullOrEmpty(AgeTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = AgeTBox.Text.Trim().ToString();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Age", DBNull.Value);
                }
                if(!string.IsNullOrEmpty(GenderTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = GenderTBox.Text.Trim().ToString();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }
                if(!string.IsNullOrEmpty(SalaryTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@Salary", SqlDbType.Float).Value = SalaryTBox.Text.Trim().ToString();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
                }
                if(!string.IsNullOrEmpty(DesignTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@Designation", SqlDbType.VarChar).Value = DesignTBox.Text.Trim().ToString();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Designation", DBNull.Value);
                }
                if (!string.IsNullOrEmpty(TeamLTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@TeamLead", SqlDbType.VarChar).Value = TeamLTBox.Text.Trim().ToString();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TeamLead", DBNull.Value) ;
                }
                cmd.ExecuteNonQuery();
                conn.Close();
                GridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString()); 
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

