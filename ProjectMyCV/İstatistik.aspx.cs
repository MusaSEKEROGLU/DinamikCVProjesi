using ProjectMyCV.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectMyCV
{
    public partial class İstatistik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVContext db = new CVContext();

            Label1.Text = db.Yetenekler.Count().ToString();

            Label2.Text = db.İletisim.Count().ToString();

            Label3.Text = db.Yetenekler.Average(x => x.Derece).ToString();

            Label4.Text = db.Yetenekler.Max(x => x.Derece).ToString();
        }
    }
}