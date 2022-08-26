using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using StarMethods;
namespace PunjabiMp3songs.FrontEndPages
{
    public partial class SearchBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Length > 0)
                {
                    Searches(txtSearch.Text);
                }

            }
            catch (Exception)
            { 
            }
        }

        private void Searches(string stext)
        {
            StarMethods starm = new StarMethods();
            DataTable dt = new DataTable();
            dt = starm.SearchBoxFull(stext.ValidateData().ValidateScripts(), "bysong");
            if (dt.Rows.Count > 0)
            {
                ListViewSongs.DataSource = dt;
                ListViewSongs.DataBind();
            }
            else
                ListViewSongs.DataBind();
        }

        protected void ListViewSongs_PagePropertiesChanged(object sender, EventArgs e)
        {
            Searches(txtSearch.Text);
        }
    }
}