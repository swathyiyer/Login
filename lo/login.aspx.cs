using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace lo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void loginbtn_Click1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconn"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select password from Login where name=@name ", con);
            cmd.Parameters.AddWithValue("@name", nametxt.Text);

            // cmd.Connection = con;

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    string pass = Convert.ToString(sdr[0]);

                    if (passwordtxt.Text == pass.TrimEnd())
                    {
                        FormsAuthentication.RedirectToLoginPage("Register.aspx");
                    }
                
                    else
                    {
                        
                        SqlDataAdapter sqlCmd = null;
                        sqlCmd = new SqlDataAdapter("pro1", con);
                        sqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlCmd.SelectCommand.Parameters.AddWithValue("@name", nametxt.Text.Trim());
                        sqlCmd.SelectCommand.Parameters.AddWithValue("@password", passwordtxt.Text.Trim());
                     
                       Label1.Text = "Invalid username or password";
                    }
                }
            }

        }

        protected void Registerbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
    