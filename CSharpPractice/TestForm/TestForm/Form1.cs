using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Move(object sender, EventArgs e)
        {
            label2.Text = "1. Move";
            this.Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "2. Load";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label4.Text = "3. Activated";
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            label5.Text = "4. Visible";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label6.Text = "5. Shown";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label7.Text = "6. Paint";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            label8.Text = "8. Closed";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            label9.Text = "9. Closing";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

            label10.Text = "10. Deactivated";
        }
    }
}
