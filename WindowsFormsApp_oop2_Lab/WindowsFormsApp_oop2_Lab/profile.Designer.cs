namespace WindowsFormsApp_oop2_Lab
{
    partial class profile
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
            this.update = new System.Windows.Forms.Button();
            this.city_ = new System.Windows.Forms.TextBox();
            this.country_ = new System.Windows.Forms.TextBox();
            this.email_ = new System.Windows.Forms.TextBox();
            this.phoneNumber_ = new System.Windows.Forms.TextBox();
            this.address_ = new System.Windows.Forms.TextBox();
            this.nameSurname_ = new System.Windows.Forms.TextBox();
            this.password_ = new System.Windows.Forms.TextBox();
            this.userName_ = new System.Windows.Forms.TextBox();
            this.Email_lb = new System.Windows.Forms.Label();
            this.Country_lb = new System.Windows.Forms.Label();
            this.City_lb = new System.Windows.Forms.Label();
            this.Address_lb = new System.Windows.Forms.Label();
            this.PhoneNumber_lb = new System.Windows.Forms.Label();
            this.NameSurname_lb = new System.Windows.Forms.Label();
            this.Password_lb = new System.Windows.Forms.Label();
            this.Username_lb = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.oldPassword_ = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Cyan;
            this.update.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(407, 448);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(87, 50);
            this.update.TabIndex = 33;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // city_
            // 
            this.city_.Location = new System.Drawing.Point(270, 285);
            this.city_.Name = "city_";
            this.city_.Size = new System.Drawing.Size(100, 22);
            this.city_.TabIndex = 32;
            // 
            // country_
            // 
            this.country_.Location = new System.Drawing.Point(270, 325);
            this.country_.Name = "country_";
            this.country_.Size = new System.Drawing.Size(100, 22);
            this.country_.TabIndex = 31;
            // 
            // email_
            // 
            this.email_.Location = new System.Drawing.Point(270, 364);
            this.email_.Name = "email_";
            this.email_.Size = new System.Drawing.Size(100, 22);
            this.email_.TabIndex = 30;
            // 
            // phoneNumber_
            // 
            this.phoneNumber_.Location = new System.Drawing.Point(270, 199);
            this.phoneNumber_.Name = "phoneNumber_";
            this.phoneNumber_.Size = new System.Drawing.Size(100, 22);
            this.phoneNumber_.TabIndex = 29;
            // 
            // address_
            // 
            this.address_.Location = new System.Drawing.Point(270, 240);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(100, 22);
            this.address_.TabIndex = 28;
            // 
            // nameSurname_
            // 
            this.nameSurname_.Location = new System.Drawing.Point(270, 161);
            this.nameSurname_.Name = "nameSurname_";
            this.nameSurname_.Size = new System.Drawing.Size(100, 22);
            this.nameSurname_.TabIndex = 27;
            // 
            // password_
            // 
            this.password_.Location = new System.Drawing.Point(270, 123);
            this.password_.Name = "password_";
            this.password_.PasswordChar = '*';
            this.password_.Size = new System.Drawing.Size(100, 22);
            this.password_.TabIndex = 26;
            // 
            // userName_
            // 
            this.userName_.Enabled = false;
            this.userName_.Location = new System.Drawing.Point(270, 49);
            this.userName_.Name = "userName_";
            this.userName_.Size = new System.Drawing.Size(100, 22);
            this.userName_.TabIndex = 25;
            this.userName_.TextChanged += new System.EventHandler(this.userName__TextChanged);
            // 
            // Email_lb
            // 
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lb.Location = new System.Drawing.Point(90, 366);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(68, 20);
            this.Email_lb.TabIndex = 24;
            this.Email_lb.Text = "E-mail ";
            // 
            // Country_lb
            // 
            this.Country_lb.AutoSize = true;
            this.Country_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_lb.Location = new System.Drawing.Point(90, 327);
            this.Country_lb.Name = "Country_lb";
            this.Country_lb.Size = new System.Drawing.Size(79, 20);
            this.Country_lb.TabIndex = 23;
            this.Country_lb.Text = "Country";
            // 
            // City_lb
            // 
            this.City_lb.AutoSize = true;
            this.City_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_lb.Location = new System.Drawing.Point(90, 287);
            this.City_lb.Name = "City_lb";
            this.City_lb.Size = new System.Drawing.Size(44, 20);
            this.City_lb.TabIndex = 22;
            this.City_lb.Text = "City";
            // 
            // Address_lb
            // 
            this.Address_lb.AutoSize = true;
            this.Address_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lb.Location = new System.Drawing.Point(90, 242);
            this.Address_lb.Name = "Address_lb";
            this.Address_lb.Size = new System.Drawing.Size(78, 20);
            this.Address_lb.TabIndex = 21;
            this.Address_lb.Text = "Address";
            // 
            // PhoneNumber_lb
            // 
            this.PhoneNumber_lb.AutoSize = true;
            this.PhoneNumber_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_lb.Location = new System.Drawing.Point(90, 201);
            this.PhoneNumber_lb.Name = "PhoneNumber_lb";
            this.PhoneNumber_lb.Size = new System.Drawing.Size(134, 20);
            this.PhoneNumber_lb.TabIndex = 20;
            this.PhoneNumber_lb.Text = "Phone Number";
            // 
            // NameSurname_lb
            // 
            this.NameSurname_lb.AutoSize = true;
            this.NameSurname_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSurname_lb.Location = new System.Drawing.Point(90, 163);
            this.NameSurname_lb.Name = "NameSurname_lb";
            this.NameSurname_lb.Size = new System.Drawing.Size(138, 20);
            this.NameSurname_lb.TabIndex = 19;
            this.NameSurname_lb.Text = "Name-Surname";
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lb.Location = new System.Drawing.Point(90, 125);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(128, 20);
            this.Password_lb.TabIndex = 18;
            this.Password_lb.Text = "New Password";
            // 
            // Username_lb
            // 
            this.Username_lb.AutoSize = true;
            this.Username_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lb.Location = new System.Drawing.Point(90, 51);
            this.Username_lb.Name = "Username_lb";
            this.Username_lb.Size = new System.Drawing.Size(94, 20);
            this.Username_lb.TabIndex = 17;
            this.Username_lb.Text = "Username";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Cyan;
            this.cancel.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(270, 448);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 50);
            this.cancel.TabIndex = 34;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // oldPassword_
            // 
            this.oldPassword_.Location = new System.Drawing.Point(270, 86);
            this.oldPassword_.Name = "oldPassword_";
            this.oldPassword_.PasswordChar = '*';
            this.oldPassword_.Size = new System.Drawing.Size(100, 22);
            this.oldPassword_.TabIndex = 35;
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassword.Location = new System.Drawing.Point(90, 88);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(123, 20);
            this.oldPassword.TabIndex = 36;
            this.oldPassword.Text = "Old Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 50);
            this.button1.TabIndex = 37;
            this.button1.Text = "Delete Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.oldPassword_);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.city_);
            this.Controls.Add(this.country_);
            this.Controls.Add(this.email_);
            this.Controls.Add(this.phoneNumber_);
            this.Controls.Add(this.address_);
            this.Controls.Add(this.nameSurname_);
            this.Controls.Add(this.password_);
            this.Controls.Add(this.userName_);
            this.Controls.Add(this.Email_lb);
            this.Controls.Add(this.Country_lb);
            this.Controls.Add(this.City_lb);
            this.Controls.Add(this.Address_lb);
            this.Controls.Add(this.PhoneNumber_lb);
            this.Controls.Add(this.NameSurname_lb);
            this.Controls.Add(this.Password_lb);
            this.Controls.Add(this.Username_lb);
            this.Name = "profile";
            this.Text = "profile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox city_;
        private System.Windows.Forms.TextBox country_;
        private System.Windows.Forms.TextBox email_;
        private System.Windows.Forms.TextBox phoneNumber_;
        private System.Windows.Forms.TextBox address_;
        private System.Windows.Forms.TextBox nameSurname_;
        private System.Windows.Forms.TextBox password_;
        private System.Windows.Forms.TextBox userName_;
        private System.Windows.Forms.Label Email_lb;
        private System.Windows.Forms.Label Country_lb;
        private System.Windows.Forms.Label City_lb;
        private System.Windows.Forms.Label Address_lb;
        private System.Windows.Forms.Label PhoneNumber_lb;
        private System.Windows.Forms.Label NameSurname_lb;
        private System.Windows.Forms.Label Password_lb;
        private System.Windows.Forms.Label Username_lb;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox oldPassword_;
        private System.Windows.Forms.Label oldPassword;
        private System.Windows.Forms.Button button1;
    }
}