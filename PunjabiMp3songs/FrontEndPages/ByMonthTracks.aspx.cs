using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs.FrontEndPages
{
    public partial class ByMonthTracks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["monthid"] != null)
            {
                pnlSongs.Visible = true;
                PNLmonths.Visible = false;
            }
            else
            {
                pnlSongs.Visible = false;
                PNLmonths.Visible = true;
            }
        }
    }
}