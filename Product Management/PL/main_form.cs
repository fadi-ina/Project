using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management.PL
{ // 
    public partial class main_form : Form
    {
        public main_form()
        {  // so here at the begining will not allow the users to enter until they register
            // are disable the all the menu access except the login and logout
         InitializeComponent(); 
            // disable all the access until they login
            this.productsToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.backupToolStripMenuItem.Enabled = false;
            this.restoreBackupToolStripMenuItem.Enabled = false;

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // will make the user enter the login page by using the login instance 
            Login_Form form1 = new Login_Form(); // to access the login 
            form1.ShowDialog();   // to show the login into the main page
        }
    }
}
