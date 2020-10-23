using Product_Management.BL;
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
{
    public partial class Login_Form : Form
    {
        BL.LoginBL loginc = new BL.LoginBL();  // firslty creat a instence from class to check 


        public Login_Form()
        {

            InitializeComponent();
        }
        private void Password_Click(object sender, EventArgs e)
        {
          
        }
        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            DataTable datat = loginc.logincheck(textid.Text, textpass.Text);
            // after checking function will return nothing if it is incorrect but return a value if correct
            if (datat.Rows.Count > 0) // here means that if the password is correct then there is the id and pass in datat else there is nothing 
                                      // the pass or id was wrong so to check if it is incorrect show a text box on the screen, check the rows in the table if there is 
                                      // any data in 
            {
                // so after login in we have to show the main menu by enable it 
                // we don't have access to the form so create an instance 
                main_form frm = new main_form();
                // now we cannot access to the main strip menu because it is private in the source make it all field public
                //frm.usersToolStripMenuItem.Enabled = true;     // but we can see it will not change the state of the field because this is an instance and 
                // not a exctued main form so we have to make this excuted by the main form
                //frm.customersToolStripMenuItem.Enabled = true;
                //frm.productsToolStripMenuItem.Enabled = true;
                // so this way will not work try the handler


                MessageBox.Show("login success");
            }
            else
            { MessageBox.Show("You don't have right access to this progra, Please contact your adminstrator"); }
        }
    }
}
