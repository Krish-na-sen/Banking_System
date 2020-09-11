using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKING_SYSTEM2
{
    public partial class Login_Page : Form
    {
        public static string CustomerId,CustomerName, Dob, Age, Gender, Address, PhoneNo, AccountType, AccountStartDate, City, State, Pincode, Password;

        DBAccess objDbAccess = new DBAccess();
        DataTable dtCustomer = new DataTable();
        HomePage homepage = new HomePage();
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                string query = "Select * from  CUSTOMER_REGISTRATION1 where CUSTOMER_ID='" + customerID + "' AND CUSTOMER_NAME ='" + customerName + "' AND PASSWORD ='" + password + "' ";

                objDbAccess.readDatathroughAdapter(query, dtCustomer);

                if (dtCustomer.Rows.Count == 1)
                {
                    MessageBox.Show("Congratulations!!!Logged in successful..");
                    objDbAccess.closeConn();


                    CustomerId = dtCustomer.Rows[0]["CUSTOMER_ID"].ToString();
                    CustomerName = dtCustomer.Rows[0]["CUSTOMER_NAME"].ToString();
                    Dob = dtCustomer.Rows[0]["DOB"].ToString();
                    Age = dtCustomer.Rows[0]["AGE"].ToString();
                    Gender = dtCustomer.Rows[0]["GENDER"].ToString();
                    Address = dtCustomer.Rows[0]["ADDRESS"].ToString();
                    PhoneNo = dtCustomer.Rows[0]["PHONE_NO"].ToString();
                    AccountType = dtCustomer.Rows[0]["ACCOUNT_TYPE"].ToString();
                    AccountStartDate = dtCustomer.Rows[0]["ACCOUNT_START_DATE"].ToString();
                    City = dtCustomer.Rows[0]["CITY"].ToString();
                    State = dtCustomer.Rows[0]["STATE"].ToString();
                    Pincode = dtCustomer.Rows[0]["PINCODE"].ToString();
                    Password = dtCustomer.Rows[0]["PASSWORD"].ToString();




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
