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

namespace BANKING_SYSTEM2
{
    public partial class REGISTRATION : Form
    {
        DBAccess objDbAccess = new DBAccess();
        public REGISTRATION()
        {
            InitializeComponent();
        }
        private void REGISTRATION_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
               (accountType.Equals("")) || (accountStartDate.Equals("")) || (city.Equals("")) || (state.Equals("")) || (pincode.Equals("")) || (password.Equals("")) )
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into CUSTOMER_REGISTRATION1(CUSTOMER_NAME,DOB,AGE,GENDER,ADDRESS,PHONE_NO,ACCOUNT_TYPE,ACCOUNT_START_DATE,CITY,STATE,PINCODE,PASSWORD) values(@customerName,@dob,@age,@gender,@address,@phoneNo,@accountType,@accountStartDate,@city,@state,@pincode,@password)");

                insertCommand.Parameters.AddWithValue("@customerName", customerName);
                insertCommand.Parameters.AddWithValue("@dob", dob);
                insertCommand.Parameters.AddWithValue("@age", age);
                insertCommand.Parameters.AddWithValue("@gender", gender);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@phoneNo", phoneNo); ;
                insertCommand.Parameters.AddWithValue("@accountType", accountType);
                insertCommand.Parameters.AddWithValue("@accountStartDate", accountStartDate);
                insertCommand.Parameters.AddWithValue("@city", city);
                insertCommand.Parameters.AddWithValue("@state", state);
                insertCommand.Parameters.AddWithValue("@pincode", pincode);
                insertCommand.Parameters.AddWithValue("@password", password);
                

                int row = objDbAccess.executeQuery(insertCommand);
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

