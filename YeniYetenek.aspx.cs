using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Yetenekler t = new Tbl_Yetenekler();
            t.Yetenek = TextBox1.Text;
            db.Tbl_Yetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}