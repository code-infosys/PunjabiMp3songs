using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using StarMethods;
namespace PunjabiMp3songs
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string main_path = Request.Path.ToLower();

            if (StarHelper.BeginRequest() == true)
            {

                if (main_path.IndexOf("/single_track_list/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];

                    Context.RewritePath(String.Concat("~/FrontEndPages/SongDetail.aspx?songid=", page), false);
                }
                if (main_path.IndexOf("/single_-tracks/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];

                    Context.RewritePath(String.Concat("~/FrontEndPages/ByMonthTracks.aspx?monthid=", page), false);
                }


                if (main_path.IndexOf("/uploadsmf_") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"_");
                    String page = txt[txt.Length - 1];
                    Context.RewritePath(String.Concat("~/SongUpload.aspx?songid=", page), false);

                }
                if (main_path.IndexOf("/latest_album/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];
                    Context.RewritePath(String.Concat("~/FrontEndPages/latestalbDetail.aspx?laID=", page), false);
                }
                //




                if (main_path.IndexOf("/download_server1/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];

                    DataTable dt = GetSong(page);
                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect(dt.Rows[0]["SongUrl1"].ToString());

                    }

                }

                if (main_path.IndexOf("/download_server2/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];

                    DataTable dt = GetSong(page);
                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect(dt.Rows[0]["SongUrl2"].ToString());

                    }

                }

                if (main_path.IndexOf("/download_server3/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];

                    DataTable dt = GetSong(page);
                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect(dt.Rows[0]["SongUrl3"].ToString());

                    }

                }

                 
                if (Request.RawUrl.Contains("/login"))
                {
                    Context.RewritePath("~/login.aspx");
                }
                if (Request.RawUrl.Contains("/register"))
                {
                    Context.RewritePath("~/register.aspx");
                }
                if (Request.RawUrl.Contains("/Dashboard"))
                {
                    Context.RewritePath("~/home.aspx");
                }
                if (Request.RawUrl.Contains("/addsong"))
                {
                    Context.RewritePath("~/SongUpload.aspx");
                }
                if (Request.RawUrl.Contains("/MyUploadsList"))
                {
                    Context.RewritePath("~/MySongsList.aspx");
                }
                if (Request.RawUrl.Contains("/MyProfile"))
                {
                    Context.RewritePath("~/ProfileUploader.aspx");
                }
                if (Request.RawUrl.Contains("/singletrack"))
                {
                    Context.RewritePath("~/singletrack.aspx");
                }

                if (Request.RawUrl.Contains("/latest/single-tracks"))
                {
                    Context.RewritePath("~/FrontEndPages/LatestTracks.aspx");
                }
                if (Request.RawUrl.Contains("/by-month/single-tracks"))
                {
                    Context.RewritePath("~/FrontEndPages/ByMonthTracks.aspx");
                }

                if (Request.RawUrl.Contains("/latest/albums"))
                {
                    Context.RewritePath("~/FrontEndPages/latestalb.aspx");
                }

                if (Request.RawUrl.Contains("/top20/monthly"))
                {
                    Context.RewritePath("~/FrontEndPages/Top20MonthlyTracks.aspx");
                }
                if (Request.RawUrl.Contains("/a-to-z/single-tracks"))
                {
                    Context.RewritePath("~/FrontEndPages/AtoZTracks.aspx");
                }
                if (Request.RawUrl.Contains("/AssignTop20"))
                {
                    Context.RewritePath("~/AssignTop20.aspx");
                }
                if (Request.RawUrl.Contains("/contactus"))
                {
                    Context.RewritePath("~/FrontEndPages/Contact.aspx");
                }

                if (Request.RawUrl.Contains("/search"))
                {
                    Context.RewritePath("~/FrontEndPages/SearchBox.aspx");
                }

                if (Request.RawUrl.Contains("/song/upload"))
                {
                    Context.RewritePath("~/BackEndStar/YouUpload.aspx");
                }
                


                if (main_path.IndexOf("/a_to_z/") >= 0)
                {
                    String[] txt = Regex.Split(HttpContext.Current.Request.Url.ToString(), @"/");
                    String page = txt[txt.Length - 2];

                    Context.RewritePath(String.Concat("~/FrontEndPages/AtoZTracks.aspx?alphaid=", page), false);
                }
            }
        }
        private static DataTable GetSong(String page)
        {
            StarMethods sm = new StarMethods();
            DataTable dt = new DataTable();
            dt = sm.GetTracksDownload(Convert.ToInt64(page));
            return dt;
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}