namespace WindowsDB
{
    partial class RegisterDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.EmailL = new System.Windows.Forms.Label();
            this.UserNTBox = new System.Windows.Forms.TextBox();
            this.EmailTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.RegisterB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameL
            // 
            this.UsernameL.AutoSize = true;
            this.UsernameL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameL.Location = new System.Drawing.Point(131, 103);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(97, 25);
            this.UsernameL.TabIndex = 0;
            this.UsernameL.Text = "Username";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordL.Location = new System.Drawing.Point(131, 290);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(91, 25);
            this.PasswordL.TabIndex = 1;
            this.PasswordL.Text = "Password";
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailL.Location = new System.Drawing.Point(131, 201);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(58, 25);
            this.EmailL.TabIndex = 2;
            this.EmailL.Text = "Email";
            // 
            // UserNTBox
            // 
            this.UserNTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNTBox.Location = new System.Drawing.Point(302, 103);
            this.UserNTBox.Name = "UserNTBox";
            this.UserNTBox.Size = new System.Drawing.Size(248, 29);
            this.UserNTBox.TabIndex = 3;
            // 
            // EmailTBox
            // 
            this.EmailTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTBox.Location = new System.Drawing.Point(302, 201);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.Size = new System.Drawing.Size(248, 29);
            this.EmailTBox.TabIndex = 4;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTBox.Location = new System.Drawing.Point(302, 290);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(248, 29);
            this.PasswordTBox.TabIndex = 5;
            // 
            // RegisterB
            // 
            this.RegisterB.Location = new System.Drawing.Point(347, 356);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(128, 50);
            this.RegisterB.TabIndex = 6;
            this.RegisterB.Text = "Register ";
            this.RegisterB.UseVisualStyleBackColor = true;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
            // 
            // RegisterDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.EmailTBox);
            this.Controls.Add(this.UserNTBox);
            this.Controls.Add(this.EmailL);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UsernameL);
            this.Name = "RegisterDemo";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UsernameL;
        private Label PasswordL;
        private Label EmailL;
        private TextBox UserNTBox;
        private TextBox EmailTBox;
        private TextBox PasswordTBox;
        private Button RegisterB;
    }
}