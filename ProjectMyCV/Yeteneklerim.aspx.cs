using ProjectMyCV.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class Hakkımda : System.Web.UI.Page
    {
        CVContext db = new CVContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Yetenekler.ToList();
            Repeater1.DataBind();
        }
    }
}