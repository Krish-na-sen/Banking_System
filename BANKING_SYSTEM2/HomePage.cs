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
    public partial class HomePage : Form

    {
        DBAccess objDbAccess = new DBAccess();
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)

        {


            lblWelcomeUser.Text = "WELCOME " + Login_Page.CustomerName;

            txtCustomerNameHome.Text = Login_Page.CustomerName;
            txtDobHome.Text = Login_Page.Dob;
            txtAgeHome.Text = Login_Page.Age;
            txtGenderHome.Text = Login_Page.Gender;
            txtAddressHome.Text = Login_Page.Address;
            txtPhoneNoHome.Text = Login_Page.PhoneNo;
            txtAccountTypeHome.Text = Login_Page.AccountType;
            txtAccountStartDateHome.Text = Login_Page.AccountStartDate;
            txtCityHome.Text = Login_Page.City;
            txtStateHome.Text = Login_Page.State;
            txtPincodeHome.Text = Login_Page.Pincode;
            txtPasswordHome.Text = Login_Page.Password;


      }





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newCustomerNameHome = txtCustomerNameHome.Text;
            string newDobHome = txtDobHome.Text;
            string newAgeHome = txtAgeHome.Text;
            string newGenderHome = txtGenderHome.Text;
            string newAddressHome = txtAddressHome.Text;
            string newPhoneNoHome = txtPhoneNoHome.Text;
            string newAccountTypeHome = txtAccountTypeHome.Text;
            string newAccountStartDateHome = txtAccountStartDateHome.Text;
            string newCityHome = txtCityHome.Text;
            string newStateHome = txtStateHome.Text;
            string newPincodeHome = txtPincodeHome.Text;
            string newPasswordHome = txtPasswordHome.Text;


            if ((newCustomerNameHome.Equals("")) || (newDobHome.Equals("")) || (newAgeHome.Equals(""))

|| (newGenderHome.Equals("")) || (newAddressHome.Equals("")) || (newPhoneNoHome.Equals("")) ||
       (newAccountTypeHome.Equals("")) || (newAccountStartDateHome.Equals("")) ||

(newCityHome.Equals("")) || (newStateHome.Equals("")) || (newPincodeHome.Equals("")) ||

(newPasswordHome.Equals("")))
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {

                string query = "update CUSTOMER_REGISTRATION1  SET CUSTOMER_NAME ='" +newCustomerNameHome+ "',DOB = '" + newDobHome+ "', AGE = '" +  newAgeHome + "',  GENDER = '" +newGenderHome + "',ADDRESS = '" +  newAddressHome + "', PHONE_NO = '" +  newPhoneNoHome  + "', ACCOUNT_TYPE = '" +newAccountTypeHome + "', ACCOUNT_START_DATE = '" +  newAccountStartDateHome+ "',CITY = '" +  newCityHome + "',  STATE = '" + newStateHome + "',  PINCODE = '" +  newPincodeHome+ "',  PASSWORD = '" +  newPasswordHome+ "' where CUSTOMER_ID = '" + Login_Page.CustomerId+"' ";
                SqlCommand updateCommand = new SqlCommand(query);
                updateCommand.Parameters.AddWithValue("@newCustomerNameHome",newCustomerNameHome);
                updateCommand.Parameters.AddWithValue("@newDobHome",newDobHome);
                updateCommand.Parameters.AddWithValue("newAgeHome", newAgeHome);
                updateCommand.Parameters.AddWithValue("newGenderHome", newGenderHome);
                updateCommand.Parameters.AddWithValue("@newAddressHome", newAddressHome);
                updateCommand.Parameters.AddWithValue("@newPhoneNoHome", newPhoneNoHome); ;
                updateCommand.Parameters.AddWithValue("@newAccountTypeHome", newAccountTypeHome);
                updateCommand.Parameters.AddWithValue("@newAccountStartDateHome", newAccountStartDateHome);
                updateCommand.Parameters.AddWithValue("@newCityHome", newCityHome);
                updateCommand.Parameters.AddWithValue("@newStateHome", newStateHome);
                updateCommand.Parameters.AddWithValue("@newPincodeHome", newPincodeHome);
                updateCommand.Parameters.AddWithValue("@newPasswordHome", newPasswordHome);


                int row = objDbAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account Details updated successfully");

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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog==DialogResult.Yes)
            {
                string query = "DELETE from CUSTOMER_REGISTRATION1  where CUSTOMER_ID ='"+Login_Page.CustomerId+"'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDbAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account Deleted successfully");

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
        }
    }
    

