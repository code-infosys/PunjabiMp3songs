using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                validData valid = new validData();
                if (txtEmailid.Text.Length > 0 && txtName.Text.Length > 0 && txtPw.Text.Length > 0)
                {
                    MSContextDataContext objMs = new MSContextDataContext();
                    UserUploader up = new UserUploader();
                    up.UserPW = valid.ValidateData(txtPw.Text);
                    up.UserName = valid.ValidateData(txtName.Text);
                    up.EmailID = valid.ValidateData(txtEmailid.Text);

                    up.DateAdded = DateTime.Now;
                    up.DateModified = DateTime.Now;
                    up.IsDeleted = false;
                    objMs.UserUploaders.InsertOnSubmit(up);
                    objMs.SubmitChanges();

                    lblmsg.Text = "Registered Successfully.";
                }
                else
                {
                    txtPw.Attributes.Add("style", "border:1px solid red;");
                    txtName.Attributes.Add("style", "border:1px solid red;");
                    txtEmailid.Attributes.Add("style", "border:1px solid red;");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}