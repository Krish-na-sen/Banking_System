using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DALayer;

namespace BANKING_SYSTEM2
{
    public partial class Login_Page : Form
    {
        public static string CustomerId,CustomerName, Dob, Age, Gender, Address, PhoneNo, AccountType, AccountStartDate, City, State, Pincode, Password;

        BALayer objBAL;
        DBLayer objDAL;
        DataTable dtCustomer = new DataTable();
        HomePage homepage = new HomePage();

        public Login_Page()
        {
            InitializeComponent();
        }

        protected void Login_Page_Load(object sender, EventArgs e)
        {
            objBAL = new BALayer();
            objDAL = new DBLayer();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string customerID = txtCUSTOMERID.Text;

            string customerName = txtCUSTOMERNAME.Text;

            string password = txtPASSWORD.Text;


            if ((customerID.Equals("")) || (customerName.Equals("")) || (password.Equals("")))
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {
                objBAL = new BALayer();
                DataTable dtCustomerBA = objBAL.customerLoginBA(txtCUSTOMERID.Text, txtCUSTOMERNAME.Text, txtPASSWORD.Text);
                if (dtCustomerBA.Rows.Count == 1)
                {
                    MessageBox.Show("Congratulations!!!Logged in successful..");
                    objDAL.closeConn();


                    CustomerId = dtCustomerBA.Rows[0]["CUSTOMER_ID"].ToString();
                    CustomerName = dtCustomerBA.Rows[0]["CUSTOMER_NAME"].ToString();
                    Dob = dtCustomerBA.Rows[0]["DOB"].ToString();
                    Age = dtCustomerBA.Rows[0]["AGE"].ToString();
                    Gender = dtCustomerBA.Rows[0]["GENDER"].ToString();
                    Address = dtCustomerBA.Rows[0]["ADDRESS"].ToString();
                    PhoneNo = dtCustomerBA.Rows[0]["PHONE_NO"].ToString();
                    AccountType = dtCustomerBA.Rows[0]["ACCOUNT_TYPE"].ToString();
                    AccountStartDate = dtCustomerBA.Rows[0]["ACCOUNT_START_DATE"].ToString();
                    City = dtCustomerBA.Rows[0]["CITY"].ToString();
                    State = dtCustomerBA.Rows[0]["STATE"].ToString();
                    Pincode = dtCustomerBA.Rows[0]["PINCODE"].ToString();
                    Password = dtCustomerBA.Rows[0]["PASSWORD"].ToString();




                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Credentials!!!");

                }


            }
        }

        private void lblForRegistration_Click(object sender, EventArgs e)
        {

            this.Hide();
            REGISTRATION register = new REGISTRATION();
            register.Show();
        }
    }


}
