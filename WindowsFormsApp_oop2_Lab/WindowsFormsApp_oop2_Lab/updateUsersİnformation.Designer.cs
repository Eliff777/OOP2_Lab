namespace WindowsFormsApp_oop2_Lab
{
    partial class updateUsersİnformation
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
            this.usName = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.userinformations = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
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
            this.userinformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Enter the username to search: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usName
            // 
            this.usName.Location = new System.Drawing.Point(26, 100);
            this.usName.Name = "usName";
            this.usName.Size = new System.Drawing.Size(139, 22);
            this.usName.TabIndex = 76;
            this.usName.TextChanged += new System.EventHandler(this.usName_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(48, 148);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 77;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // userinformations
            // 
            this.userinformations.Controls.Add(this.cancel);
            this.userinformations.Controls.Add(this.Update);
            this.userinformations.Controls.Add(this.city_);
            this.userinformations.Controls.Add(this.country_);
            this.userinformations.Controls.Add(this.email_);
            this.userinformations.Controls.Add(this.phoneNumber_);
            this.userinformations.Controls.Add(this.address_);
            this.userinformations.Controls.Add(this.nameSurname_);
            this.userinformations.Controls.Add(this.password_);
            this.userinformations.Controls.Add(this.userName_);
            this.userinformations.Controls.Add(this.Email_lb);
            this.userinformations.Controls.Add(this.Country_lb);
            this.userinformations.Controls.Add(this.City_lb);
            this.userinformations.Controls.Add(this.Address_lb);
            this.userinformations.Controls.Add(this.PhoneNumber_lb);
            this.userinformations.Controls.Add(this.NameSurname_lb);
            this.userinformations.Controls.Add(this.Password_lb);
            this.userinformations.Controls.Add(this.Username_lb);
            this.userinformations.Location = new System.Drawing.Point(304, 28);
            this.userinformations.Name = "userinformations";
            this.userinformations.Size = new System.Drawing.Size(402, 410);
            this.userinformations.TabIndex = 78;
            this.userinformations.TabStop = false;
            this.userinformations.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(186, 346);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 48);
            this.cancel.TabIndex = 92;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(314, 346);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(87, 48);
            this.Update.TabIndex = 91;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // city_
            // 
            this.city_.Location = new System.Drawing.Point(200, 237);
            this.city_.Name = "city_";
            this.city_.Size = new System.Drawing.Size(100, 22);
            this.city_.TabIndex = 90;
            // 
            // country_
            // 
            this.country_.Location = new System.Drawing.Point(200, 273);
            this.country_.Name = "country_";
            this.country_.Size = new System.Drawing.Size(100, 22);
            this.country_.TabIndex = 89;
            // 
            // email_
            // 
            this.email_.Location = new System.Drawing.Point(200, 311);
            this.email_.Name = "email_";
            this.email_.Size = new System.Drawing.Size(100, 22);
            this.email_.TabIndex = 88;
            // 
            // phoneNumber_
            // 
            this.phoneNumber_.Location = new System.Drawing.Point(200, 166);
            this.phoneNumber_.Name = "phoneNumber_";
            this.phoneNumber_.Size = new System.Drawing.Size(100, 22);
            this.phoneNumber_.TabIndex = 87;
            // 
            // address_
            // 
            this.address_.Location = new System.Drawing.Point(200, 201);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(100, 22);
            this.address_.TabIndex = 86;
            // 
            // nameSurname_
            // 
            this.nameSurname_.Location = new System.Drawing.Point(200, 123);
            this.nameSurname_.Name = "nameSurname_";
            this.nameSurname_.Size = new System.Drawing.Size(100, 22);
            this.nameSurname_.TabIndex = 85;
            // 
            // password_
            // 
            this.password_.Location = new System.Drawing.Point(200, 78);
            this.password_.Name = "password_";
            this.password_.PasswordChar = '*';
            this.password_.Size = new System.Drawing.Size(100, 22);
            this.password_.TabIndex = 84;
            // 
            // userName_
            // 
            this.userName_.Enabled = false;
            this.userName_.Location = new System.Drawing.Point(200, 30);
            this.userName_.Name = "userName_";
            this.userName_.Size = new System.Drawing.Size(100, 22);
            this.userName_.TabIndex = 83;
            // 
            // Email_lb
            // 
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lb.Location = new System.Drawing.Point(20, 311);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(68, 20);
            this.Email_lb.TabIndex = 82;
            this.Email_lb.Text = "E-mail ";
            // 
            // Country_lb
            // 
            this.Country_lb.AutoSize = true;
            this.Country_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_lb.Location = new System.Drawing.Point(20, 275);
            this.Country_lb.Name = "Country_lb";
            this.Country_lb.Size = new System.Drawing.Size(79, 20);
            this.Country_lb.TabIndex = 81;
            this.Country_lb.Text = "Country";
            // 
            // City_lb
            // 
            this.City_lb.AutoSize = true;
            this.City_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_lb.Location = new System.Drawing.Point(20, 237);
            this.City_lb.Name = "City_lb";
            this.City_lb.Size = new System.Drawing.Size(44, 20);
            this.City_lb.TabIndex = 80;
            this.City_lb.Text = "City";
            // 
            // Address_lb
            // 
            this.Address_lb.AutoSize = true;
            this.Address_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lb.Location = new System.Drawing.Point(20, 203);
            this.Address_lb.Name = "Address_lb";
            this.Address_lb.Size = new System.Drawing.Size(78, 20);
            this.Address_lb.TabIndex = 79;
            this.Address_lb.Text = "Address";
            // 
            // PhoneNumber_lb
            // 
            this.PhoneNumber_lb.AutoSize = true;
            this.PhoneNumber_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_lb.Location = new System.Drawing.Point(20, 168);
            this.PhoneNumber_lb.Name = "PhoneNumber_lb";
            this.PhoneNumber_lb.Size = new System.Drawing.Size(134, 20);
            this.PhoneNumber_lb.TabIndex = 78;
            this.PhoneNumber_lb.Text = "Phone Number";
            // 
            // NameSurname_lb
            // 
            this.NameSurname_lb.AutoSize = true;
            this.NameSurname_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSurname_lb.Location = new System.Drawing.Point(20, 125);
            this.NameSurname_lb.Name = "NameSurname_lb";
            this.NameSurname_lb.Size = new System.Drawing.Size(138, 20);
            this.NameSurname_lb.TabIndex = 77;
            this.NameSurname_lb.Text = "Name-Surname";
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lb.Location = new System.Drawing.Point(20, 78);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(88, 20);
            this.Password_lb.TabIndex = 76;
            this.Password_lb.Text = "Password";
            // 
            // Username_lb
            // 
            this.Username_lb.AutoSize = true;
            this.Username_lb.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lb.Location = new System.Drawing.Point(20, 32);
            this.Username_lb.Name = "Username_lb";
            this.Username_lb.Size = new System.Drawing.Size(94, 20);
            this.Username_lb.TabIndex = 75;
            this.Username_lb.Text = "Username";
            // 
            // updateUsersİnformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userinformations);
            this.Controls.Add(this.search);
            this.Controls.Add(this.usName);
            this.Controls.Add(this.label1);
            this.Name = "updateUsersİnformation";
            this.Text = "updateUsersİnformation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.updateUsersİnformation_Load);
            this.userinformations.ResumeLayout(false);
            this.userinformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usName;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.GroupBox userinformations;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Update;
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
    }
}