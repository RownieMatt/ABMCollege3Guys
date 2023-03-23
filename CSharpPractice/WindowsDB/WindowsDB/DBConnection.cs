using System.Data;
using System.Data.SqlClient;
using System.Drawing;



namespace WindowsDB
{
    public partial class DBConnection : Form
    {
        static SqlConnection SqlConnect()
        {
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }
        public DBConnection()
        {
            InitializeComponent();
        }

        private void FillB_Click_1(object sender, EventArgs e)
        {
            FillDropdown();
        }

        internal void FillDropdown()
        {
            SqlConnection con = SqlConnect();

            string query = "select ID,Description,isActive from Area ;Select SubAreaID , SubArea , isActive from SubAreaT;select PlacesID , PlacesName, isActive from AreaPlaces  ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Area");
            ds.Tables[1].TableName = "Sub Area";
            ds.Tables[2].TableName = "Area Places";
            CountriesCB.DisplayMember = "Description";
            CountriesCB.ValueMember = "ID";
            CountriesCB.DataSource = ds.Tables["Area"];

            SubADD.DisplayMember = "SubArea";
            SubADD.ValueMember = "SubAreaID";
            SubADD.DataSource = ds.Tables["Sub Area"];

            AreaPDD.DisplayMember = "PlacesName";
            AreaPDD.ValueMember = "PlacesID";
            AreaPDD.DataSource = ds.Tables["Area Places"];
            con.Close();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    RegisterDemo Open = new RegisterDemo();
        //    this.Hide();
        //    Open.Show();
        //}
    }
}

