namespace DemoNet
{
    partial class Form1
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
            this.FirstVLabel = new System.Windows.Forms.Label();
            this.FirstVTBox = new System.Windows.Forms.TextBox();
            this.SecondVTBox = new System.Windows.Forms.TextBox();
            this.SecondVLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AddB = new System.Windows.Forms.Button();
            this.SubtractB = new System.Windows.Forms.Button();
            this.DivideB = new System.Windows.Forms.Button();
            this.MultiplyB = new System.Windows.Forms.Button();
            this.ModuloB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstVLabel
            // 
            this.FirstVLabel.AutoSize = true;
            this.FirstVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstVLabel.Location = new System.Drawing.Point(56, 53);
            this.FirstVLabel.Name = "FirstVLabel";
            this.FirstVLabel.Size = new System.Drawing.Size(76, 20);
            this.FirstVLabel.TabIndex = 0;
            this.FirstVLabel.Text = "1st Value";
            // 
            // FirstVTBox
            // 
            this.FirstVTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstVTBox.Location = new System.Drawing.Point(138, 50);
            this.FirstVTBox.Name = "FirstVTBox";
            this.FirstVTBox.Size = new System.Drawing.Size(231, 26);
            this.FirstVTBox.TabIndex = 1;
            // 
            // SecondVTBox
            // 
            this.SecondVTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondVTBox.Location = new System.Drawing.Point(138, 94);
            this.SecondVTBox.Name = "SecondVTBox";
            this.SecondVTBox.Size = new System.Drawing.Size(231, 26);
            this.SecondVTBox.TabIndex = 2;
            // 
            // SecondVLabel
            // 
            this.SecondVLabel.AutoSize = true;
            this.SecondVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondVLabel.Location = new System.Drawing.Point(56, 97);
            this.SecondVLabel.Name = "SecondVLabel";
            this.SecondVLabel.Size = new System.Drawing.Size(81, 20);
            this.SecondVLabel.TabIndex = 3;
            this.SecondVLabel.Text = "2nd Value";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(180, 139);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(112, 31);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.Text = "Solution";
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddB.Location = new System.Drawing.Point(60, 188);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(104, 29);
            this.AddB.TabIndex = 5;
            this.AddB.Text = "Add(+)";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SubtractB
            // 
            this.SubtractB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractB.Location = new System.Drawing.Point(186, 188);
            this.SubtractB.Name = "SubtractB";
            this.SubtractB.Size = new System.Drawing.Size(106, 29);
            this.SubtractB.TabIndex = 6;
            this.SubtractB.Text = "Subtract(-)";
            this.SubtractB.UseVisualStyleBackColor = true;
            this.SubtractB.Click += new System.EventHandler(this.SubtractB_Click);
            // 
            // DivideB
            // 
            this.DivideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideB.Location = new System.Drawing.Point(313, 188);
            this.DivideB.Name = "DivideB";
            this.DivideB.Size = new System.Drawing.Size(102, 29);
            this.DivideB.TabIndex = 7;
            this.DivideB.Text = "Divide(/)";
            this.DivideB.UseVisualStyleBackColor = true;
            // 
            // MultiplyB
            // 
            this.MultiplyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyB.Location = new System.Drawing.Point(186, 240);
            this.MultiplyB.Name = "MultiplyB";
            this.MultiplyB.Size = new System.Drawing.Size(106, 29);
            this.MultiplyB.TabIndex = 8;
            this.MultiplyB.Text = "Multiply(*)";
            this.MultiplyB.UseVisualStyleBackColor = true;
            // 
            // ModuloB
            // 
            this.ModuloB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuloB.Location = new System.Drawing.Point(60, 240);
            this.ModuloB.Name = "ModuloB";
            this.ModuloB.Size = new System.Drawing.Size(104, 29);
            this.ModuloB.TabIndex = 9;
            this.ModuloB.Text = "Remainder";
            this.ModuloB.UseVisualStyleBackColor = true;
            // 
            // ClearB
            // 
            this.ClearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearB.Location = new System.Drawing.Point(313, 240);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(102, 29);
            this.ClearB.TabIndex = 10;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 315);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ModuloB);
            this.Controls.Add(this.MultiplyB);
            this.Controls.Add(this.DivideB);
            this.Controls.Add(this.SubtractB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.SecondVLabel);
            this.Controls.Add(this.SecondVTBox);
            this.Controls.Add(this.FirstVTBox);
            this.Controls.Add(this.FirstVLabel);
            this.Name = "Form1";
            this.Text = "Calculator Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstVLabel;
        private System.Windows.Forms.TextBox FirstVTBox;
        private System.Windows.Forms.TextBox SecondVTBox;
        private System.Windows.Forms.Label SecondVLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button SubtractB;
        private System.Windows.Forms.Button DivideB;
        private System.Windows.Forms.Button MultiplyB;
        private System.Windows.Forms.Button ModuloB;
        private System.Windows.Forms.Button ClearB;
    }
}

