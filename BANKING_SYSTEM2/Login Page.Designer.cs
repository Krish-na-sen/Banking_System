namespace BANKING_SYSTEM2
{
    partial class Login_Page
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerNmae = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCUSTOMERID = new System.Windows.Forms.TextBox();
            this.txtCUSTOMERNAME = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.lblForRegistration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCustomerID.Location = new System.Drawing.Point(127, 38);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(112, 16);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "CUSTOMER ID";
            // 
            // lblCustomerNmae
            // 
            this.lblCustomerNmae.AutoSize = true;
            this.lblCustomerNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNmae.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCustomerNmae.Location = new System.Drawing.Point(127, 94);
            this.lblCustomerNmae.Name = "lblCustomerNmae";
            this.lblCustomerNmae.Size = new System.Drawing.Size(140, 16);
            this.lblCustomerNmae.TabIndex = 1;
            this.lblCustomerNmae.Text = "CUSTOMER NAME";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassword.Location = new System.Drawing.Point(127, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "PASSWORD";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DeepPink;
            this.btnLogin.Location = new System.Drawing.Point(305, 203);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCUSTOMERID
            // 
            this.txtCUSTOMERID.Location = new System.Drawing.Point(315, 38);
            this.txtCUSTOMERID.Name = "txtCUSTOMERID";
            this.txtCUSTOMERID.Size = new System.Drawing.Size(214, 20);
            this.txtCUSTOMERID.TabIndex = 4;
            // 
            // txtCUSTOMERNAME
            // 
            this.txtCUSTOMERNAME.Location = new System.Drawing.Point(315, 94);
            this.txtCUSTOMERNAME.Name = "txtCUSTOMERNAME";
            this.txtCUSTOMERNAME.Size = new System.Drawing.Size(212, 20);
            this.txtCUSTOMERNAME.TabIndex = 5;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(313, 143);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(214, 20);
            this.txtPASSWORD.TabIndex = 6;
            // 
            // lblForRegistration
            // 
            this.lblForRegistration.AutoSize = true;
            this.lblForRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForRegistration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblForRegistration.Location = new System.Drawing.Point(386, 260);
            this.lblForRegistration.Name = "lblForRegistration";
            this.lblForRegistration.Size = new System.Drawing.Size(219, 15);
            this.lblForRegistration.TabIndex = 7;
            this.lblForRegistration.Text = "Don\'t have an account.Click Here";
            this.lblForRegistration.Click += new System.EventHandler(this.lblForRegistration_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 312);
            this.Controls.Add(this.lblForRegistration);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtCUSTOMERNAME);
            this.Controls.Add(this.txtCUSTOMERID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCustomerNmae);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerNmae;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCUSTOMERID;
        private System.Windows.Forms.TextBox txtCUSTOMERNAME;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label lblForRegistration;
    }
}