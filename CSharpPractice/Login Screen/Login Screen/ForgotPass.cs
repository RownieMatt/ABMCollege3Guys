using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen
{
    public partial class ForgotPass : Form
    {


        internal ForgotPass(string Username)
        {
            InitializeComponent();
            UsernameTBox.Text = Username;
        }



        internal void MakeNewPB_Click(object sender, EventArgs e)
        {
            var username = UsernameTBox.Text;
            var password = NewPTBox.Text;
            var cpassword = ConfirmPTBox.Text;

            if (password != null)
            {
                NPValidL.Visible = false;
                bool isNewPass = fncPasswordValid(password);
                if (isNewPass == true) 
                {
                    if(password == cpassword)
                    {
                        NPValidL.Visible=true;
                        NPValidL.Text = "You have created a new password";
                        NPValidL.ForeColor= Color.Green;
                        NewPassword(password);
                    }
                    else
                    {
                        CPValidL.Visible=true;
                        CPValidL.Text = "Please put it the same new password";
                        CPValidL.ForeColor= Color.Red;
                    }
                }
                else
                {
                    NPValidL.Visible = true;
                    NPValidL.Text = "Please write the correct password";
                    NPValidL.ForeColor = Color.Red;
                }
            }
            else
            {
                NPValidL.Visible = true;
                NPValidL.Text = "Please put your new password";
            }


        }

        public bool fncPasswordValid(string password)
        {
            bool isPassword = false;

            if (Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                NPValidL.Visible = false;
                isPassword= true;
            }
            else
            {
                isPassword= false;
            }
            return isPassword;
        }

        public void NewPassword(string password)
        {

        }  

    }
}
