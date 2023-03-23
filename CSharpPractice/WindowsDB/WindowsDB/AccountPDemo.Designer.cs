namespace WindowsDB
{
    partial class AccountPDemo
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
            this.DeleteAB = new System.Windows.Forms.Button();
            this.LogoutB = new System.Windows.Forms.Button();
            this.AccountL = new System.Windows.Forms.Label();
            this.AIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteAB
            // 
            this.DeleteAB.Location = new System.Drawing.Point(166, 253);
            this.DeleteAB.Name = "DeleteAB";
            this.DeleteAB.Size = new System.Drawing.Size(144, 53);
            this.DeleteAB.TabIndex = 0;
            this.DeleteAB.Text = "Delete Account";
            this.DeleteAB.UseVisualStyleBackColor = true;
            this.DeleteAB.Click += new System.EventHandler(this.DeleteAB_Click);
            // 
            // LogoutB
            // 
            this.LogoutB.Location = new System.Drawing.Point(451, 253);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(144, 53);
            this.LogoutB.TabIndex = 1;
            this.LogoutB.Text = "Logout Account";
            this.LogoutB.UseVisualStyleBackColor = true;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // AccountL
            // 
            this.AccountL.AutoSize = true;
            this.AccountL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountL.Location = new System.Drawing.Point(324, 92);
            this.AccountL.Name = "AccountL";
            this.AccountL.Size = new System.Drawing.Size(81, 25);
            this.AccountL.TabIndex = 2;
            this.AccountL.Text = "Account";
            // 
            // AIDLabel
            // 
            this.AIDLabel.AutoSize = true;
            this.AIDLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AIDLabel.Location = new System.Drawing.Point(324, 149);
            this.AIDLabel.Name = "AIDLabel";
            this.AIDLabel.Size = new System.Drawing.Size(104, 25);
            this.AIDLabel.TabIndex = 3;
            this.AIDLabel.Text = "Account ID";
            // 
            // AccountPDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AIDLabel);
            this.Controls.Add(this.AccountL);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.DeleteAB);
            this.Name = "AccountPDemo";
            this.Text = "AccountPDemo";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteAB;
        private Button LogoutB;
        private Label AccountL;
        private Label AIDLabel;
    }
}