using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YSkincare.Aspx__Front_
{
    public partial class Recomendaciones : Page
    {
        private static List<int> rutina = new List<int>(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string pielId = Request.QueryString["pielId"];

                    if (!string.IsNullOrEmpty(pielId) && int.TryParse(pielId, out int tipoPielId))
                    {
                        CargarProductos(tipoPielId);
                    }
                    else
                    {
                        Response.Redirect("Error.aspx?msg=ID de tipo de piel no especificado o inválido.", false);
                    }
                }
                catch (Exception ex)
                {

                    RegistrarError(ex);
                    Response.Redirect("Error.aspx?msg=Error al cargar las recomendaciones.", false);
                }
            }
        }

        private void CargarProductos(int pielId)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=YSkinCare; Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Id, Nombre, Categoria, Precio, LugarDeCompra, Imagen 
                                     FROM Productos 
                                     WHERE TipoDePiel = @pielId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pielId", pielId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            repeaterProductos.DataSource = reader;
                            repeaterProductos.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar errores durante la carga de productos
                RegistrarError(ex);
                Response.Redirect("Error.aspx?msg=Error al cargar los productos.", false);
            }
        }

        protected void repeaterProductos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {
 
                if (int.TryParse(e.CommandArgument.ToString(), out int productoId) && !rutina.Contains(productoId))
                {
                    rutina.Add(productoId);
                }
            }
        }

        protected void btnGuardarRutina_Click(object sender, EventArgs e)
        {
            string nombreRutina = txtNombreRutina.Text.Trim();

            int usuarioId = 1;

            if (!string.IsNullOrEmpty(nombreRutina) && rutina.Count > 0)
            {
                GuardarRutinaEnBaseDeDatos(usuarioId, nombreRutina);
            }
        }

        private void GuardarRutinaEnBaseDeDatos(int usuarioId, string nombreRutina)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=YSkinCare; Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (int productoId in rutina)
                    {
                        string query = @"INSERT INTO Rutinas (UsuarioId, Nombre, ProductoId) 
                                         VALUES (@UsuarioId, @Nombre, @ProductoId)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                            cmd.Parameters.AddWithValue("@Nombre", nombreRutina);
                            cmd.Parameters.AddWithValue("@ProductoId", productoId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RegistrarError(ex);
                Response.Redirect("Error.aspx?msg=Error al guardar la rutina.", false);
            }
        }

        protected void btnVerRutina_Click(object sender, EventArgs e)
        {
            if (rutina.Count > 0)
            {
                string rutinaIds = string.Join(",", rutina);
                Response.Redirect($"Rutina.aspx?ids={rutinaIds}", false);
            }
        }

        private void RegistrarError(Exception ex)
        {
            try
            {
                string logPath = Server.MapPath("~/ErroresLog.txt");
                System.IO.File.AppendAllText(logPath, $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
            }
            catch
            {

            }
        }
    }
}
