namespace WindowsDB
{
    partial class LoginDemo
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
            this.PassLogTBox = new System.Windows.Forms.TextBox();
            this.UELogTBox = new System.Windows.Forms.TextBox();
            this.PLogL = new System.Windows.Forms.Label();
            this.UELogL = new System.Windows.Forms.Label();
            this.LoginB = new System.Windows.Forms.Button();
            this.NewAB = new System.Windows.Forms.Button();
            this.ForgotPB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassLogTBox
            // 
            this.PassLogTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLogTBox.Location = new System.Drawing.Point(315, 187);
            this.PassLogTBox.Name = "PassLogTBox";
            this.PassLogTBox.Size = new System.Drawing.Size(248, 29);
            this.PassLogTBox.TabIndex = 8;
            // 
            // UELogTBox
            // 
            this.UELogTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UELogTBox.Location = new System.Drawing.Point(315, 89);
            this.UELogTBox.Name = "UELogTBox";
            this.UELogTBox.Size = new System.Drawing.Size(248, 29);
            this.UELogTBox.TabIndex = 7;
            // 
            // PLogL
            // 
            this.PLogL.AutoSize = true;
            this.PLogL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PLogL.Location = new System.Drawing.Point(144, 187);
            this.PLogL.Name = "PLogL";
            this.PLogL.Size = new System.Drawing.Size(91, 25);
            this.PLogL.TabIndex = 6;
            this.PLogL.Text = "Password";
            // 
            // UELogL
            // 
            this.UELogL.AutoSize = true;
            this.UELogL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UELogL.Location = new System.Drawing.Point(144, 89);
            this.UELogL.Name = "UELogL";
            this.UELogL.Size = new System.Drawing.Size(150, 25);
            this.UELogL.TabIndex = 5;
            this.UELogL.Text = "Username/Email";
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(315, 283);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(128, 50);
            this.LoginB.TabIndex = 7;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click_1);
            // 
            // NewAB
            // 
            this.NewAB.Location = new System.Drawing.Point(144, 283);
            this.NewAB.Name = "NewAB";
            this.NewAB.Size = new System.Drawing.Size(128, 50);
            this.NewAB.TabIndex = 9;
            this.NewAB.Text = "New Account";
            this.NewAB.UseVisualStyleBackColor = true;
            this.NewAB.Click += new System.EventHandler(this.NewAB_Click);
            // 
            // ForgotPB
            // 
            this.ForgotPB.Location = new System.Drawing.Point(500, 283);
            this.ForgotPB.Name = "ForgotPB";
            this.ForgotPB.Size = new System.Drawing.Size(128, 50);
            this.ForgotPB.TabIndex = 10;
            this.ForgotPB.Text = "Forgot Password";
            this.ForgotPB.UseVisualStyleBackColor = true;
            this.ForgotPB.Click += new System.EventHandler(this.ForgotPB_Click);
            // 
            // LoginDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ForgotPB);
            this.Controls.Add(this.NewAB);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.PassLogTBox);
            this.Controls.Add(this.UELogTBox);
            this.Controls.Add(this.PLogL);
            this.Controls.Add(this.UELogL);
            this.Name = "LoginDemo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PassLogTBox;
        private TextBox UELogTBox;
        private Label PLogL;
        private Label UELogL;
        private Button LoginB;
        private Button NewAB;
        private Button ForgotPB;
    }
}