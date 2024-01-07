using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproje
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string check = "select count(*) from [Table] where  Username COLLATE Latin1_General_CS_AS ='" + usertxt.Text + "'and password COLLATE Latin1_General_CS_AS ='" + passtxt.Text + "' ";
            SqlCommand com = new SqlCommand(check, con);
            con.Open();
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            con.Close();

            if (temp == 1)
            {
                Session["KullaniciAdi"] = usertxt.Text;
                Response.Redirect("WebForm3.aspx");
            }
            else
            {
                Label1.Text = "your username or password invalid";
            }
        }
    }
}