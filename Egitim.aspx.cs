﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Egitim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db = new DbCvEntityEntities();
            Repeater1.DataSource = db.Tbl_Hakkimizda.ToList();
            Repeater1.DataBind();
        }
    }
}