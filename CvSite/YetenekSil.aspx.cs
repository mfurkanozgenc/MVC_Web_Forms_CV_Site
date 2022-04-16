using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(x);
            db.TBLYETENEKLER.Remove(deger);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}