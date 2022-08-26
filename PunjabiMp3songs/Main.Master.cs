using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            form1.Action = Request.RawUrl;
            
            addHeaders();
        }

        private void addHeaders()
        {
            try
            {

                string meta = "";

                if (Request.RawUrl.IndexOf("single_track_list") >= 0)
                { }
                else{ 
                    Page.Title = "Punjabi Mp3 Songs | Download Punjabi Songs | Punjabi Music | Free Mp3 Songs";
                    meta += "<meta name=\"description\" content=\"Download free latest Punjabi mp3 songs & punjabi music collection only on punjabimp3songs.in\">";
                    meta += "<meta name=\"keywords\" content=\"punjabimp3songs.in, download mp3 songs, punjabi mp3 songs, Punjabi music, New punjabi Songs, latest Punjabi songs, punjabi mp3 sad songs, mp3 songs\">";
                }

                meta += "<link href=\"" + ResolveUrl("~/Theme/css/framework.css") + "\" rel=\"Stylesheet\" type=\"text/css\"  media=\"all\" />";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/colorbox.css") + "\" rel=\"Stylesheet\" type=\"text/css\" media=\"all\"/>";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/elements.css") + "\" rel=\"Stylesheet\" type=\"text/css\" media=\"all\"/>";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/style.css") + "\" rel=\"Stylesheet\" type=\"text/css\" media=\"all\"/>";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/responsive.css") + "\" rel=\"Stylesheet\" type=\"text/css\" media=\"screen\"/>";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/hidpi.css") + "\" rel=\"Stylesheet\" type=\"text/css\"  media=\"screen\"/>";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/skin.css") + "\" rel=\"Stylesheet\" type=\"text/css\" media=\"all\"/>";
                meta += "<link href=\"" + ResolveUrl("~/Theme/css/custom.css") + "\" rel=\"Stylesheet\" type=\"text/css\" media=\"all\"/>";

                meta += "<script src=\"" + ResolveUrl("~/Theme/js/jquery.min.js") + "\"  type=\"text/javascript\" > </script>";
                meta += "<script src=\"" + ResolveUrl("~/Theme/js/effects.jquery-ui.min.js") + "\"  type=\"text/javascript\" > </script>";
                meta += "<script src=\"" + ResolveUrl("~/Theme/js/jquery.nivo-slider.min.js") + "\"  type=\"text/javascript\" > </script>";
                meta += "<script src=\"" + ResolveUrl("~/Theme/js/jquery.colorbox.min.js") + "\"  type=\"text/javascript\" > </script>";
                meta += "<script src=\"" + ResolveUrl("~/Theme/js/custom.js") + "\"  type=\"text/javascript\" > </script>";

                // "<link href=\"" + ResolveUrl("~/css/default.css") + "\" rel=\"Stylesheet\" type=\"text/css\" />";



                meta += "<link rel=\"shortcut icon\" href=\"" + Page.ResolveUrl("~/images/logo.jpg") + "\" />";
                Literal cssLiteral2 = new Literal();
                cssLiteral2.Text = meta;
                Page.Header.Controls.Add(cssLiteral2);

                litLogo.Text = "<center> <img  alt=\"punjabimp3songs.in\" src=\"" + Page.ResolveUrl("~/images/mp3logo.png") + "\" /></center>";
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}