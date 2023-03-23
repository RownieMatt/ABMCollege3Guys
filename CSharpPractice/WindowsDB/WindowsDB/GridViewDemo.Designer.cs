namespace WindowsDB
{
    partial class GridViewDemo
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
            this.AccountG = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserNL = new System.Windows.Forms.Label();
            this.SearchL = new System.Windows.Forms.Label();
            this.UsernameTBox = new System.Windows.Forms.TextBox();
            this.SearchTBox = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.ResetB = new System.Windows.Forms.Button();
            this.AgeTBox = new System.Windows.Forms.TextBox();
            this.AgeL = new System.Windows.Forms.Label();
            this.GenderTBox = new System.Windows.Forms.TextBox();
            this.GenderL = new System.Windows.Forms.Label();
            this.SalaryTBox = new System.Windows.Forms.TextBox();
            this.SalaryL = new System.Windows.Forms.Label();
            this.TeamLTBox = new System.Windows.Forms.TextBox();
            this.TLeadL = new System.Windows.Forms.Label();
            this.DesignTBox = new System.Windows.Forms.TextBox();
            this.DesignationL = new System.Windows.Forms.Label();
            this.InsertB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountG)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountG
            // 
            this.AccountG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.AccountG.Location = new System.Drawing.Point(6, 310);
            this.AccountG.Name = "AccountG";
            this.AccountG.RowTemplate.Height = 25;
            this.AccountG.Size = new System.Drawing.Size(839, 219);
            this.AccountG.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserNL
            // 
            this.UserNL.AutoSize = true;
            this.UserNL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNL.Location = new System.Drawing.Point(12, 22);
            this.UserNL.Name = "UserNL";
            this.UserNL.Size = new System.Drawing.Size(62, 25);
            this.UserNL.TabIndex = 1;
            this.UserNL.Text = "Name";
            this.UserNL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchL.Location = new System.Drawing.Point(373, 227);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(69, 25);
            this.SearchL.TabIndex = 2;
            this.SearchL.Text = "Search";
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTBox.Location = new System.Drawing.Point(94, 22);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(216, 29);
            this.UsernameTBox.TabIndex = 3;
            // 
            // SearchTBox
            // 
            this.SearchTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTBox.Location = new System.Drawing.Point(448, 227);
            this.SearchTBox.Name = "SearchTBox";
            this.SearchTBox.Size = new System.Drawing.Size(131, 29);
            this.SearchTBox.TabIndex = 4;
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(471, 262);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 23);
            this.SearchB.TabIndex = 5;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ResetB
            // 
            this.ResetB.Location = new System.Drawing.Point(12, 281);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(75, 23);
            this.ResetB.TabIndex = 6;
            this.ResetB.Text = "Reset Table";
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.ResetB_Click);
            // 
            // AgeTBox
            // 
            this.AgeTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeTBox.Location = new System.Drawing.Point(94, 80);
            this.AgeTBox.Name = "AgeTBox";
            this.AgeTBox.Size = new System.Drawing.Size(216, 29);
            this.AgeTBox.TabIndex = 10;
            // 
            // AgeL
            // 
            this.AgeL.AutoSize = true;
            this.AgeL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeL.Location = new System.Drawing.Point(12, 80);
            this.AgeL.Name = "AgeL";
            this.AgeL.Size = new System.Drawing.Size(45, 25);
            this.AgeL.TabIndex = 9;
            this.AgeL.Text = "Age";
            this.AgeL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenderTBox
            // 
            this.GenderTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderTBox.Location = new System.Drawing.Point(94, 133);
            this.GenderTBox.Name = "GenderTBox";
            this.GenderTBox.Size = new System.Drawing.Size(38, 29);
            this.GenderTBox.TabIndex = 12;
            // 
            // GenderL
            // 
            this.GenderL.AutoSize = true;
            this.GenderL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderL.Location = new System.Drawing.Point(12, 133);
            this.GenderL.Name = "GenderL";
            this.GenderL.Size = new System.Drawing.Size(74, 25);
            this.GenderL.TabIndex = 11;
            this.GenderL.Text = "Gender";
            this.GenderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalaryTBox
            // 
            this.SalaryTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryTBox.Location = new System.Drawing.Point(94, 179);
            this.SalaryTBox.Name = "SalaryTBox";
            this.SalaryTBox.Size = new System.Drawing.Size(216, 29);
            this.SalaryTBox.TabIndex = 14;
            // 
            // SalaryL
            // 
            this.SalaryL.AutoSize = true;
            this.SalaryL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryL.Location = new System.Drawing.Point(12, 179);
            this.SalaryL.Name = "SalaryL";
            this.SalaryL.Size = new System.Drawing.Size(63, 25);
            this.SalaryL.TabIndex = 13;
            this.SalaryL.Text = "Salary";
            this.SalaryL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamLTBox
            // 
            this.TeamLTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamLTBox.Location = new System.Drawing.Point(448, 22);
            this.TeamLTBox.Name = "TeamLTBox";
            this.TeamLTBox.Size = new System.Drawing.Size(216, 29);
            this.TeamLTBox.TabIndex = 16;
            // 
            // TLeadL
            // 
            this.TLeadL.AutoSize = true;
            this.TLeadL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TLeadL.Location = new System.Drawing.Point(347, 22);
            this.TLeadL.Name = "TLeadL";
            this.TLeadL.Size = new System.Drawing.Size(101, 25);
            this.TLeadL.TabIndex = 15;
            this.TLeadL.Text = "Team Lead";
            this.TLeadL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesignTBox
            // 
            this.DesignTBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DesignTBox.Location = new System.Drawing.Point(131, 231);
            this.DesignTBox.Name = "DesignTBox";
            this.DesignTBox.Size = new System.Drawing.Size(216, 29);
            this.DesignTBox.TabIndex = 18;
            // 
            // DesignationL
            // 
            this.DesignationL.AutoSize = true;
            this.DesignationL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DesignationL.Location = new System.Drawing.Point(12, 231);
            this.DesignationL.Name = "DesignationL";
            this.DesignationL.Size = new System.Drawing.Size(113, 25);
            this.DesignationL.TabIndex = 17;
            this.DesignationL.Text = "Designation";
            this.DesignationL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertB
            // 
            this.InsertB.Location = new System.Drawing.Point(131, 281);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(170, 23);
            this.InsertB.TabIndex = 19;
            this.InsertB.Text = "Insert Employee";
            this.InsertB.UseVisualStyleBackColor = true;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // GridViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 556);
            this.Controls.Add(this.InsertB);
            this.Controls.Add(this.DesignTBox);
            this.Controls.Add(this.DesignationL);
            this.Controls.Add(this.TeamLTBox);
            this.Controls.Add(this.TLeadL);
            this.Controls.Add(this.SalaryTBox);
            this.Controls.Add(this.SalaryL);
            this.Controls.Add(this.GenderTBox);
            this.Controls.Add(this.GenderL);
            this.Controls.Add(this.AgeTBox);
            this.Controls.Add(this.AgeL);
            this.Controls.Add(this.ResetB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.SearchTBox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.SearchL);
            this.Controls.Add(this.UserNL);
            this.Controls.Add(this.AccountG);
            this.Name = "GridViewDemo";
            this.Text = "GridViewDemo";
            this.Load += new System.EventHandler(this.GridViewDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewCheckBoxColumn Column1;
        private DataGridView AccountG;
        private DataGridViewCheckBoxColumn Select;
        private Label UserNL;
        private Label SearchL;
        private TextBox UsernameTBox;
        private TextBox SearchTBox;
        private Button SearchB;
        private Button ResetB;
        private TextBox AgeTBox;
        private Label AgeL;
        private TextBox GenderTBox;
        private Label GenderL;
        private TextBox SalaryTBox;
        private Label SalaryL;
        private TextBox TeamLTBox;
        private Label TLeadL;
        private TextBox DesignTBox;
        private Label DesignationL;
        private Button InsertB;
    }
}