namespace Aftelklok
{
    partial class StartForm
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
            this.minuutAftellenButton = new System.Windows.Forms.Button();
            this.vijfMinutenAftellenButton = new System.Windows.Forms.Button();
            this.aftellenButton = new System.Windows.Forms.Button();
            this.minutenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minutenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // minuutAftellenButton
            // 
            this.minuutAftellenButton.Location = new System.Drawing.Point(20, 20);
            this.minuutAftellenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minuutAftellenButton.Name = "minuutAftellenButton";
            this.minuutAftellenButton.Size = new System.Drawing.Size(176, 35);
            this.minuutAftellenButton.TabIndex = 0;
            this.minuutAftellenButton.Text = "1:00 aftellen";
            this.minuutAftellenButton.UseVisualStyleBackColor = true;
            this.minuutAftellenButton.Click += new System.EventHandler(this.minuutAftellenButton_Click);
            // 
            // vijfMinutenAftellenButton
            // 
            this.vijfMinutenAftellenButton.Location = new System.Drawing.Point(20, 66);
            this.vijfMinutenAftellenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vijfMinutenAftellenButton.Name = "vijfMinutenAftellenButton";
            this.vijfMinutenAftellenButton.Size = new System.Drawing.Size(176, 35);
            this.vijfMinutenAftellenButton.TabIndex = 1;
            this.vijfMinutenAftellenButton.Text = "5:00 aftellen";
            this.vijfMinutenAftellenButton.UseVisualStyleBackColor = true;
            this.vijfMinutenAftellenButton.Click += new System.EventHandler(this.vijfMinutenAftellenButton_Click);
            // 
            // aftellenButton
            // 
            this.aftellenButton.Location = new System.Drawing.Point(20, 210);
            this.aftellenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aftellenButton.Name = "aftellenButton";
            this.aftellenButton.Size = new System.Drawing.Size(176, 35);
            this.aftellenButton.TabIndex = 2;
            this.aftellenButton.Text = "aftellen";
            this.aftellenButton.UseVisualStyleBackColor = true;
            this.aftellenButton.Click += new System.EventHandler(this.aftellenButton_Click);
            // 
            // minutenNumericUpDown
            // 
            this.minutenNumericUpDown.Location = new System.Drawing.Point(20, 170);
            this.minutenNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minutenNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutenNumericUpDown.Name = "minutenNumericUpDown";
            this.minutenNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.minutenNumericUpDown.TabIndex = 3;
            this.minutenNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // secondenNumericUpDown
            // 
            this.secondenNumericUpDown.Location = new System.Drawing.Point(122, 170);
            this.secondenNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondenNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondenNumericUpDown.Name = "secondenNumericUpDown";
            this.secondenNumericUpDown.Size = new System.Drawing.Size(74, 26);
            this.secondenNumericUpDown.TabIndex = 4;
            this.secondenNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "minuten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "seconden";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondenNumericUpDown);
            this.Controls.Add(this.minutenNumericUpDown);
            this.Controls.Add(this.aftellenButton);
            this.Controls.Add(this.vijfMinutenAftellenButton);
            this.Controls.Add(this.minuutAftellenButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.minutenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondenNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minuutAftellenButton;
        private System.Windows.Forms.Button vijfMinutenAftellenButton;
        private System.Windows.Forms.Button aftellenButton;
        private System.Windows.Forms.NumericUpDown minutenNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondenNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}