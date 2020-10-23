using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   // add this important
using System.Data;

namespace Product_Management.BL
{
    class LoginBL
    {
        // create a function that excute the store procedure in the sql server
        // we don't need any procedure like to edit or add but we need a function just to read and check
        public DataTable logincheck(string ID , string Pass)   // here this para comes from the form 
        {
            // need to check if the store procedure have a parameters or no so 
            DAL.Dataaccesslayer DAL = new DAL.Dataaccesslayer();
            // we created a copy from the DAL to check if there is any parameters? i mean pass and id are parameters
            // also we need the open function for the session in DAL

            SqlParameter[] param = new SqlParameter[2];   // create matrix for the two parameters 
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);  // now create the first one with the same name as in DB and same Dtype also the size
            // now have to give value for this para through
            param[0].Value = ID;  // the id comes from the form

            param[1] = new SqlParameter("@Pass", SqlDbType.VarChar, 50);
            param[1].Value = Pass;
            DAL.Open();   // open the session or the connection
            // so here we need to excute the procesurte store in the DB throught the datatable store procedure in DAL becuse it is just to read no need to excute.
            // the function that we are using in the DAL is Datatable type so we need to define new one here
            DataTable dt = new DataTable();
            dt = DAL.select_data("Store_Procedure_loign", param); // here we give the store procedure like in the sql DB and also the parameter that wehave define it above in the matrix
            // now the datatable contian the value of the excuted return the dt
            DAL.Close();
            return dt;



        }



    }
}
