using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
            var yetenek = db.Tbl_Yetenekler.Find(x);
            TextBox1.Text = yetenek.Yetenek;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var yetenek = db.Tbl_Yetenekler.Find(x);
            yetenek.Yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yetenekler.aspx");

        }
    }
}