<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="YSkincare.Aspx__Front_.Error" %>

<!DOCTYPE html>
<html>
<head>
    <title>Error</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
</head>
<body>
    <div class="main">
        <h1>¡Ups! Algo salió mal.</h1>
        <p><asp:Label ID="lblErrorMessage" runat="server" /></p>
        <a href="SeleccionTipoPiel.aspx" class="button">Volver al inicio</a>
    </div>
</body>
</html>