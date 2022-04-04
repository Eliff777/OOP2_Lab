namespace WindowsFormsApp_oop2_Lab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanıcıadı = new System.Windows.Forms.TextBox();
            this.şifre = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(97, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username/Password is wrong!";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.Location = new System.Drawing.Point(262, 86);
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.Size = new System.Drawing.Size(100, 22);
            this.kullanıcıadı.TabIndex = 3;
            this.kullanıcıadı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullanıcıadı_KeyPress);
            // 
            // şifre
            // 
            this.şifre.Location = new System.Drawing.Point(262, 127);
            this.şifre.Name = "şifre";
            this.şifre.PasswordChar = '*';
            this.şifre.Size = new System.Drawing.Size(100, 22);
            this.şifre.TabIndex = 4;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enter.Location = new System.Drawing.Point(269, 174);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(93, 37);
            this.enter.TabIndex = 6;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(430, 174);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(94, 37);
            this.signup.TabIndex = 7;
            this.signup.Text = "signup";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(368, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.kullanıcıadı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullanıcıadı;
        private System.Windows.Forms.TextBox şifre;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

