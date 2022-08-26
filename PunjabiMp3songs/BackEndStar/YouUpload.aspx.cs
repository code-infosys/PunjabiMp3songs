using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI.Skins;
namespace PunjabiMp3songs.BackEndStar
{
    public partial class YouUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                //if (RadAsyncUpload1.UploadedFiles[0].FileName.Length>0 && txtAboutSong.Text.Length > 0 && txtEmailID.Text.Length > 0 && txtMobileNumber.Text.Length > 0 && txtSingerName.Text.Length > 0 && txtSongName.Text.Length > 0)
                //{
                //    MSContextDataContext objCon = new MSContextDataContext();
                //    CloudUploading cu = new CloudUploading();
                //    cu.AboutSong = txtAboutSong.Text;
                //    cu.DateAdded = DateTime.Now;
                //    cu.EmailID = txtEmailID.Text;

                   
                //    string ext = Path.GetExtension(RadAsyncUpload1.UploadedFiles[0].FileName);
                //    string fname = Path.GetFileNameWithoutExtension(RadAsyncUpload1.UploadedFiles[0].FileName);
                //    string filename = ReplaceName(fname) + "_-(PunjabiMp3songs.In)" + ext;
                //    string mappath = Server.MapPath("~/UploadsIm/" + filename);
                //    RadAsyncUpload1.UploadedFiles[0].SaveAs(mappath);
                //    cu.FileName = filename;

                //    cu.IP = Request.UserHostAddress;
                //    cu.IsApproved = false;
                //    cu.MobileNumber = txtMobileNumber.Text;
                //    cu.SingerName = txtSingerName.Text;
                //    cu.SongTitle = txtSongName.Text;
                //    cu.uid = null;

                //    objCon.CloudUploadings.InsertOnSubmit(cu);
                //    objCon.SubmitChanges();

                //    lblMsg.Visible = true;

                //    txtSongName.Text = "";
                //    txtSingerName.Text = "";
                //    txtMobileNumber.Text = "";
                //    txtEmailID.Text = "";
                //    txtAboutSong.Text = "";
                //}

                buttonSubmit.Focus();
                if (FileUpload1.FileName.Length > 0 && txtAboutSong.Text.Length > 0 && txtEmailID.Text.Length > 0 && txtMobileNumber.Text.Length > 0 && txtSingerName.Text.Length > 0 && txtSongName.Text.Length > 0)
                {
                    MSContextDataContext objCon = new MSContextDataContext();
                    CloudUploading cu = new CloudUploading();
                    cu.AboutSong = txtAboutSong.Text;
                    cu.DateAdded = DateTime.Now;
                    cu.EmailID = txtEmailID.Text;


                    string ext = Path.GetExtension(FileUpload1.FileName);
                    string fname = Path.GetFileNameWithoutExtension(FileUpload1.FileName);
                    string filename = ReplaceName(fname) + "_-(PunjabiMp3songs.In)" + ext;
                    string mappath = Server.MapPath("~/UploadsIm/" + filename);
                    FileUpload1.SaveAs(mappath);
                    cu.FileName = filename;

                    cu.IP = Request.UserHostAddress;
                    cu.IsApproved = false;
                    cu.MobileNumber = txtMobileNumber.Text;
                    cu.SingerName = txtSingerName.Text;
                    cu.SongTitle = txtSongName.Text;
                     
                    objCon.CloudUploadings.InsertOnSubmit(cu);
                    objCon.SubmitChanges();

                    lblMsg.Visible = true;

                    txtSongName.Text = "";
                    txtSingerName.Text = "";
                    txtMobileNumber.Text = "";
                    txtEmailID.Text = "";
                    txtAboutSong.Text = "";
                }

            }
            catch (Exception)
            { 
            }
            

        }
        public string ReplaceName(string value)
        {
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
            if (value.ToLower().Contains("www"))
            {
                value = value.Replace("www", "");
            }
            if (value.ToLower().Contains("net"))
            {
                value = value.Replace("net", "");
            }
            if (value.ToLower().Contains("in"))
            {
                value = value.Replace("in", "");
            }
            if (value.ToLower().Contains("org"))
            {
                value = value.Replace("org", "");
            }
            if (value.ToLower().Contains("+"))
            {
                value = value.Replace("+", "");
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
    }
}