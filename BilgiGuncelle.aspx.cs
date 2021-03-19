using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class BilgiGuncelle : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);

            if (Page.IsPostBack == false)
            {
                var bilgi = db.Tbl_Hakkimizda.Find(x);
                TxtBilgiler.Text = bilgi.Bilgiler;
                TxtEgitim.Text = bilgi.Egitim;
                TxtIsDeneyimleri.Text = bilgi.IsDeneyimleri;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var bilgi = db.Tbl_Hakkimizda.Find(x);
            bilgi.Bilgiler = TxtBilgiler.Text;
            bilgi.Egitim = TxtEgitim.Text;
            bilgi.IsDeneyimleri = TxtIsDeneyimleri.Text;
            db.SaveChanges();
            Response.Redirect("Egitim.aspx");
        }
    }
}