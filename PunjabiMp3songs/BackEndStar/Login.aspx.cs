using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs.BackEndStar
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                validData vald = new validData();

                Datastar objds = new Datastar();

                dt = objds.getLoginBackend(vald.ValidateData(txtEamailID.Text), vald.ValidateData(txtPw.Text));

                if (dt.Rows.Count > 0)
                {
                    Session["USERDIID"] = dt.Rows[0]["ID"];
                    Session["USERDANAME"] = dt.Rows[0]["UserName"];
                    Response.Redirect("/welcomestar");
                }
                else
                {
                    lblmsg.Text = "! Invalid";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}