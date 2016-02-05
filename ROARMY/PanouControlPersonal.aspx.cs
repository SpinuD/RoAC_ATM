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
    public partial class PanouControlPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=ROARMY;Integrated Security=SSPI");
            string connstr = ConfigurationManager.ConnectionStrings["ROARMYConnectionString"].ConnectionString;

            conn.Open();
            string query="SELECT Cantitate from Produse where Produs='"+DropDownList1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int total_cant = (int)cmd.ExecuteScalar();
            int cant =total_cant-Int32.Parse(TextBox1.Text);
            string querry = "UPDATE Produse SET Cantitate=@cant WHERE Produs='"+DropDownList1.Text+"'";
            SqlCommand comanda = new SqlCommand(querry, conn);
            comanda.Parameters.AddWithValue("@cant", cant);
            comanda.ExecuteNonQuery();
            Response.Write("Inserare Reusita!!");
           
           // Response.Redirect("~/PanouControlPersonal.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}