namespace Login_Screen
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.UsernameTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.LoginB = new System.Windows.Forms.Button();
            this.ValidateUserL = new System.Windows.Forms.Label();
            this.ValidatePassL = new System.Windows.Forms.Label();
            this.FPassB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "W3 Schools Login ";
            // 
            // UsernameL
            // 
            this.UsernameL.AutoSize = true;
            this.UsernameL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameL.Location = new System.Drawing.Point(121, 131);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(121, 32);
            this.UsernameL.TabIndex = 1;
            this.UsernameL.Text = "Username";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordL.Location = new System.Drawing.Point(121, 202);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(111, 32);
            this.PasswordL.TabIndex = 2;
            this.PasswordL.Text = "Password";
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTBox.Location = new System.Drawing.Point(259, 134);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(298, 29);
            this.UsernameTBox.TabIndex = 3;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTBox.Location = new System.Drawing.Point(259, 208);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(298, 29);
            this.PasswordTBox.TabIndex = 4;
            // 
            // LoginB
            // 
            this.LoginB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginB.Location = new System.Drawing.Point(259, 298);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(88, 50);
            this.LoginB.TabIndex = 5;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // ValidateUserL
            // 
            this.ValidateUserL.AutoSize = true;
            this.ValidateUserL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValidateUserL.Location = new System.Drawing.Point(259, 166);
            this.ValidateUserL.Name = "ValidateUserL";
            this.ValidateUserL.Size = new System.Drawing.Size(45, 32);
            this.ValidateUserL.TabIndex = 6;
            this.ValidateUserL.Text = "Val";
            this.ValidateUserL.Visible = false;
            // 
            // ValidatePassL
            // 
            this.ValidatePassL.AutoSize = true;
            this.ValidatePassL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValidatePassL.Location = new System.Drawing.Point(259, 240);
            this.ValidatePassL.Name = "ValidatePassL";
            this.ValidatePassL.Size = new System.Drawing.Size(45, 32);
            this.ValidatePassL.TabIndex = 7;
            this.ValidatePassL.Text = "Val";
            this.ValidatePassL.Visible = false;
            // 
            // FPassB
            // 
            this.FPassB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FPassB.Location = new System.Drawing.Point(402, 298);
            this.FPassB.Name = "FPassB";
            this.FPassB.Size = new System.Drawing.Size(88, 50);
            this.FPassB.TabIndex = 8;
            this.FPassB.Text = "Forgot Password";
            this.FPassB.UseVisualStyleBackColor = true;
            this.FPassB.Click += new System.EventHandler(this.FPassB_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.FPassB);
            this.Controls.Add(this.ValidatePassL);
            this.Controls.Add(this.ValidateUserL);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UsernameL);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label UsernameL;
        private Label PasswordL;
        private TextBox UsernameTBox;
        private TextBox PasswordTBox;
        private Button LoginB;
        private Label ValidateUserL;
        private Label ValidatePassL;
        private Button FPassB;
    }
}