using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using YSkincare.C___Back_;

namespace YSkincare.Aspx__Front_
{
    public partial class SeleccionTipoPiel : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    CargarTiposDePiel();
                }
                catch (Exception ex)
                {
                    RegistrarError(ex);
                    Response.Redirect($"Error.aspx?msg=Error al cargar los tipos de piel: {ex.Message}");
                }
            }
        }

        public void CargarTiposDePiel()
        {
            string connectionString = DbConnection.ConnectionString_YS();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, Descripcion FROM TiposDePiel", conn);
                    cmd.CommandTimeout = 60;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        repeaterTiposDePiel.DataSource = reader;
                        repeaterTiposDePiel.DataBind();
                    }
                    else
                    {
                        throw new Exception("No se encontraron datos en la tabla TiposDePiel.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al conectar a la base de datos o realizar la consulta: {ex.Message}");
                }
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                string selectedPielId = btn.CommandArgument;
                string redirectUrl = $"Recomendaciones.aspx?pielId={selectedPielId}".Replace("\n", "").Replace("\r", "");
                Response.Redirect(redirectUrl, false);
            }
            catch (Exception ex)
            {
                RegistrarError(ex);
                Response.Redirect($"Error.aspx?msg=Error al procesar la selección: {ex.Message}");
            }
        }

        private void RegistrarError(Exception ex)
        {
            string logPath = Server.MapPath("~/ErroresLog.txt");
            System.IO.File.AppendAllText(logPath,
                $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
        }
    }
}
