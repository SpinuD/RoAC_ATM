﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ROARMY
{
    public partial class Log_In : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=ROARMY;Integrated Security=SSPI");
            string connstr = ConfigurationManager.ConnectionStrings["ROARMYConnectionString"].ConnectionString;

            conn.Open();

            string querry = "SELECT Username,pass  FROM Comandanti WHERE Username='" + Login1.UserName + "' and pass='" + Login1.Password + "'";
            SqlCommand comanda = new SqlCommand(querry, conn);
            SqlDataReader citire = comanda.ExecuteReader();
            while (citire.Read())
            {
                Response.Redirect("~/PanouControl.aspx");
            }  
            
        }
    }
}