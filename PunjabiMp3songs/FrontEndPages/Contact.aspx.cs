using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs.FrontEndPages
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length > 0 && txtMsg.Text.Length > 0 && txtEmail.Text.Length > 0)
                {
                    MSContextDataContext objCon = new MSContextDataContext();
                    msgbox mbox = new msgbox();
                    mbox.EMAILID = txtEmail.Text;
                    mbox.IP = Request.UserHostAddress;
                    mbox.MSG = txtMsg.Text;
                    mbox.NAME = txtName.Text;
                    objCon.msgboxes.InsertOnSubmit(mbox);
                    objCon.SubmitChanges();

                    formSuccessMessageWrapper.Attributes.Add("style", "display:block;");
                }

            }
            catch (Exception)
            {
                 
            }
        }
    }
}