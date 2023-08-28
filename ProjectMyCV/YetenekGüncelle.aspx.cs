using ProjectMyCV.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        CVContext db = new CVContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["Id"]);

            if (Page.IsPostBack == false)
            {
                var ytnk = db.Yetenekler.Find(x);

                txtYetenekAd.Text = ytnk.Yetenek;
            }
        }

        protected void btnVazgec_Click(object sender, EventArgs e)
        {
            Response.Redirect("Yeteneklerim.aspx");
        }
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["Id"]);

            var ytnk = db.Yetenekler.Find(x);

            ytnk.Yetenek = txtYetenekAd.Text;

            db.SaveChanges();

            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}