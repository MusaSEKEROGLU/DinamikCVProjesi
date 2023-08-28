using ProjectMyCV.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVContext db = new CVContext();

            int x = Convert.ToInt32(Request.QueryString["Id"]);

            var ytnk = db.Yetenekler.Find(x);

            db.Yetenekler.Remove(ytnk);

            db.SaveChanges();

            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}