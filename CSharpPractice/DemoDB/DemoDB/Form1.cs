namespace DemoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string connectionString;
                SqlConnection cn;
                connectionString = @"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29";
                cn = new SqlConnection(connectionString);
                cn.Open();
                MessageBox.Show("Connection made.");
                cn.Close();
       
        }
    }
}