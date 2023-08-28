using ProjectMyCV.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class İletişim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVContext db = new CVContext();
            var mesajlar = db.İletisim.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}