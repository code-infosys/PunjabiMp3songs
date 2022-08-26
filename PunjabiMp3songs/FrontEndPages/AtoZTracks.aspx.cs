using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace PunjabiMp3songs.FrontEndPages
{
    public partial class AtoZTracks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["alphaid"] != null)
            {
                pnlSongs.Visible = true;
            }
            else
            {
                ToZwrite();
                pnlSongs.Visible = false;
            }
        }

        private void ToZwrite()
        {
            StringBuilder sb = new StringBuilder();
            for (char c = 'A'; c < 'Z'; c++)
            {
                sb.Append("<a class=\"pageNumber\" href=\"/a_to_z/" + c.ToString().ToLower() + "/single-tracks\">" + c.ToString().ToUpper() + " </a> ");
                  
            }


            litabdc.Text = sb.ToString();
        }
    }
}