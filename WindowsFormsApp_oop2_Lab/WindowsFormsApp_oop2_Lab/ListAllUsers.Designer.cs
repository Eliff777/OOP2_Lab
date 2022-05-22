namespace WindowsFormsApp_oop2_Lab
{
    partial class ListAllUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Tablo = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(304, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Users Listed Below";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Lime;
            this.exit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.Location = new System.Drawing.Point(657, 612);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(232, 40);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Tablo
            // 
            this.Tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablo.Location = new System.Drawing.Point(82, 81);
            this.Tablo.Name = "Tablo";
            this.Tablo.RowTemplate.Height = 24;
            this.Tablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tablo.Size = new System.Drawing.Size(748, 402);
            this.Tablo.TabIndex = 4;
            this.Tablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablo_CellContentClick);
            this.Tablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablo_CellDoubleClick);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add.Location = new System.Drawing.Point(657, 506);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(232, 35);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add a new user";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(657, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sort Users by score";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Tablo);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Name = "ListAllUsers";
            this.Text = "ListAllUsers";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ListAllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView Tablo;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
    }
}