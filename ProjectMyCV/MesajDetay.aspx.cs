using ProjectMyCV.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVContext db = new CVContext();
            int x = int.Parse(Request.QueryString["Id"]);
            var mesaj = db.İletisim.Find(x);
            txtAdSoyad.Text = mesaj.AdSoyad;
            txtEmail.Text = mesaj.Email;
            txtKonu.Text = mesaj.Konu;
            txtMesaj.Text = mesaj.Mesaj;
        }

        protected void btnGeri_Click(object sender, EventArgs e)
        {
            Response.Redirect("İletişim.aspx");
        }
    }
}