using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;

namespace BANKING_SYSTEM2
{
    public partial class REGISTRATION : Form
    {

        BALayer objBAL;

        public REGISTRATION()
        {
            InitializeComponent();
        }
        protected void REGISTRATION_Load(object sender, EventArgs e)
        {

            objBAL = new BALayer();
        }



        protected void button1_Click(object sender, EventArgs e)
        {

            string customerName = txtCustomerName.Text;
            string dob = txtDob.Text;
            string age = txtAge.Text;
            string gender = txtGender.Text;
            string address = txtAddress.Text;
            string phoneNo = txtPhoneNo.Text;
            string accountType = txtAccountType.Text;
            string accountStartDate = txtAccountStartDate.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string pincode = txtPincode.Text;
            string password = txtPassword.Text;




            if ((customerName.Equals("")) || (dob.Equals("")) || (age.Equals("")) || (gender.Equals("")) || (address.Equals("")) || (phoneNo.Equals("")) ||
               (accountType.Equals("")) || (accountStartDate.Equals("")) || (city.Equals("")) || (state.Equals("")) || (pincode.Equals("")) || (password.Equals("")))
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {
                objBAL = new BALayer();
                int row = objBAL.customerRegisterBA( txtCustomerName.Text, txtDob.Text,txtAge.Text,txtGender.Text,txtAddress.Text, txtPhoneNo.Text,txtAccountType.Text,
                txtAccountStartDate.Text, txtCity.Text,txtState.Text, txtPincode.Text, txtPassword.Text);

                if (row == 1)
                {
                    MessageBox.Show("Account created successfully");


                    this.Hide();
                    Login_Page login = new Login_Page();
                    login.Show();




                }
                else
                {
                    MessageBox.Show("Error Occured.Try Again!!");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login_Page login = new Login_Page();
            login.Show();

        }


    }
}

