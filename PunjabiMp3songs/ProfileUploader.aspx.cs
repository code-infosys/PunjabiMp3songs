using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs
{
    public partial class ProfileUploader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERDIID"] != null)
            {
                if (!Page.IsPostBack)
                {
                    MSContextDataContext objMs = new MSContextDataContext();
                    var Query = objMs.UserUploaders.Single(i => i.ID == Convert.ToInt64(Session["USERDIID"]));
                    if (Query != null)
                    {
                        txtFbLInk.Text = Query.FacebookUrl;
                        txtGmailLink.Text = Query.GmailUrl;
                        txtMobileNO.Text = Query.MobileNo;
                        userimage.ImageUrl = Page.ResolveUrl("~/userimg/"+Query.UserImage);
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["USERDIID"] != null)
                {
                    MSContextDataContext objMs = new MSContextDataContext();
                    UserUploader up= objMs.UserUploaders.Single(i=>i.ID==Convert.ToInt64(Session["USERDIID"]));
                    up.GmailUrl = txtGmailLink.Text;
                    up.FacebookUrl = txtFbLInk.Text;
                    up.DateModified = DateTime.Now; 
                    up.MobileNo = txtMobileNO.Text;

                    if (FUimgCover.FileName.Length > 0)
                    { 
                        string coverext = Path.GetExtension(FUimgCover.FileName);
                        string coverfname = Path.GetFileNameWithoutExtension(FUimgCover.FileName);
                        string d = DateTime.Now.ToString("ddmmyyyyhhmmss");
                        string imgpath = Server.MapPath("~/userimg/" + coverfname + d + coverext);
                        FUimgCover.SaveAs(imgpath);
                        up.UserImage = coverfname + d + coverext;
                    }
                    if (txtPassword.Text.Length > 0)
                    {
                        up.UserPW = txtPassword.Text;
                    }

                    objMs.SubmitChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}