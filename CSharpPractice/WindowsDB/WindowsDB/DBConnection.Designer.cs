namespace WindowsDB
{
    partial class DBConnection
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountriesCB = new System.Windows.Forms.ComboBox();
            this.SubADD = new System.Windows.Forms.ComboBox();
            this.AreaPDD = new System.Windows.Forms.ComboBox();
            this.FillB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect DB";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // CountriesCB
            // 
            this.CountriesCB.FormattingEnabled = true;
            this.CountriesCB.Location = new System.Drawing.Point(177, 107);
            this.CountriesCB.Name = "CountriesCB";
            this.CountriesCB.Size = new System.Drawing.Size(121, 23);
            this.CountriesCB.TabIndex = 2;
            this.CountriesCB.Text = "Countries";
            // 
            // SubADD
            // 
            this.SubADD.FormattingEnabled = true;
            this.SubADD.Location = new System.Drawing.Point(342, 107);
            this.SubADD.Name = "SubADD";
            this.SubADD.Size = new System.Drawing.Size(121, 23);
            this.SubADD.TabIndex = 4;
            this.SubADD.Text = "Provinces";
            // 
            // AreaPDD
            // 
            this.AreaPDD.FormattingEnabled = true;
            this.AreaPDD.Location = new System.Drawing.Point(519, 107);
            this.AreaPDD.Name = "AreaPDD";
            this.AreaPDD.Size = new System.Drawing.Size(121, 23);
            this.AreaPDD.TabIndex = 5;
            this.AreaPDD.Text = "Cities";
            // 
            // FillB
            // 
            this.FillB.Location = new System.Drawing.Point(330, 239);
            this.FillB.Name = "FillB";
            this.FillB.Size = new System.Drawing.Size(145, 23);
            this.FillB.TabIndex = 6;
            this.FillB.Text = "Fill Drop Down";
            this.FillB.UseVisualStyleBackColor = true;
            this.FillB.Click += new System.EventHandler(this.FillB_Click_1);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FillB);
            this.Controls.Add(this.AreaPDD);
            this.Controls.Add(this.SubADD);
            this.Controls.Add(this.CountriesCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DBConnection";
            this.Text = "DBConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox CountriesCB;
        private ComboBox SubADD;
        private ComboBox AreaPDD;
        private Button FillB;
    }
}