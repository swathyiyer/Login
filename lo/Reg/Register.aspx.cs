using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lo.Reg
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
           // FormsAuthentication 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TBRVS7I; Initial Catalog = login; User ID = sa; Password = Suyati123;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Login (id,name,password) values (@id,@name,@password) ", con);
            cmd.Parameters.AddWithValue("@name", nametxt1.Text);
            cmd.Parameters.AddWithValue("@password", passwordtxt1.Text);
            cmd.Parameters.AddWithValue("@id", idtxt1.Text);
            // cmd.Connection = con;

            cmd.ExecuteNonQuery();

            con.Close();
            Response.Redirect("~/Login.aspx");
        }
    }
}