namespace WindowsFormsApp_oop2_Lab
{
    partial class AddNewUser
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
            this.Add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // city_
            // 
            this.city_.Location = new System.Drawing.Point(253, 254);
            this.city_.Name = "city_";
            this.city_.Size = new System.Drawing.Size(100, 22);
            this.city_.TabIndex = 52;
            this.city_.TextChanged += new System.EventHandler(this.city__TextChanged);
            // 
            // country_
            // 
            this.country_.Location = new System.Drawing.Point(253, 290);
            this.country_.Name = "country_";
            this.country_.Size = new System.Drawing.Size(100, 22);
            this.country_.TabIndex = 51;
            this.country_.TextChanged += new System.EventHandler(this.country__TextChanged);
            // 
            // email_
            // 
            this.email_.Location = new System.Drawing.Point(253, 328);
            this.email_.Name = "email_";
            this.email_.Size = new System.Drawing.Size(100, 22);
            this.email_.TabIndex = 50;
            this.email_.TextChanged += new System.EventHandler(this.email__TextChanged);
            // 
            // phoneNumber_
            // 
            this.phoneNumber_.Location = new System.Drawing.Point(253, 183);
            this.phoneNumber_.Name = "phoneNumber_";
            this.phoneNumber_.Size = new System.Drawing.Size(100, 22);
            this.phoneNumber_.TabIndex = 49;
            this.phoneNumber_.TextChanged += new System.EventHandler(this.phoneNumber__TextChanged);
            // 
            // address_
            // 
            this.address_.Location = new System.Drawing.Point(253, 218);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(100, 22);
            this.address_.TabIndex = 48;
            this.address_.TextChanged += new System.EventHandler(this.address__TextChanged);
            // 
            // nameSurname_
            // 
            this.nameSurname_.Location = new System.Drawing.Point(253, 140);
            this.nameSurname_.Name = "nameSurname_";
            this.nameSurname_.Size = new System.Drawing.Size(100, 22);
            this.nameSurname_.TabIndex = 47;
            this.nameSurname_.TextChanged += new System.EventHandler(this.nameSurname__TextChanged);
            // 
            // password_
            // 
            this.password_.Location = new System.Drawing.Point(253, 95);
            this.password_.Name = "password_";
            this.password_.PasswordChar = '*';
            this.password_.Size = new System.Drawing.Size(100, 22);
            this.password_.TabIndex = 46;
            this.password_.TextChanged += new System.EventHandler(this.password__TextChanged);
            // 
            // userName_
            // 
            this.userName_.Location = new System.Drawing.Point(253, 47);
            this.userName_.Name = "userName_";
            this.userName_.Size = new System.Drawing.Size(100, 22);
            this.userName_.TabIndex = 45;
            this.userName_.TextChanged += new System.EventHandler(this.userName__TextChanged);
            // 
            // Email_lb
            // 
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lb.Location = new System.Drawing.Point(73, 328);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(68, 20);
            this.Email_lb.TabIndex = 44;
            this.Email_lb.Text = "E-mail ";
            this.Email_lb.Click += new System.EventHandler(this.Email_lb_Click);
            // 
            // Country_lb
            // 
            this.Country_lb.AutoSize = true;
            this.Country_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_lb.Location = new System.Drawing.Point(73, 292);
            this.Country_lb.Name = "Country_lb";
            this.Country_lb.Size = new System.Drawing.Size(79, 20);
            this.Country_lb.TabIndex = 43;
            this.Country_lb.Text = "Country";
            this.Country_lb.Click += new System.EventHandler(this.Country_lb_Click);
            // 
            // City_lb
            // 
            this.City_lb.AutoSize = true;
            this.City_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_lb.Location = new System.Drawing.Point(73, 254);
            this.City_lb.Name = "City_lb";
            this.City_lb.Size = new System.Drawing.Size(44, 20);
            this.City_lb.TabIndex = 42;
            this.City_lb.Text = "City";
            this.City_lb.Click += new System.EventHandler(this.City_lb_Click);
            // 
            // Address_lb
            // 
            this.Address_lb.AutoSize = true;
            this.Address_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lb.Location = new System.Drawing.Point(73, 220);
            this.Address_lb.Name = "Address_lb";
            this.Address_lb.Size = new System.Drawing.Size(78, 20);
            this.Address_lb.TabIndex = 41;
            this.Address_lb.Text = "Address";
            this.Address_lb.Click += new System.EventHandler(this.Address_lb_Click);
            // 
            // PhoneNumber_lb
            // 
            this.PhoneNumber_lb.AutoSize = true;
            this.PhoneNumber_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_lb.Location = new System.Drawing.Point(73, 185);
            this.PhoneNumber_lb.Name = "PhoneNumber_lb";
            this.PhoneNumber_lb.Size = new System.Drawing.Size(134, 20);
            this.PhoneNumber_lb.TabIndex = 40;
            this.PhoneNumber_lb.Text = "Phone Number";
            this.PhoneNumber_lb.Click += new System.EventHandler(this.PhoneNumber_lb_Click);
            // 
            // NameSurname_lb
            // 
            this.NameSurname_lb.AutoSize = true;
            this.NameSurname_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSurname_lb.Location = new System.Drawing.Point(73, 142);
            this.NameSurname_lb.Name = "NameSurname_lb";
            this.NameSurname_lb.Size = new System.Drawing.Size(138, 20);
            this.NameSurname_lb.TabIndex = 39;
            this.NameSurname_lb.Text = "Name-Surname";
            this.NameSurname_lb.Click += new System.EventHandler(this.NameSurname_lb_Click);
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lb.Location = new System.Drawing.Point(73, 95);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(88, 20);
            this.Password_lb.TabIndex = 38;
            this.Password_lb.Text = "Password";
            this.Password_lb.Click += new System.EventHandler(this.Password_lb_Click);
            // 
            // Username_lb
            // 
            this.Username_lb.AutoSize = true;
            this.Username_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lb.Location = new System.Drawing.Point(73, 49);
            this.Username_lb.Name = "Username_lb";
            this.Username_lb.Size = new System.Drawing.Size(94, 20);
            this.Username_lb.TabIndex = 37;
            this.Username_lb.Text = "Username";
            this.Username_lb.Click += new System.EventHandler(this.Username_lb_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(381, 390);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 48);
            this.Add.TabIndex = 55;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(253, 390);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 48);
            this.cancel.TabIndex = 56;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
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
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button cancel;
    }
}