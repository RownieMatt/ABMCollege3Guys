using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            double SolutionAdd = Convert.ToDouble(FirstVTBox.Text) + Convert.ToDouble(SecondVTBox.Text);
            AnswerLabel.Text = Convert.ToString(SolutionAdd);
        }

        private void SubtractB_Click(object sender, EventArgs e)
        {
            double SolutionSubtract = Convert.ToDouble(FirstVTBox.Text) - Convert.ToDouble(SecondVTBox.Text);
            AnswerLabel.Text = Convert.ToString(SolutionSubtract);
        }
    }
}
