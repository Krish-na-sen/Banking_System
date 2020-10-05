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
using DALayer;


namespace BANKING_SYSTEM2
{
    public partial class HomePage : Form

    {
        
      public static  int CustomerId;

        BALayer objBAL = new BALayer();
        DBLayer objDAL = new DBLayer();

        public HomePage()
        {
            InitializeComponent();
        }

        protected void HomePage_Load(object sender, EventArgs e)

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





        protected void btnUpdate_Click(object sender, EventArgs e)
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
                objBAL = new BALayer();
                objDAL = new DBLayer();

                int row = objBAL.customerUpdateBA(txtCustomerNameHome.Text, txtDobHome.Text, txtAgeHome.Text, txtGenderHome.Text, txtAddressHome.Text,
               txtPhoneNoHome.Text, txtAccountTypeHome.Text, txtAccountStartDateHome.Text, txtCityHome.Text, txtStateHome.Text, txtPincodeHome.Text, txtPasswordHome.Text, CustomerId);
                
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you Sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog==DialogResult.Yes)
            {

                objBAL = new BALayer();
                objDAL = new DBLayer();
                int row = objBAL.customerDeleteBA(CustomerId);
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
    

