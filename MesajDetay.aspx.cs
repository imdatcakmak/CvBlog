using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db = new DbCvEntityEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.Tbl_İletisim.Find(x);
            TxtAdSoyad.Text = mesaj.AdSoyad;
            TxtKonu.Text = mesaj.Konu;
            TxtMail.Text = mesaj.Mail;
            TxtMesaj.Text = mesaj.Mesaj;
        }
    }
}