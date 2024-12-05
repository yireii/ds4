using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YSkincare.Aspx__Front_
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string errorMsg = Request.QueryString["msg"];
                if (string.IsNullOrEmpty(errorMsg))
                {
                    errorMsg = "Ha ocurrido un error inesperado. Por favor, intente de nuevo más tarde.";
                }
                lblErrorMessage.Text = errorMsg;
                RegistrarError(errorMsg);
            }
        }

        private void RegistrarError(string errorMsg)
        {
            string logPath = Server.MapPath("~/ErroresLog.txt");
            string logEntry = $"{DateTime.Now}: Error: {errorMsg}\n";
            logEntry += $"Request URL: {Request.Url}\n";
            logEntry += $"User IP: {Request.UserHostAddress}\n";

            System.IO.File.AppendAllText(logPath, logEntry);
        }
    }
}