using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string r = Context.Response.Cookies.ToString();
            //string rq = Context.Request.Cookies.ToString();

            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
            //Response.Cache.SetNoStore();
            //Response.AppendHeader("Pragma", "no-cache");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            ////Clear Cookies
            //List<string> cookiesToClear = new List<string>();
            //foreach (string cookieName in Context.Request.Cookies)
            //{
            //    HttpCookie cookie = Context.Request.Cookies[cookieName];
            //    cookiesToClear.Add(cookie.Name);
            //}
            //Context.Response.Cookies.Clear();
            //foreach (string name in cookiesToClear)
            //{
            //    HttpCookie cookie = new HttpCookie(name, string.Empty);
            //    if (name == FormsAuthentication.FormsCookieName)
            //    {
            //        cookie.Domain = FormsAuthentication.CookieDomain;
            //        cookie.HttpOnly = true;
            //        cookie.Path = FormsAuthentication.FormsCookiePath;
            //    }
            //    cookie.Expires = DateTime.Today.AddYears(-1);
            //    Context.Response.Cookies.Set(cookie);
            //}
            //Context.Request.Cookies.Clear();
           
            Response.Redirect("LogIn.aspx", false);
        }
    }
}