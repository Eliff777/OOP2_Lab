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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.colour = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.CheckBox();
            this.blue = new System.Windows.Forms.CheckBox();
            this.yellow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shape
            // 
            this.Shape.AutoSize = true;
            this.Shape.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shape.Location = new System.Drawing.Point(53, 39);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(58, 20);
            this.Shape.TabIndex = 0;
            this.Shape.Text = "Shape";
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square.Location = new System.Drawing.Point(56, 72);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(88, 24);
            this.Square.TabIndex = 1;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.CheckedChanged += new System.EventHandler(this.Square_CheckedChanged);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Triangle.Location = new System.Drawing.Point(57, 102);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(101, 24);
            this.Triangle.TabIndex = 2;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round.Location = new System.Drawing.Point(57, 132);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(87, 24);
            this.Round.TabIndex = 3;
            this.Round.Text = "Round";
            this.Round.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulty.Location = new System.Drawing.Point(240, 39);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(91, 20);
            this.difficulty.TabIndex = 4;
            this.difficulty.Text = "Difficulty";
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.Location = new System.Drawing.Point(248, 71);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(68, 24);
            this.Easy.TabIndex = 5;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.CheckedChanged += new System.EventHandler(this.Easy_CheckedChanged);
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal.Location = new System.Drawing.Point(248, 101);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(95, 24);
            this.Normal.TabIndex = 6;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.CheckedChanged += new System.EventHandler(this.Normal_CheckedChanged);
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard.Location = new System.Drawing.Point(248, 131);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(72, 24);
            this.Hard.TabIndex = 7;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.CheckedChanged += new System.EventHandler(this.Hard_CheckedChanged);
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custom.Location = new System.Drawing.Point(248, 161);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(98, 24);
            this.Custom.TabIndex = 8;
            this.Custom.TabStop = true;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(244, 204);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(76, 22);
            this.input1.TabIndex = 9;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(326, 204);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(74, 22);
            this.input2.TabIndex = 10;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ImageKey = "(none)";
            this.save.Location = new System.Drawing.Point(541, 204);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(86, 40);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // colour
            // 
            this.colour.AutoSize = true;
            this.colour.Location = new System.Drawing.Point(505, 41);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(47, 17);
            this.colour.TabIndex = 12;
            this.colour.Text = "colour";
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(508, 71);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(51, 21);
            this.red.TabIndex = 13;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(508, 104);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(57, 21);
            this.blue.TabIndex = 14;
            this.blue.Text = "blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.Location = new System.Drawing.Point(508, 134);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(68, 21);
            this.yellow.TabIndex = 15;
            this.yellow.Text = "yellow";
            this.yellow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.colour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
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
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label colour;
        private System.Windows.Forms.CheckBox red;
        private System.Windows.Forms.CheckBox blue;
        private System.Windows.Forms.CheckBox yellow;
        private System.Windows.Forms.Label label1;
    }
}