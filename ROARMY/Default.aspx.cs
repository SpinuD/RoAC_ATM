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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Log_In.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Manager.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personal_login.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=ROARMY;Integrated Security=SSPI");
            string connstr = ConfigurationManager.ConnectionStrings["ROARMYConnectionString"].ConnectionString;

            conn.Open();

            string querry = "SELECT * FROM Meniu ";
            SqlCommand comanda = new SqlCommand(querry, conn);
            GridView2.DataSource=comanda.ExecuteReader();
            GridView2.DataBind();

            
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=ROARMY;Integrated Security=SSPI");
            string connstr = ConfigurationManager.ConnectionStrings["ROARMYConnectionString"].ConnectionString;
            conn.Open();
            string query2 = "select max(ID) from Sugestii";
            SqlCommand comanda2 = new SqlCommand(query2, conn);
            int a = (int)comanda2.ExecuteScalar();
            string querry = "INSERT INTO Sugestii VALUES (@ID,@nume,@prenume,@sugestie)";
            SqlCommand comanda = new SqlCommand(querry, conn);
            comanda.Parameters.AddWithValue("@ID", a + 1);
            comanda.Parameters.AddWithValue("@nume", TextBox1.Text);
            comanda.Parameters.AddWithValue("@prenume", TextBox2.Text);
            comanda.Parameters.AddWithValue("@sugestie", TextBox3.Text);

            comanda.ExecuteNonQuery();
        }
    }
}