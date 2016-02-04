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
    public partial class PanouControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=ROARMY;Integrated Security=SSPI");
            string connstr = ConfigurationManager.ConnectionStrings["ROARMYConnectionString"].ConnectionString;

            conn.Open();
            string query2 = "select max(ID) from Alocari";
            SqlCommand comanda2 = new SqlCommand(query2, conn);
            int a=(int) comanda2.ExecuteScalar();
            string querry = "INSERT INTO Alocari VALUES (@ID,@comp,@nrstud,@data)";
            SqlCommand comanda = new SqlCommand(querry, conn);
            comanda.Parameters.AddWithValue("@ID", a+1);
            comanda.Parameters.AddWithValue("@data", TextBox4.Text);
            comanda.Parameters.AddWithValue("@nrstud", TextBox3.Text);
            comanda.Parameters.AddWithValue("@comp", TextBox2.Text);

            int nr_row_aff = comanda.ExecuteNonQuery();
            if (nr_row_aff==1)
            {
                Response.Write("Inserarea a avut loc cu succes!!");  
            }
            else
            {
                Response.Write("Inserarea nu s-a efectuat cu succes");
            }

           
           
        }

    }
}