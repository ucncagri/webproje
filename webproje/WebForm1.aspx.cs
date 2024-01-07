using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproje
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void nametxt0_TextChanged(object sender, EventArgs e)
        {

        }

    

        protected void Button1_Click1(object sender, EventArgs e)


        {

            string email = mailttxt.Text.Trim();
            string pass = passtxt.Text.Trim();



            if (!IsValidEmail(email))
            {

                lblMessage.Text = "unvalid e mail!";
                return;
            }
            if (!IsValidPass(pass))
            {

                lblMessage.Text = "Unvalid password! min 8 character one uppercase one lowercase and one digit";
                return;
            }
            if (string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(surnametxt.Text) || string.IsNullOrEmpty(usertxt.Text) ||
   string.IsNullOrEmpty(mailttxt.Text) || string.IsNullOrEmpty(passtxt.Text))
            {
                lblMessage.Text = "fill the empty places";
            }
            else
            {




                string ins = "Insert into [Table] (Name,Surname,Username,Email,password) values ('" + nametxt.Text + "','" + surnametxt.Text + "','" + usertxt.Text + "','" + mailttxt.Text + "','" + passtxt.Text + "')";
            SqlCommand com = new SqlCommand(ins, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
                lblMessage.Text = "Register Succesful";
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidPass(string pass)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";


            return Regex.IsMatch(pass, pattern);
        }






    }

}