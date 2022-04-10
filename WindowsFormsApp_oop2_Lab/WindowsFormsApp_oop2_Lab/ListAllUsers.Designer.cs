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
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Users Listed Below";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(536, 34);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Tablo
            // 
            this.Tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablo.Location = new System.Drawing.Point(35, 63);
            this.Tablo.Name = "Tablo";
            this.Tablo.RowTemplate.Height = 24;
            this.Tablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tablo.Size = new System.Drawing.Size(697, 339);
            this.Tablo.TabIndex = 4;
            this.Tablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablo_CellDoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(595, 446);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(137, 44);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add a new user";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ListAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
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
    }
}