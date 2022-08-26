using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PunjabiMp3songs
{
    public partial class AssignTop20 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected string Stname(decimal id)
        {
            StarMethods m=new StarMethods();
            return m.GetTrackName(id);
        }
    }
}