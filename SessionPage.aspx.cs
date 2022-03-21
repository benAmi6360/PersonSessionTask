using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SessionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateDisplayWithSession();
        }
        private void UpdateDisplayWithSession()
        {
            Person p = Session["UserPerson"] as Person;
            Response.Write("<p> Name: " + p.name + "</p>");
            Response.Write("<p> City: " + p.city + "</p>");
            Response.Write("<p> Email: " + p.email + "</p>");
        }
    }
}