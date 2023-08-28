using ProjectMyCV.Contexts;
using ProjectMyCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class Default : System.Web.UI.Page
    {
        CVContext db = new CVContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Hakkimda.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.Hakkimda.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.Hakkimda.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.Yetenekler.ToList();
            Repeater4.DataBind();
        }
        protected void btnGonder_Click(object sender, EventArgs e)
        {
            İletisim iletisim = new İletisim();
            iletisim.AdSoyad = txtAdSoyad.Text;
            iletisim.Email = txtEmail.Text;
            iletisim.Konu = txtKonu.Text;
            iletisim.Mesaj = txtMesaj.Text;
            db.İletisim.Add(iletisim);
            db.SaveChanges();
        }
        protected void btnVzgec_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtEmail.Text = "";
            txtKonu.Text = "";
            txtMesaj.Text = "";
        }
    }
}