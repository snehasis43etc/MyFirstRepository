using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Log_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "hi") &&
            (TextBox2.Text == "hi"))
            {
                FormsAuthentication.SetAuthCookie(TextBox1.Text, false);

                FormsAuthentication.RedirectFromLoginPage
                (TextBox1.Text, Persist.Checked);
                 //  Response.Redirect("Home.aspx", false);
            }
            else
            {
                Msg.Text = "Invalid credentials. Please try again.";
            }
        }
    }
}