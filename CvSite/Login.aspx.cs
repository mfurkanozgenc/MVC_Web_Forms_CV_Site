using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class Login : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var giris = db.TBLADMIN.Where(x => x.KULLANICIADI == TextBox1.Text && x.SIFRE == TextBox2.Text);
            if (giris.Any())
            {
                Response.Redirect("Iletisim.aspx");
            }
            else
            {
                Response.Write("Kullanıcıadı ya da Şifre Hatalı");
            }
        }
    }
}