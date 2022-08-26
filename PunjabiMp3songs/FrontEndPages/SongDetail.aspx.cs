using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;

namespace PunjabiMp3songs.FrontEndPages
{
    public partial class SongDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["songid"] != null)
            { 
                BindInfo(Request.QueryString["songid"]);
                BindSeo(Request.QueryString["songid"]);
            }
        }

        private void BindSeo(string p)
        {
            try
            {
                StarMethods sm = new StarMethods();
                DataTable dt = new DataTable();
                dt = sm.GetTracksDetail(Convert.ToInt64(p));
                if (dt.Rows.Count > 0)
                {
                   
                    Page.MetaDescription = dt.Rows[0]["MetaDescription"].ToString();
                    Page.Title = dt.Rows[0]["MetaTitle"].ToString();
                    Page.MetaKeywords = dt.Rows[0]["MetaTags"].ToString();


                    string meta = "<link href=\"https://plus.google.com/" + dt.Rows[0]["GmailUrl"].ToString() + "\" rel=\"author\" />";
                    Literal cssLiteral2 = new Literal();
                    cssLiteral2.Text = meta;
                    Page.Header.Controls.Add(cssLiteral2);
                     
                    HtmlMeta tagadmins = new HtmlMeta();
                    tagadmins.Attributes.Add("property", "fb:admins");
                    tagadmins.Content = dt.Rows[0]["FacebookUrl"].ToString();
                    Page.Header.Controls.Add(tagadmins);

                    HtmlMeta tag = new HtmlMeta();
                    tag.Attributes.Add("property", "og:title");
                    tag.Content = dt.Rows[0]["SongTitle"].ToString();
                    Page.Header.Controls.Add(tag);

                    HtmlMeta tagType = new HtmlMeta();
                    tagType.Attributes.Add("property", "og:type");
                    tagType.Content = "song";
                    Page.Header.Controls.Add(tagType);

                    HtmlMeta tagSiteName = new HtmlMeta();
                    tagSiteName.Attributes.Add("property", "og:site_name");
                    tagSiteName.Content = "punjabimp3songs.in";
                    Page.Header.Controls.Add(tagSiteName);

                    HtmlMeta tag1 = new HtmlMeta();
                    tag1.Attributes.Add("property", "og:description");
                    tag1.Content = dt.Rows[0]["MetaDescription"].ToString();
                    Page.Header.Controls.Add(tag1);

                    HtmlMeta tagurl = new HtmlMeta();
                    tagurl.Attributes.Add("property", "og:url");
                    tagurl.Content = Request.RawUrl.ToString();
                    Page.Header.Controls.Add(tagurl);

                    HtmlMeta tagimg = new HtmlMeta();
                    tagimg.Attributes.Add("property", "og:img");
                    tagimg.Content = Page.ResolveUrl("~/UploadsIm/" + dt.Rows[0]["CoverImage"].ToString());
                    Page.Header.Controls.Add(tagimg);
                }
        
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BindInfo(string p)
        {
            try
            {
                StarMethods sm = new StarMethods();
                DataTable dt = new DataTable();
                dt = sm.GetTracksDetail(Convert.ToInt64(p));
                if (dt.Rows.Count > 0)
                {
                   
                    StringBuilder sb = new StringBuilder();

                    sb.Append("<h3 class=\"pageTitle\"> " + dt.Rows[0]["SongTitle"].ToString() + "</h3>  <div class=\"albumCover\">");
                    //sb.Append("<img alt=\"\" src=\"" + Page.ResolveUrl("~/UploadsIm/" + dt.Rows[0]["CoverImage"].ToString() + "") + "\" />
                    sb.Append("<div class=\"clear\"></div> </div>");
                  
                    sb.Append("<div class=\"albumInfo\"> ");
                    //if (dt.Rows[0]["AlbumID"].ToString() != "")
                    //{
                    //    sb.Append("<p class=\"style18\"> <b>Album</b>:<span class=\"style24\"> " + dt.Rows[0]["AlbumID"].ToString() + "</span></p>");
                    //}
                    if (dt.Rows[0]["SingerName"].ToString() != "")
                    {
                        sb.Append(" <p class=\"style18\">  <b>Singer</b>:<span class=\"style24\"> " + dt.Rows[0]["SingerName"].ToString() + "</span> </p>");
                    }
                    string dcound = dt.Rows[0]["DownloadCount"].ToString().Length > 0 ? dt.Rows[0]["DownloadCount"].ToString() : "0";
                    sb.Append("<p class=\"style18\"> <b>Downloads</b>:<span class=\"style24\"> (" + dcound + ") </span> </p>");
                    sb.Append("<div class=\"clear\"></div> </div>");
                     
                    LitTopInfo.Text= sb.ToString();
                    ///////////////////////////////////////////

                    sb = null;
                    sb = new StringBuilder();

                    if (dt.Rows[0]["SongUrl1"].ToString().Length > 2)
                    {
                        sb.Append("<p class=\"track\"> <span class=\"arr\">»</span> ");
                        sb.Append("<a href=\"/download_server1/" + p + "/" + dt.Rows[0]["SongTitle"] + "\">Download From Server 1 </a><small> </small> </p>");
                    }
                    if (dt.Rows[0]["SongUrl2"].ToString().Length > 2)
                    {
                        sb.Append("<p class=\"track\"> <span class=\"arr\">»</span> ");
                        sb.Append("<a href=\"/download_server2/" + p + "/" + dt.Rows[0]["SongTitle"] + "\">Download From Server 2</a> <small> </small>  </p>");
                    }
                    if (dt.Rows[0]["SongUrl3"].ToString().Length > 2)
                    {
                        sb.Append("<p class=\"track\"> <span class=\"arr\">»</span> ");
                        sb.Append("<a href=\"/download_server3/" + p + "/" + dt.Rows[0]["SongTitle"] + "\">Download From Server 3</a> <small> </small>  </p>");
                    }

                    litSongBind.Text = sb.ToString();

                    sb = null;

                    sb = new StringBuilder();

                    if (hideSongPlay.Value.Length > 0)
                    {
                        if (dt.Rows[0]["SongUrl1"].ToString().Length > 2)
                        {
                            sb.Append("<object type=\"application/x-shockwave-flash\" data=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download_server1/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" width=\"200\" height=\"20\" id=\"dewplayer\">");
                            sb.Append("<param name=\"wmode\" value=\"transparent\" />");
                            sb.Append("<param name=\"movie\" value=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download_server1/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" /> </object>");
                        }
                        else if (dt.Rows[0]["SongUrl2"].ToString().Length > 2)
                        {
                            sb.Append("<object type=\"application/x-shockwave-flash\" data=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download_server2/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" width=\"200\" height=\"20\" id=\"dewplayer\">");
                            sb.Append("<param name=\"wmode\" value=\"transparent\" />");
                            sb.Append("<param name=\"movie\" value=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download_server2/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" /> </object>");
                        }
                        else if (dt.Rows[0]["SongUrl3"].ToString().Length > 2)
                        {
                            sb.Append("<object type=\"application/x-shockwave-flash\" data=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download_server3/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" width=\"200\" height=\"20\" id=\"dewplayer\">");
                            sb.Append("<param name=\"wmode\" value=\"transparent\" />");
                            sb.Append("<param name=\"movie\" value=\"" + Page.ResolveUrl("~/dewplayer.swf?mp3=" + Page.ResolveUrl("/download_server3/" + p + "/" + dt.Rows[0]["SongTitle"] + "")) + "\" /> </object>");
                        }

                        LitPlayer.Text = sb.ToString();
                    }
                    ///////////////////////////////////////
                    sb = null;
                    sb = new StringBuilder();
                   


                    sb.Append("<div class=\"commentWrapper\"> <div class=\"commentAvatar\" style=\"margin-right:10px;border-radius:50%;\"><img src=\"" + Page.ResolveUrl("~/userimg/" + dt.Rows[0]["UserImage"].ToString()) + "\" /></div>");
                    sb.Append("<div class=\"singlePostInfoWrapper\"><span class=\"singleIconWrapper singleIconText iconCalendarDark postInfo postDate\">" + dt.Rows[0]["DateAdded"].ToString().ConvertToDate().ToString("dd MMM yyyy") + "</span><div class=\"singleIconWrapper singleIconText iconEditDark postInfo postAuthor postInfoNoMargin\">Posted By <b class='highlight highlightOrange'>" + dt.Rows[0]["UserName"].ToString() + "</b> </div></div> </div>");

                    litPostedByINFO.Text = sb.ToString();



                }
            }
            catch (Exception EX)
            {
                
            }
        }

        

        protected void lbtnPlay_Click(object sender, EventArgs e)
        {
            hideSongPlay.Value = "202";
            if (Request.QueryString["songid"] != null)
            {
                BindInfo(Request.QueryString["songid"]);
            }
        }
    }
}