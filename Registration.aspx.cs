using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from Users where Username='"+TextBoxUsername.Text+"'";
            SqlCommand comm = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already exists");
            }

            conn.Close();
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into Users (Username, Email, Password, Age) values (@username, @email, @password, @age)";
            SqlCommand comm = new SqlCommand(insertQuery, conn);
            comm.Parameters.AddWithValue("@username", TextBoxUsername.Text );
            comm.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            comm.Parameters.AddWithValue("@password", TextBoxPassword.Text);
            comm.Parameters.AddWithValue("@age", DropDownListAge.SelectedItem.ToString());
            comm.ExecuteNonQuery();
            Response.Redirect("Manager.aspx");
            Response.Write("Registration was successful!");

            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.Message);
        }
    }
}