using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var deger = db.TBLILETISIM.Find(x);
            txtadsoyad.Text = deger.ADSOYAD;
            txtmail.Text = deger.MAIL;
            txtkonu.Text = deger.KONU;
            txtmesaj.Text = deger.MESAJ;
        }
    }
}