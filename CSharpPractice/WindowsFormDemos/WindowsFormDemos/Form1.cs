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

namespace WindowsFormDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProvincesCB.Items.Clear();
            CityCB.Items.Clear();
        }

        private void CountriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDD();
        }
        public void FillDD()
        {
  
            ProvincesCB.Items.Add  ("ON(Ontario)");
            ProvincesCB.Items.Add  ("WA(Washington)");
            ProvincesCB.Items.Add  ("BCN(Barcelona)");
            ProvincesCB.Items.Add ("BRG(Brandenburg)");


        }

        private void ProvincesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityCB.Items.Add("T.O(Torronto)");
            CityCB.Items.Add("Washington D.C(Washington)");
            CityCB.Items.Add("BCN City(Barcelona)");
            CityCB.Items.Add("BE City(Berlin)");
        }


    }
}