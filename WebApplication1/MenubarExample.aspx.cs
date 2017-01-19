using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Menubar
{
    public partial class MenubarExample : System.Web.UI.Page
    {
         protected void Page_Load(object sender, EventArgs e) {
         lblmessage.Text += "Page load event handled. <br />";
         
         if (Page.IsPostBack) {
            lblmessage.Text += "Page post back event handled.<br/>";
         }
      }
      
      protected void Page_Init(object sender, EventArgs e) {
         lblmessage.Text += "Page initialization event handled.<br/>";
      }
      
      protected void Page_PreRender(object sender, EventArgs e) {
         lblmessage.Text += "Page prerender event handled. <br/>";
      }
      
     

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblmessage.Text += "Button click event handled. <br/>";
        }
   

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string
                Message = "You selected " +
         e.Item.Text + ".";
            ScriptManager.RegisterClientScriptBlock(sender as Control, this.GetType(), "alert", "alert('" + e.Item.Text + "')", true);
          //  ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString("N"), "openModal('"  + Message + "');", true);
            lblmessage.Text += "menuitem click event handled. <br/>";
        }

        void Menu1_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            string
             Message = "You selected " +
      e.Item.Text + ".";
            //e.Item.NavigateUrl = "javascript:OpenWindow('" + Message + "')";

}

        }
    }
