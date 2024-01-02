using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LicenceExam
{
    public partial class Exam : System.Web.UI.Page
    {
        public string targetView;
        protected void Page_Load(object sender, EventArgs e)
        {
            targetView = Request.QueryString["view"];
        }
    }
}