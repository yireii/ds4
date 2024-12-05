using System;

namespace YSkincare.Aspx_Front
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnComenzar_Click(object sender, EventArgs e)
        {
            Response.Redirect("SeleccionTipoPiel.aspx", false);
        }
    }
}