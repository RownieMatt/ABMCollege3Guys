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
using System.Globalization;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;


namespace Login_Screen
{
    internal partial class LoginScreen : Form
    {

        List<Accounts> accounts = new List<Accounts>()
        {
            new Accounts() {AccountID = 1 , Username = "Rownie@gmail.com" ,Password = "Lemon123!!!"}
        };

        public LoginScreen()
        {
            InitializeComponent();
            
        } 
 
        internal void LoginB_Click(object sender, EventArgs e )
        {
            AccountLogin(accounts);
        }
        public void AccountLogin(List<Accounts> accounts)
        {
            var Username = UsernameTBox.Text;
            var Password = PasswordTBox.Text;
            string User1 = "Rownie@gmail.com";
            string Pass1 = "Lemon123!!!";



            if (Username != null && Password != null)
            {
                bool isValid = fncAccountCheck(Username, Password);
                foreach (var account in accounts)
                {
                    if (isValid == true)
                    {
                        if (Username == account.Username && Password == account.Password)
                        {
                            ValidateUserL.Visible = true;
                            ValidateUserL.Text = "Login Succesful!!";
                            ValidateUserL.ForeColor = Color.Green;
                        }
                        else if (Username == account.Username && Password != account.Password)
                        {
                            ValidateUserL.Visible = false;

                            ValidatePassL.Visible = true;
                            ValidatePassL.Text = "Please enter correct password for account.";
                            ValidatePassL.ForeColor = Color.Red;

                        }
                        else
                        {
                            ValidateUserL.Visible = true;
                            ValidateUserL.Text = "Account does not exist";
                            ValidateUserL.ForeColor = Color.Red;


                        }


                    }
                    else
                    {
                        ValidatePassL.Visible = true;
                        ValidatePassL.Text = "Please enter password";
                        ValidatePassL.ForeColor = Color.Red;

                        ValidateUserL.Visible = true;
                        ValidateUserL.Text = "Please enter username";
                        ValidateUserL.ForeColor = Color.Red;
                    }
                }
            }
            else if (Username != null && Password == null)
            {
                ValidatePassL.Visible = true;
                ValidatePassL.Text = "Please enter password";
                ValidatePassL.ForeColor = Color.Red;
            }
            else if (Username == null && Password != null)
            {
                ValidateUserL.Visible = true;
                ValidateUserL.Text = "Please enter Username";
                ValidateUserL.ForeColor = Color.Red;
            }
        }
        public bool fncAccountCheck(string username, string password) 
        {
            bool isUsername = false;
            bool isPassword = false;
            bool isAccount = false;

            if(Regex.IsMatch(username, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                ValidateUserL.Visible =false;
                isUsername = true;
            }
            else
            {
                ValidateUserL.Visible= true;
                ValidateUserL.ForeColor= Color.Red;
                ValidateUserL.Text = "Please enter correct username";
               isUsername= false;
            }
            if(Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                ValidatePassL.Visible = false;
                isPassword = true;
            }
            else
            {
                ValidatePassL.Visible = true;
                ValidatePassL.ForeColor = Color.Red;
                ValidatePassL.Text = "Please enter correct password";
                isUsername = false;
            }
            if(isUsername == true && isPassword == true)
            {

                isAccount = true;
            }
            return isAccount;
        }

        internal void FPassB_Click(object sender, EventArgs e)
        {
            
            var ForgotPass = new ForgotPass(UsernameTBox.Text);
            this.Hide();
            ForgotPass.Show();
        }
    }
}