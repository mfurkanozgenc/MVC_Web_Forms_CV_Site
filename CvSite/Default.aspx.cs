using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVENTITYEntities DB = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = DB.TBLHAKKIMDA.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = DB.TBLHAKKIMDA.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = DB.TBLHAKKIMDA.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = DB.TBLYETENEKLER.ToList();
            Repeater4.DataBind();
            Repeater5.DataSource = DB.TBLHAKKIMDA.ToList();
            Repeater5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM iletisim = new TBLILETISIM();
            iletisim.ADSOYAD = TextBox1.Text;
            iletisim.MAIL = TextBox2.Text;
            iletisim.KONU = TextBox3.Text;
            iletisim.MESAJ = TextBox4.Text;
            DB.TBLILETISIM.Add(iletisim);
            DB.SaveChanges();
            
        }
    }
}