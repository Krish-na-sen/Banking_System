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
    
    public partial class Admin_Control_Page : Form
    {

        BALayer objBAL;
        DBLayer objDAL;

        public Admin_Control_Page()
        {
            InitializeComponent();
        }

        private void Admin_Control_Page_Load(object sender, EventArgs e)

        {

            objBAL = new BALayer();
            objDAL = new DBLayer();

            DataTable tbCustomerBA= objBAL.adminControlBA();

            dataGridView1.DataSource = tbCustomerBA;
            objDAL.closeConn();

        }
   }


}
