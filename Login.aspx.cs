using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from Users where Username='"+TextBoxUsernameLogin.Text+"'";
            SqlCommand comm = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
            if (temp == 1)
            {
                string checkPasswordQuery = "select password from Users where Username='" + TextBoxUsernameLogin.Text + "'";
                SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
                if (password == TextBoxPasswordLogin.Text)
                {
                    Session["New"]=TextBoxUsernameLogin.Text;
                    Response.Write("Password is correct");
                }
                else
                {
                    Response.Write("Password is incorrect!");
                }
            }
            else
            {
                Response.Write("Username is not correct");
            }

            conn.Close();
    }
}