using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.IO;

namespace PunjabiMp3songs
{
    public partial class SongUpload : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["AlbumID"] != null)
            {
                TabContainer1.ActiveTabIndex = 1;

            }
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
            if (value.ToLower().Contains("+"))
            {
                value = value.Replace("+", "");
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

        protected void btnUPload_Click(object sender, EventArgs e)
        {
            if (Session["USERDIID"] != null)
            {
                MasterAlbum an = new MasterAlbum();
                an.AlbumName = txtAlbumName.Text;
                an.AlbumReleaseOn = Convert.ToDateTime(txtSongReleaseDate.Text);
                  
                //if (FileUpImage.FileName.Length > 0)
                //{
                //    string ImgName = string.Empty; 
                //    string filename = Path.GetFileNameWithoutExtension(FileUpImage.FileName);
                //    string fileext = Path.GetExtension(FileUpImage.FileName); 
                //    ImgName = filename + DateTime.Now.ToString("ddMMyyyyhhmmss") + fileext;
                //    FileUpImage.SaveAs(Server.MapPath("~/UploadsIm/" + ImgName)); 
                //    an.CoverImage = ImgName;
                //} 

                an.DateAdded = DateTime.Now;
                an.IsActive = true;
                an.MetaDescription = txtDescription.Text;
                an.MetaTags = txtTags.Text;
                an.MetaTitle = txtAlbumName.Text + " " + txtSingerName.Text;
                an.SingerName = txtSingerName.Text;

                objCon.MasterAlbums.InsertOnSubmit(an);
                objCon.SubmitChanges();

                Response.Redirect("~/SongUpload.aspx?AlbumID=" + an.ID);
                 
            }
        }
        MSContextDataContext objCon = new MSContextDataContext();

        protected void btnTrackUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["USERDIID"] != null)
                {
                    if (Request.QueryString["AlbumID"] != null)
                    {
                        TracksWraper tw = new TracksWraper();
                        tw.DateAdded = DateTime.Now;
                        tw.AlbumID = Convert.ToInt64(Request.QueryString["AlbumID"]);
                          
                        tw.IsApproved = true;
                        tw.MetaDescription = txtAlbumDescription.Text;
                        tw.MetaTags = txtAlbumTags.Text;
                        tw.MetaTitle = txtSongName.Text + " " + txtSingerName.Text;
                        tw.SingerName = txtSingerName.Text;
                        tw.SongTitle = ReplaceName(txtSongName.Text);
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
                        txtAlbumDescription.Text="";
                        txtAlbumTags.Text = "";

                        txtSingerName.Text = "";
                        txtSongName.Text = "";
                        txtSongUrl1.Text = "";
                        txtSongUrl2.Text = "";
                        txtSongUrl3.Text = "";
                        //reset end

                        GridView1.DataBind();
                    } 
                }
            }
            catch (Exception)
            {
                 
            }
        }

        
    }
}