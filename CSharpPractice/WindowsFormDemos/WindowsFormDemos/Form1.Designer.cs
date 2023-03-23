namespace WindowsFormDemos
{
    partial class Form1
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
            this.CountriesCB = new System.Windows.Forms.ComboBox();
            this.ProvincesCB = new System.Windows.Forms.ComboBox();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountriesCB
            // 
            this.CountriesCB.AllowDrop = true;
            this.CountriesCB.FormattingEnabled = true;
            this.CountriesCB.Items.AddRange(new object[] {
            "Canada",
            "USA",
            "Spain",
            "Germany"});
            this.CountriesCB.Location = new System.Drawing.Point(89, 101);
            this.CountriesCB.Name = "CountriesCB";
            this.CountriesCB.Size = new System.Drawing.Size(121, 23);
            this.CountriesCB.TabIndex = 0;
            this.CountriesCB.Text = "Countries";
            this.CountriesCB.SelectedIndexChanged += new System.EventHandler(this.CountriesCB_SelectedIndexChanged);
            // 
            // ProvincesCB
            // 
            this.ProvincesCB.FormattingEnabled = true;
            this.ProvincesCB.Location = new System.Drawing.Point(323, 101);
            this.ProvincesCB.Name = "ProvincesCB";
            this.ProvincesCB.Size = new System.Drawing.Size(121, 23);
            this.ProvincesCB.TabIndex = 1;
            this.ProvincesCB.Text = "Provinces";
            this.ProvincesCB.SelectedIndexChanged += new System.EventHandler(this.ProvincesCB_SelectedIndexChanged);
            // 
            // CityCB
            // 
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(555, 101);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(121, 23);
            this.CityCB.TabIndex = 2;
            this.CityCB.Text = "Cities";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CityCB);
            this.Controls.Add(this.ProvincesCB);
            this.Controls.Add(this.CountriesCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox CountriesCB;
        private ComboBox ProvincesCB;
        private ComboBox CityCB;
        private Button button1;
    }
}