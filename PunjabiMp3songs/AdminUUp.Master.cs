using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs
{
    public partial class AdminUUp : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            form1.Action = Request.RawUrl;
            if (Session["USERDIID"] != null)
            {

            }
            else
            {
                Response.Redirect("/login");
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            if (Session["USERDIID"] != null)
            {
                Session["USERDIID"] = "";
                Session.Abandon();
                Response.Redirect("/login");
            }
        }
    }
}