namespace Wielertenue
{
    partial class BestellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingForm));
            this.wielertruiPictureBox = new System.Windows.Forms.PictureBox();
            this.wielertenuePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aantalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.broekCheckBox = new System.Windows.Forms.CheckBox();
            this.superzeemCheckBox = new System.Windows.Forms.CheckBox();
            this.waterdichtZakjeCheckBox = new System.Windows.Forms.CheckBox();
            this.prijsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // wielertruiPictureBox
            // 
            this.wielertruiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertruiPictureBox.Image")));
            this.wielertruiPictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertruiPictureBox.Name = "wielertruiPictureBox";
            this.wielertruiPictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertruiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertruiPictureBox.TabIndex = 0;
            this.wielertruiPictureBox.TabStop = false;
            // 
            // wielertenuePictureBox
            // 
            this.wielertenuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertenuePictureBox.Image")));
            this.wielertenuePictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertenuePictureBox.Name = "wielertenuePictureBox";
            this.wielertenuePictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertenuePictureBox.TabIndex = 0;
            this.wielertenuePictureBox.TabStop = false;
            this.wielertenuePictureBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal";
            // 
            // aantalNumericUpDown
            // 
            this.aantalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantalNumericUpDown.Location = new System.Drawing.Point(467, 23);
            this.aantalNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.aantalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalNumericUpDown.Name = "aantalNumericUpDown";
            this.aantalNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.aantalNumericUpDown.TabIndex = 2;
            this.aantalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalNumericUpDown.ValueChanged += new System.EventHandler(this.aantalNumericUpDown_ValueChanged);
            // 
            // broekCheckBox
            // 
            this.broekCheckBox.AutoSize = true;
            this.broekCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broekCheckBox.Location = new System.Drawing.Point(403, 142);
            this.broekCheckBox.Name = "broekCheckBox";
            this.broekCheckBox.Size = new System.Drawing.Size(200, 28);
            this.broekCheckBox.TabIndex = 3;
            this.broekCheckBox.Text = "inclusief wielerbroek";
            this.broekCheckBox.UseVisualStyleBackColor = true;
            this.broekCheckBox.CheckedChanged += new System.EventHandler(this.broekCheckBox_CheckedChanged);
            // 
            // superzeemCheckBox
            // 
            this.superzeemCheckBox.AutoSize = true;
            this.superzeemCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superzeemCheckBox.Location = new System.Drawing.Point(403, 176);
            this.superzeemCheckBox.Name = "superzeemCheckBox";
            this.superzeemCheckBox.Size = new System.Drawing.Size(124, 28);
            this.superzeemCheckBox.TabIndex = 4;
            this.superzeemCheckBox.Text = "superzeem";
            this.superzeemCheckBox.UseVisualStyleBackColor = true;
            this.superzeemCheckBox.Visible = false;
            this.superzeemCheckBox.CheckedChanged += new System.EventHandler(this.superzeemCheckBox_CheckedChanged);
            // 
            // waterdichtZakjeCheckBox
            // 
            this.waterdichtZakjeCheckBox.AutoSize = true;
            this.waterdichtZakjeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterdichtZakjeCheckBox.Location = new System.Drawing.Point(403, 58);
            this.waterdichtZakjeCheckBox.Name = "waterdichtZakjeCheckBox";
            this.waterdichtZakjeCheckBox.Size = new System.Drawing.Size(166, 28);
            this.waterdichtZakjeCheckBox.TabIndex = 5;
            this.waterdichtZakjeCheckBox.Text = "Waterdicht zakje";
            this.waterdichtZakjeCheckBox.UseVisualStyleBackColor = true;
            this.waterdichtZakjeCheckBox.CheckedChanged += new System.EventHandler(this.waterdichtZakjeCheckBox_CheckedChanged);
            // 
            // prijsTextBox
            // 
            this.prijsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijsTextBox.Location = new System.Drawing.Point(403, 290);
            this.prijsTextBox.Name = "prijsTextBox";
            this.prijsTextBox.Size = new System.Drawing.Size(184, 29);
            this.prijsTextBox.TabIndex = 6;
            this.prijsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BestellingWielertenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 369);
            this.Controls.Add(this.prijsTextBox);
            this.Controls.Add(this.waterdichtZakjeCheckBox);
            this.Controls.Add(this.superzeemCheckBox);
            this.Controls.Add(this.broekCheckBox);
            this.Controls.Add(this.aantalNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wielertenuePictureBox);
            this.Controls.Add(this.wielertruiPictureBox);
            this.Name = "BestellingWielertenueForm";
            this.Text = "BestellingWielertenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wielertruiPictureBox;
        private System.Windows.Forms.PictureBox wielertenuePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown aantalNumericUpDown;
        private System.Windows.Forms.CheckBox broekCheckBox;
        private System.Windows.Forms.CheckBox superzeemCheckBox;
        private System.Windows.Forms.CheckBox waterdichtZakjeCheckBox;
        private System.Windows.Forms.TextBox prijsTextBox;
    }
}