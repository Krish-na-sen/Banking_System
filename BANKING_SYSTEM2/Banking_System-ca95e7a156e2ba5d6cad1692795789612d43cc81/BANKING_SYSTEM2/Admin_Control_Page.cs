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
    public partial class Admin_Control_Page : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable tbCustomer = new DataTable();
        public Admin_Control_Page()
        {
            InitializeComponent();
        }

        private void Admin_Control_Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from CUSTOMER_REGISTRATION1";
            objDbAccess.readDatathroughAdapter(query, tbCustomer);

            dataGridView1.DataSource = tbCustomer;
            objDbAccess.closeConn();

        }
   }


}
