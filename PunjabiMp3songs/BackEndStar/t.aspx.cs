﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Telerik.Web.UI.Upload;
namespace PunjabiMp3songs.BackEndStar
{
    public partial class t : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            string mappath = Server.MapPath("~/UploadsIm/" + FileUpload.FileName);
            FileUpload.SaveAs(mappath);
             
        }
    }
}