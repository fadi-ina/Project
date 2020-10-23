using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace Product_Management.DAL
{
    class Dataaccesslayer
    {
        SqlConnection sqlconnection; 
        // we will give the para in the constructor cuz construc implement auto when class create
        public Dataaccesslayer()    
            // here create constructor like func no return value
        {
            sqlconnection = new SqlConnection(@"Server=COMPUTER; Database=Product_DB; Integrated Security=true");
            // here create new one the name server that we are using, then the name of the database then security true because using windows authontication 
        
            // open connection
        }
        public void Open()
                   { // this is to ensure that the connection is open
                if(sqlconnection.State != ConnectionState.Open)
                {
                    sqlconnection.Open();

                }
                     }
        public void Close()
            {   // this is to close the connection between the server and app
                if(sqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                }
            }
        public DataTable select_data(string store_para, SqlParameter[] param) // read the data from database
            // this will contain data
        { 
            // first one is the name of the store parameter 
            // second is the number of para that this can receive
            //to emplement the store_aprameter we have to use this 
            SqlCommand sqlcmd = new SqlCommand();
            // specificed the type of this command 
            sqlcmd.CommandType = CommandType.StoredProcedure;
            // the name that this cmd should do is the store_para .. excute
            sqlcmd.CommandText = store_para;
            //
            sqlcmd.Connection = sqlconnection; // put it here also here we have to specify that the command should work on what connection 

            if (param != null)
            { // here if we have othe para we have to .. if not we excute the soted_para
                for(int i=0;i<param.Length;i++)
                { // if there is parameters we have to go to all of them add them to cmd excute them 
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            // now read the data that comes out of this cmd 
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd); // this is to excute the sql cmd for the parameter
            // then after out comes we have to store this data into tables to create new one
            DataTable dt = new DataTable();
            da.Fill(dt); // put result in data table 
            // now retrn the data
            return dt;
        }
        // this method is to insert and delete or edit from the database
        public void Excutecommand(string stor_para, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stor_para;
            sqlcmd.Connection = sqlconnection; // put it here also here we have to specify that the command should work on what connection 
            if (param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            sqlcmd.ExecuteNonQuery(); // we use this because there is no return for this function
            // there is no need for sqldataadapter becuase no incoming data just out 

        }



    }
}
