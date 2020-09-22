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
        RegistrationData regData = new RegistrationData();


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
            regData.CustomerName= txtCustomerName.Text;
            regData.DOB= txtDob.Text;
            regData.Age = txtAge.Text;
            regData.Gender  = txtGender.Text;
            regData.Address = txtAddress.Text;
            regData.PhoneNo= txtPhoneNo.Text;
            regData.AccountType = txtAccountType.Text;
            regData.AccountStartDate= txtAccountStartDate.Text;
            regData.City= txtCity.Text;
            regData.State= txtState.Text;
            regData.Pincode = txtPincode.Text;
            regData.Password= txtPassword.Text;
            



            if ((regData.CustomerName.Equals("")) || (regData.DOB.Equals("")) || (regData.Age.Equals("")) || (regData.Gender.Equals("")) || 
                (regData.Address.Equals("")) || (regData.PhoneNo.Equals("")) ||
               (regData.AccountType.Equals("")) || (regData.AccountStartDate.Equals("")) || (regData.City.Equals("")) || (regData.State.Equals("")) || (regData.Pincode.Equals("")) || (regData.Password.Equals("")) )
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into CUSTOMER_REGISTRATION1(CUSTOMER_NAME,DOB,AGE,GENDER,ADDRESS,PHONE_NO,ACCOUNT_TYPE,ACCOUNT_START_DATE,CITY,STATE,PINCODE,PASSWORD) values(@customerName,@dob,@age,@gender,@address,@phoneNo,@accountType,@accountStartDate,@city,@state,@pincode,@password)");

                insertCommand.Parameters.AddWithValue("@customerName", regData.CustomerName);
                insertCommand.Parameters.AddWithValue("@dob", regData.DOB);
                insertCommand.Parameters.AddWithValue("@age", regData.Age);
                insertCommand.Parameters.AddWithValue("@gender", regData.Gender);
                insertCommand.Parameters.AddWithValue("@address", regData.Address);
                insertCommand.Parameters.AddWithValue("@phoneNo", regData.PhoneNo); ;
                insertCommand.Parameters.AddWithValue("@accountType", regData.AccountType);
                insertCommand.Parameters.AddWithValue("@accountStartDate", regData.AccountStartDate);
                insertCommand.Parameters.AddWithValue("@city", regData.City);
                insertCommand.Parameters.AddWithValue("@state", regData.State);
                insertCommand.Parameters.AddWithValue("@pincode", regData.Pincode);
                insertCommand.Parameters.AddWithValue("@password", regData.Password);
                

                int row = objDbAccess.executeQuery(insertCommand);
                if (customerDAO.row == 1)
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

