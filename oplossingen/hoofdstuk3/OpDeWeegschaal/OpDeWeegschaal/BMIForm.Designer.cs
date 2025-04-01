namespace OpDeWeegschaal
{
    partial class BMIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grootteTextBox = new System.Windows.Forms.TextBox();
            this.gewichtTextBox = new System.Windows.Forms.TextBox();
            this.bmiTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.KiloErafButton = new System.Windows.Forms.Button();
            this.KiloErbijButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 277);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "grootte (in meter)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "gewicht (in kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "bmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "status";
            // 
            // grootteTextBox
            // 
            this.grootteTextBox.Location = new System.Drawing.Point(187, 52);
            this.grootteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.grootteTextBox.Name = "grootteTextBox";
            this.grootteTextBox.ReadOnly = true;
            this.grootteTextBox.Size = new System.Drawing.Size(132, 26);
            this.grootteTextBox.TabIndex = 5;
            this.grootteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gewichtTextBox
            // 
            this.gewichtTextBox.Location = new System.Drawing.Point(187, 86);
            this.gewichtTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gewichtTextBox.Name = "gewichtTextBox";
            this.gewichtTextBox.ReadOnly = true;
            this.gewichtTextBox.Size = new System.Drawing.Size(132, 26);
            this.gewichtTextBox.TabIndex = 6;
            this.gewichtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmiTextBox
            // 
            this.bmiTextBox.Location = new System.Drawing.Point(187, 161);
            this.bmiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bmiTextBox.Name = "bmiTextBox";
            this.bmiTextBox.ReadOnly = true;
            this.bmiTextBox.Size = new System.Drawing.Size(132, 26);
            this.bmiTextBox.TabIndex = 7;
            this.bmiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(187, 195);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(132, 26);
            this.statusTextBox.TabIndex = 8;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KiloErafButton
            // 
            this.KiloErafButton.Location = new System.Drawing.Point(164, 86);
            this.KiloErafButton.Margin = new System.Windows.Forms.Padding(4);
            this.KiloErafButton.Name = "KiloErafButton";
            this.KiloErafButton.Size = new System.Drawing.Size(27, 26);
            this.KiloErafButton.TabIndex = 9;
            this.KiloErafButton.Text = "-";
            this.KiloErafButton.UseVisualStyleBackColor = true;
            this.KiloErafButton.Click += new System.EventHandler(this.KiloErafButton_Click);
            // 
            // KiloErbijButton
            // 
            this.KiloErbijButton.Location = new System.Drawing.Point(316, 86);
            this.KiloErbijButton.Margin = new System.Windows.Forms.Padding(4);
            this.KiloErbijButton.Name = "KiloErbijButton";
            this.KiloErbijButton.Size = new System.Drawing.Size(27, 26);
            this.KiloErbijButton.TabIndex = 10;
            this.KiloErbijButton.Text = "+";
            this.KiloErbijButton.UseVisualStyleBackColor = true;
            this.KiloErbijButton.Click += new System.EventHandler(this.KiloErbijButton_Click);
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 277);
            this.Controls.Add(this.KiloErbijButton);
            this.Controls.Add(this.KiloErafButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.bmiTextBox);
            this.Controls.Add(this.gewichtTextBox);
            this.Controls.Add(this.grootteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BMIForm";
            this.Text = "BMIForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grootteTextBox;
        private System.Windows.Forms.TextBox gewichtTextBox;
        private System.Windows.Forms.TextBox bmiTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button KiloErafButton;
        private System.Windows.Forms.Button KiloErbijButton;
    }
}

