namespace BANKING_SYSTEM2
{
    partial class HomePage
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGenderHome = new System.Windows.Forms.ComboBox();
            this.txtAccountTypeHome = new System.Windows.Forms.ComboBox();
            this.txtAccountStartDateHome = new System.Windows.Forms.DateTimePicker();
            this.txtPasswordHome = new System.Windows.Forms.TextBox();
            this.txtPincodeHome = new System.Windows.Forms.TextBox();
            this.txtStateHome = new System.Windows.Forms.TextBox();
            this.txtCityHome = new System.Windows.Forms.TextBox();
            this.txtPhoneNoHome = new System.Windows.Forms.TextBox();
            this.txtAddressHome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgeHome = new System.Windows.Forms.TextBox();
            this.txtDobHome = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerNameHome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Violet;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Location = new System.Drawing.Point(659, 437);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Violet;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(659, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGenderHome
            // 
            this.txtGenderHome.FormattingEnabled = true;
            this.txtGenderHome.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.txtGenderHome.Location = new System.Drawing.Point(334, 182);
            this.txtGenderHome.Name = "txtGenderHome";
            this.txtGenderHome.Size = new System.Drawing.Size(200, 21);
            this.txtGenderHome.TabIndex = 26;
            // 
            // txtAccountTypeHome
            // 
            this.txtAccountTypeHome.FormattingEnabled = true;
            this.txtAccountTypeHome.Items.AddRange(new object[] {
            "SAVINGS ACCOUNT",
            "CURRENT ACCOUNT",
            "MERCHANT ACCOUNT"});
            this.txtAccountTypeHome.Location = new System.Drawing.Point(334, 346);
            this.txtAccountTypeHome.Name = "txtAccountTypeHome";
            this.txtAccountTypeHome.Size = new System.Drawing.Size(200, 21);
            this.txtAccountTypeHome.TabIndex = 25;
            // 
            // txtAccountStartDateHome
            // 
            this.txtAccountStartDateHome.CustomFormat = "dd-MM-yyyy";
            this.txtAccountStartDateHome.Location = new System.Drawing.Point(334, 394);
            this.txtAccountStartDateHome.Name = "txtAccountStartDateHome";
            this.txtAccountStartDateHome.Size = new System.Drawing.Size(200, 20);
            this.txtAccountStartDateHome.TabIndex = 24;
            // 
            // txtPasswordHome
            // 
            this.txtPasswordHome.Location = new System.Drawing.Point(334, 564);
            this.txtPasswordHome.Name = "txtPasswordHome";
            this.txtPasswordHome.Size = new System.Drawing.Size(200, 20);
            this.txtPasswordHome.TabIndex = 22;
            // 
            // txtPincodeHome
            // 
            this.txtPincodeHome.Location = new System.Drawing.Point(334, 527);
            this.txtPincodeHome.Name = "txtPincodeHome";
            this.txtPincodeHome.Size = new System.Drawing.Size(200, 20);
            this.txtPincodeHome.TabIndex = 21;
            // 
            // txtStateHome
            // 
            this.txtStateHome.Location = new System.Drawing.Point(334, 487);
            this.txtStateHome.Name = "txtStateHome";
            this.txtStateHome.Size = new System.Drawing.Size(200, 20);
            this.txtStateHome.TabIndex = 20;
            // 
            // txtCityHome
            // 
            this.txtCityHome.Location = new System.Drawing.Point(334, 440);
            this.txtCityHome.Name = "txtCityHome";
            this.txtCityHome.Size = new System.Drawing.Size(200, 20);
            this.txtCityHome.TabIndex = 19;
            // 
            // txtPhoneNoHome
            // 
            this.txtPhoneNoHome.Location = new System.Drawing.Point(334, 296);
            this.txtPhoneNoHome.Name = "txtPhoneNoHome";
            this.txtPhoneNoHome.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNoHome.TabIndex = 23;
            // 
            // txtAddressHome
            // 
            this.txtAddressHome.Location = new System.Drawing.Point(334, 222);
            this.txtAddressHome.Multiline = true;
            this.txtAddressHome.Name = "txtAddressHome";
            this.txtAddressHome.Size = new System.Drawing.Size(294, 56);
            this.txtAddressHome.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 564);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "PASSWORD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 530);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "PINCODE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "STATE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ACCOUNT TYPE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ACCOUNT START DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PHONE NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "GENDER";
            // 
            // txtAgeHome
            // 
            this.txtAgeHome.Location = new System.Drawing.Point(334, 144);
            this.txtAgeHome.Name = "txtAgeHome";
            this.txtAgeHome.Size = new System.Drawing.Size(200, 20);
            this.txtAgeHome.TabIndex = 32;
            // 
            // txtDobHome
            // 
            this.txtDobHome.CustomFormat = "dd-MM-yyyy";
            this.txtDobHome.Location = new System.Drawing.Point(334, 112);
            this.txtDobHome.Name = "txtDobHome";
            this.txtDobHome.Size = new System.Drawing.Size(200, 20);
            this.txtDobHome.TabIndex = 31;
            // 
            // txtCustomerNameHome
            // 
            this.txtCustomerNameHome.Location = new System.Drawing.Point(334, 72);
            this.txtCustomerNameHome.Name = "txtCustomerNameHome";
            this.txtCustomerNameHome.Size = new System.Drawing.Size(294, 20);
            this.txtCustomerNameHome.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "AGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "DOB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "CUSTOMER NAME";
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblWelcomeUser.Location = new System.Drawing.Point(297, 21);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(157, 15);
            this.lblWelcomeUser.TabIndex = 33;
            this.lblWelcomeUser.Text = "WELCOME USERNAME";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 621);
            this.Controls.Add(this.lblWelcomeUser);
            this.Controls.Add(this.txtAgeHome);
            this.Controls.Add(this.txtDobHome);
            this.Controls.Add(this.txtCustomerNameHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenderHome);
            this.Controls.Add(this.txtAccountTypeHome);
            this.Controls.Add(this.txtAccountStartDateHome);
            this.Controls.Add(this.txtPasswordHome);
            this.Controls.Add(this.txtPincodeHome);
            this.Controls.Add(this.txtStateHome);
            this.Controls.Add(this.txtCityHome);
            this.Controls.Add(this.txtPhoneNoHome);
            this.Controls.Add(this.txtAddressHome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "HomePage";
            this.ShowInTaskbar = false;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox txtGenderHome;
        private System.Windows.Forms.ComboBox txtAccountTypeHome;
        private System.Windows.Forms.DateTimePicker txtAccountStartDateHome;
        private System.Windows.Forms.TextBox txtPasswordHome;
        private System.Windows.Forms.TextBox txtPincodeHome;
        private System.Windows.Forms.TextBox txtStateHome;
        private System.Windows.Forms.TextBox txtCityHome;
        private System.Windows.Forms.TextBox txtPhoneNoHome;
        private System.Windows.Forms.TextBox txtAddressHome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgeHome;
        private System.Windows.Forms.DateTimePicker txtDobHome;
        private System.Windows.Forms.TextBox txtCustomerNameHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcomeUser;
    }
}