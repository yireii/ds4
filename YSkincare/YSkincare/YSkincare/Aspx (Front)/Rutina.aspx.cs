using System;
using System.Data.SqlClient;
using System.Web.UI;
using YSkincare.C___Back_;

namespace YSkincare.Aspx__Front_
{
    public partial class Rutina : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string ids = Request.QueryString["ids"];
                    if (!string.IsNullOrEmpty(ids))
                    {
                        CargarRutina(ids);
                    }
                    else
                    {
                        Response.Redirect("Error.aspx?msg=No se especificaron productos en la rutina.", false);
                    }
                }
                catch (Exception ex)
                {
                    RegistrarError(ex);
                    Response.Redirect("Error.aspx?msg=Error al cargar la rutina.", false);
                }
            }
        }

        private void CargarRutina(string ids)
        {
            string connectionString = DbConnection.ConnectionString_YS();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    $"SELECT Nombre, Categoria, Precio, LugarDeCompra FROM Productos WHERE Id IN ({ids})", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    repeaterRutina.DataSource = reader;
                    repeaterRutina.DataBind();
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recomendaciones.aspx", false);
        }

        private void RegistrarError(Exception ex)
        {
            System.IO.File.AppendAllText(Server.MapPath("~/ErroresLog.txt"),
                $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
        }
    }
}
