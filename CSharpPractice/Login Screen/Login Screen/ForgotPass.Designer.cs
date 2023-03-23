namespace Login_Screen
{
    partial class ForgotPass
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
            this.NewPassL = new System.Windows.Forms.Label();
            this.ConfirmPL = new System.Windows.Forms.Label();
            this.UsernameTBox = new System.Windows.Forms.TextBox();
            this.NewPTBox = new System.Windows.Forms.TextBox();
            this.ConfirmPTBox = new System.Windows.Forms.TextBox();
            this.MakeNewPB = new System.Windows.Forms.Button();
            this.NPValidL = new System.Windows.Forms.Label();
            this.CPValidL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameL
            // 
            this.UsernameL.AutoSize = true;
            this.UsernameL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameL.Location = new System.Drawing.Point(84, 94);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(97, 25);
            this.UsernameL.TabIndex = 0;
            this.UsernameL.Text = "Username";
            // 
            // NewPassL
            // 
            this.NewPassL.AutoSize = true;
            this.NewPassL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPassL.Location = new System.Drawing.Point(64, 186);
            this.NewPassL.Name = "NewPassL";
            this.NewPassL.Size = new System.Drawing.Size(134, 25);
            this.NewPassL.TabIndex = 1;
            this.NewPassL.Text = "New Password";
            // 
            // ConfirmPL
            // 
            this.ConfirmPL.AutoSize = true;
            this.ConfirmPL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPL.Location = new System.Drawing.Point(43, 276);
            this.ConfirmPL.Name = "ConfirmPL";
            this.ConfirmPL.Size = new System.Drawing.Size(164, 25);
            this.ConfirmPL.TabIndex = 2;
            this.ConfirmPL.Text = "Confirm Password";
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTBox.Location = new System.Drawing.Point(213, 91);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.ReadOnly = true;
            this.UsernameTBox.Size = new System.Drawing.Size(265, 33);
            this.UsernameTBox.TabIndex = 3;
            // 
            // NewPTBox
            // 
            this.NewPTBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPTBox.Location = new System.Drawing.Point(213, 183);
            this.NewPTBox.Name = "NewPTBox";
            this.NewPTBox.Size = new System.Drawing.Size(265, 33);
            this.NewPTBox.TabIndex = 4;
            // 
            // ConfirmPTBox
            // 
            this.ConfirmPTBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPTBox.Location = new System.Drawing.Point(213, 273);
            this.ConfirmPTBox.Name = "ConfirmPTBox";
            this.ConfirmPTBox.Size = new System.Drawing.Size(265, 33);
            this.ConfirmPTBox.TabIndex = 5;
            // 
            // MakeNewPB
            // 
            this.MakeNewPB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeNewPB.Location = new System.Drawing.Point(271, 363);
            this.MakeNewPB.Name = "MakeNewPB";
            this.MakeNewPB.Size = new System.Drawing.Size(134, 64);
            this.MakeNewPB.TabIndex = 6;
            this.MakeNewPB.Text = "Make New Password";
            this.MakeNewPB.UseVisualStyleBackColor = true;
            this.MakeNewPB.Click += new System.EventHandler(this.MakeNewPB_Click);
            // 
            // NPValidL
            // 
            this.NPValidL.AutoSize = true;
            this.NPValidL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NPValidL.Location = new System.Drawing.Point(213, 237);
            this.NPValidL.Name = "NPValidL";
            this.NPValidL.Size = new System.Drawing.Size(52, 21);
            this.NPValidL.TabIndex = 8;
            this.NPValidL.Text = "label2";
            // 
            // CPValidL
            // 
            this.CPValidL.AutoSize = true;
            this.CPValidL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPValidL.Location = new System.Drawing.Point(213, 324);
            this.CPValidL.Name = "CPValidL";
            this.CPValidL.Size = new System.Drawing.Size(52, 21);
            this.CPValidL.TabIndex = 9;
            this.CPValidL.Text = "label3";
            this.CPValidL.Visible = false;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CPValidL);
            this.Controls.Add(this.NPValidL);
            this.Controls.Add(this.MakeNewPB);
            this.Controls.Add(this.ConfirmPTBox);
            this.Controls.Add(this.NewPTBox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.ConfirmPL);
            this.Controls.Add(this.NewPassL);
            this.Controls.Add(this.UsernameL);
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UsernameL;
        private Label NewPassL;
        private Label ConfirmPL;
        private TextBox UsernameTBox;
        private TextBox NewPTBox;
        private TextBox ConfirmPTBox;
        private Button MakeNewPB;
        private Label CPValidL;
        public Label NPValidL;
    }
}