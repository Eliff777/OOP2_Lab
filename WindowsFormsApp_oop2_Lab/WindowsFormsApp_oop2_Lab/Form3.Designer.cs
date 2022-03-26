namespace WindowsFormsApp_oop2_Lab
{
    partial class Form3
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
            this.Shape = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.CheckBox();
            this.Triangle = new System.Windows.Forms.CheckBox();
            this.Round = new System.Windows.Forms.CheckBox();
            this.difficulty = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Custom = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Shape
            // 
            this.Shape.AutoSize = true;
            this.Shape.Location = new System.Drawing.Point(54, 21);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(49, 17);
            this.Shape.TabIndex = 0;
            this.Shape.Text = "Shape";
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(57, 59);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(76, 21);
            this.Square.TabIndex = 1;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(57, 87);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(82, 21);
            this.Triangle.TabIndex = 2;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Location = new System.Drawing.Point(57, 115);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(72, 21);
            this.Round.TabIndex = 3;
            this.Round.Text = "Round";
            this.Round.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Location = new System.Drawing.Point(319, 21);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(61, 17);
            this.difficulty.TabIndex = 4;
            this.difficulty.Text = "Difficulty";
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Location = new System.Drawing.Point(322, 59);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(60, 21);
            this.Easy.TabIndex = 5;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(322, 87);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(74, 21);
            this.Normal.TabIndex = 6;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(322, 115);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(60, 21);
            this.Hard.TabIndex = 7;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Location = new System.Drawing.Point(322, 143);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(76, 21);
            this.Custom.TabIndex = 8;
            this.Custom.TabStop = true;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 22);
            this.textBox2.TabIndex = 10;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(483, 226);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 31);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Shape);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Shape;
        private System.Windows.Forms.CheckBox Square;
        private System.Windows.Forms.CheckBox Triangle;
        private System.Windows.Forms.CheckBox Round;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Custom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button save;
    }
}