namespace WindowsDB
{
    partial class ForgotPDemo
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
            this.UECTbox = new System.Windows.Forms.TextBox();
            this.CPCTBox = new System.Windows.Forms.TextBox();
            this.PCTBox = new System.Windows.Forms.TextBox();
            this.CPButton = new System.Windows.Forms.Button();
            this.UECLabel = new System.Windows.Forms.Label();
            this.PCLabel = new System.Windows.Forms.Label();
            this.CPCLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UECTbox
            // 
            this.UECTbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UECTbox.Location = new System.Drawing.Point(310, 115);
            this.UECTbox.Name = "UECTbox";
            this.UECTbox.Size = new System.Drawing.Size(255, 29);
            this.UECTbox.TabIndex = 0;
            // 
            // CPCTBox
            // 
            this.CPCTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPCTBox.Location = new System.Drawing.Point(310, 256);
            this.CPCTBox.Name = "CPCTBox";
            this.CPCTBox.Size = new System.Drawing.Size(255, 29);
            this.CPCTBox.TabIndex = 1;
            // 
            // PCTBox
            // 
            this.PCTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PCTBox.Location = new System.Drawing.Point(310, 185);
            this.PCTBox.Name = "PCTBox";
            this.PCTBox.Size = new System.Drawing.Size(255, 29);
            this.PCTBox.TabIndex = 2;
            // 
            // CPButton
            // 
            this.CPButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPButton.Location = new System.Drawing.Point(310, 339);
            this.CPButton.Name = "CPButton";
            this.CPButton.Size = new System.Drawing.Size(232, 35);
            this.CPButton.TabIndex = 3;
            this.CPButton.Text = "Change Password";
            this.CPButton.UseVisualStyleBackColor = true;
            this.CPButton.Click += new System.EventHandler(this.CPButton_Click);
            // 
            // UECLabel
            // 
            this.UECLabel.AutoSize = true;
            this.UECLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UECLabel.Location = new System.Drawing.Point(151, 115);
            this.UECLabel.Name = "UECLabel";
            this.UECLabel.Size = new System.Drawing.Size(97, 25);
            this.UECLabel.TabIndex = 4;
            this.UECLabel.Text = "Username";
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PCLabel.Location = new System.Drawing.Point(132, 189);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(134, 25);
            this.PCLabel.TabIndex = 5;
            this.PCLabel.Text = "New Password";

            // 
            // CPCLabel
            // 
            this.CPCLabel.AutoSize = true;
            this.CPCLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPCLabel.Location = new System.Drawing.Point(120, 260);
            this.CPCLabel.Name = "CPCLabel";
            this.CPCLabel.Size = new System.Drawing.Size(161, 25);
            this.CPCLabel.TabIndex = 6;
            this.CPCLabel.Text = "Change Password";
            // 
            // ForgotPDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CPCLabel);
            this.Controls.Add(this.PCLabel);
            this.Controls.Add(this.UECLabel);
            this.Controls.Add(this.CPButton);
            this.Controls.Add(this.PCTBox);
            this.Controls.Add(this.CPCTBox);
            this.Controls.Add(this.UECTbox);
            this.Name = "ForgotPDemo";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UECTbox;
        private TextBox CPCTBox;
        private TextBox PCTBox;
        private Button CPButton;
        private Label UECLabel;
        private Label PCLabel;
        private Label CPCLabel;
    }
}