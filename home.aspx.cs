using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoInter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("tabela1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("tabela2.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("integrantes.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("geraXML.aspx");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("geraJSON.aspx");
        }
    }
}