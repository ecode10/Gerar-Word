using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerarWord
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
                GeraWord();
            }
        }

        private void GeraWord()
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/msword";
            this.EnableViewState = false;

            System.IO.StringWriter _oString = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(_oString);
            Response.Write(_oString.ToString());

        }
    }
}