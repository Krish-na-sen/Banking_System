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
    public partial class Admin_Login : Form
    {

        BALayer objBAL;
        DBLayer objDAL;
        public Admin_Login()
        {
            InitializeComponent();
        }


        protected void button1_Click(object sender, EventArgs e)
        {

            string adminUsername = txtAdminUsername.Text;

            string adminPassword = txtAdminPassword.Text;




            if ((adminUsername.Equals("")) || (adminPassword.Equals("")))
            {
                MessageBox.Show("please enter mandatory fields !!!");
            }

            else
            {

                objBAL = new BALayer();
                objDAL = new DBLayer();
                DataTable dtAdminBA = objBAL.adminLoginBA(txtAdminUsername.Text,txtAdminPassword.Text);
                if (dtAdminBA.Rows.Count == 1)
                {
                    MessageBox.Show("Congratulations!!!Logged in successful..");
                    objDAL.closeConn();


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
        

