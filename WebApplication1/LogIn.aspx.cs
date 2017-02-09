using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Log_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////XElement xelement = XElement.Load("C:\\Users\\gangus\\Documents\\Visual Studio 2012\\Projects\\My Test Project\\WebApplication1\\Employees.xml");
            ////var name = from nm in xelement.Elements("Employee")
            ////           where (string)nm.Element("Sex") == "Female"
            ////           select nm;

            //XElement xelement = XElement.Load("C:\\Users\\gangus\\Documents\\Visual Studio 2012\\Projects\\My Test Project\\WebApplication1\\UserRole.xml");
            //var name = from c in xelement.Elements("User")
            //           where (string)c.Element("email") == TextBox1.Text.Trim()
            //           select c.Element("Role").Value;
        }

        public string GetRole()
        {
            XElement xelement = XElement.Load("C:\\Users\\gangus\\Documents\\Visual Studio 2012\\Projects\\My Test Project\\WebApplication1\\UserRole.xml");
            var name = from c in xelement.Elements("User")
                       where (string)c.Element("email") == TextBox1.Text.Trim()
                       select c.Element("Role").Value;
           
            return name.ToString();

        }

        public void Selectmaster()
        {
            string role = GetRole();
            Session["Role"] = role;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == TextBox2.Text)
            {
                Session["LoginName"] = TextBox1.Text;



                if (Request.QueryString["ReturnURL"] != null)
                {
                    FormsAuthentication.RedirectFromLoginPage
                        (TextBox1.Text, Persist.Checked);
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(TextBox1.Text, Persist.Checked);
                    Response.Redirect("Home.aspx", false);
                }
            }
            else
            {
               
                Msg.Text = "Invalid credentials. Please try again.";
            }
        }
    }
}