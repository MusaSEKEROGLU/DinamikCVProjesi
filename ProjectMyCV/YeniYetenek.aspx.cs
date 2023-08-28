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
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        CVContext db = new CVContext();
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Yetenekler yetenekler = new Yetenekler();
            yetenekler.Yetenek = txtYetenekAd.Text;
            db.Yetenekler.Add(yetenekler);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }

        protected void btnVazgec_Click(object sender, EventArgs e)
        {
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}