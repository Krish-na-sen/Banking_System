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
    public partial class Admin_Login : Form
    {

        DBAccess objDbAccess = new DBAccess();
        DataTable dtAdmin = new DataTable();

        public Admin_Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string adminUsername = txtAdminUsername.Text;

            string adminPassword = txtAdminPassword.Text;




            if ((adminUsername.Equals("")) || (adminPassword.Equals("")))
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {
                string query = "Select * from  ADMIN_CREDENTIALS where USERNAME='" + adminUsername + "' AND PASSWORD ='" +adminPassword + "'  ";

                objDbAccess.readDatathroughAdapter(query, dtAdmin);

                if (dtAdmin.Rows.Count == 1)
                {
                    MessageBox.Show("Congratulations!!!Logged in successful..");
                    objDbAccess.closeConn();


                    this.Hide();
                    Admin_Control_Page admincontrol = new Admin_Control_Page();
                    admincontrol.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Credentials!!!");

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SB_Bank_Main_Page mainpage = new SB_Bank_Main_Page();
            mainpage.Show();
        }
    }
}
        

