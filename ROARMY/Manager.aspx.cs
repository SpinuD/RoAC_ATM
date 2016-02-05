using System;
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
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=ROARMY;Integrated Security=SSPI");
            string connstr = ConfigurationManager.ConnectionStrings["ROARMYConnectionString"].ConnectionString;

            conn.Open();

            string querry = "SELECT Username,Passwod  FROM Personal WHERE Username='" + Login1.UserName + "' and Passwod='" + Login1.Password + "'";
            SqlCommand comanda = new SqlCommand(querry, conn);
            SqlDataReader citire = comanda.ExecuteReader();
            while (citire.Read())
            {
                Response.Redirect("~/PanouControlManager.aspx");
            }  

        }
    }
}