using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs
{
    public partial class singletrack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string ReplaceName(string value)
        {
            if (value.ToLower().Contains(" "))
            {
                value = value.Replace(" ", "-");
            }
            if (value.ToLower().Contains("/"))
            {
                value = value.Replace("/", "-");
            }
            if (value.ToLower().Contains("."))
            {
                value = value.Replace(".", "-");
            }
            if (value.ToLower().Contains("com"))
            {
                value = value.Replace("com", "");
            }
            if (value.ToLower().Contains("in"))
            {
                value = value.Replace("in", "");
            }
            if (value.ToLower().Contains("org"))
            {
                value = value.Replace("org", "");
            }
            if (value.ToLower().Contains("mobi"))
            {
                value = value.Replace("mobi", "");
            }
            if (value.ToLower().Contains("info"))
            {
                value = value.Replace("info", "");
            }
            if (value.Contains("[") || value.Contains("]"))
            {
                value = value.Replace("[", "");
                value = value.Replace("]", "");
            }
            if (value.Contains("(") || value.Contains(")"))
            {
                value = value.Replace("(", "");
                value = value.Replace(")", "");
            }
            return value;
        }

        MSContextDataContext objCon = new MSContextDataContext();
        protected void btnUPload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["USERDIID"] != null)
                {
                    TracksWraper tw = new TracksWraper();
                    tw.DateAdded = DateTime.Now;
                    
                    //if (FileUpImage.FileName.Length > 0)
                    //{
                    //    string ImgName = string.Empty;

                    //    string filename = Path.GetFileNameWithoutExtension(FileUpImage.FileName);
                    //    string fileext = Path.GetExtension(FileUpImage.FileName);

                    //    ImgName = filename + DateTime.Now.ToString("ddMMyyyyhhmmss") + fileext;
                    //    FileUpImage.SaveAs(Server.MapPath("~/UploadsIm/" + ImgName));

                    //    tw.CoverImage = ImgName;
                    //} 
                    tw.IsApproved = true;
                    tw.MetaDescription = txtDescription.Text;
                    tw.MetaTags = txtTags.Text;
                    tw.MetaTitle = txtSongName.Text + " " + txtSingerName.Text;
                    tw.SingerName = txtSingerName.Text;
                    tw.SongTitle =ReplaceName(txtSongName.Text);
                    tw.SongUrl1 = txtSongUrl1.Text;
                    tw.SongUrl2 = txtSongUrl2.Text;
                    tw.SongUrl3 = txtSongUrl3.Text;
                    tw.UsrId = Convert.ToInt64(Session["USERDIID"]);

                    objCon.TracksWrapers.InsertOnSubmit(tw);
                    objCon.SubmitChanges();

                    //add top 20
                    if (chkTop20.Checked == true)
                    {
                        Top20MonthMapping mp20 = new Top20MonthMapping();
                        mp20.DateAdded = DateTime.Now;
                        mp20.IsActive = true;
                        mp20.SongID = tw.ID;
                        objCon.Top20MonthMappings.InsertOnSubmit(mp20);
                        objCon.SubmitChanges();
                    }
                    //

                    lblMsg.Text = "Submit Successfully.";

                    //reset start
                    txtDescription.Text = "";
                    txtTags.Text = "";

                    txtSingerName.Text = "";
                    txtSongName.Text = "";
                    txtSongUrl1.Text = "";
                    txtSongUrl2.Text = "";
                    txtSongUrl3.Text = "";
                    //reset end
                }
            }
            catch (Exception)
            {
                 
            }
        }
    }
}