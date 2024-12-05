<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="YSkincare.Aspx_Front.Inicio" %>
<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <title>Skincare Recommender</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
        }

        .main {
            display: flex;
            justify-content: space-between;
            align-items: center;
            height: 100vh;
            padding: 0 10%;
            background-color: #ffffff;
        }

        .text-section {
            max-width: 50%;
        }

        .text-section h1 {
            font-size: 3rem;
            color: #b85c5c;
            margin-bottom: 20px;
        }

        .text-section p {
            font-size: 1.2rem;
            color: #555555;
            line-height: 1.8;
        }

        .text-section .start-btn {
            display: inline-block;
            margin-top: 20px;
            padding: 10px 20px;
            font-size: 1rem;
            color: #ffffff;
            background-color: #b85c5c;
            border: none;
            border-radius: 5px;
            text-decoration: none;
            cursor: pointer;
        }

        .text-section .start-btn:hover {
            background-color: #a14f4f;
        }

        .image-section {
            max-width: 40%;
        }

        .image-section img {
            width: 100%;
            border-radius: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <!-- Sección de texto -->
            <div class="text-section">
                <h1>Bienvenido a Skincare Recommender</h1>
                <p>
                    Tu asistente personalizado para el cuidado de la piel. 
                    Descubre productos recomendados según tu tipo de piel y presupuesto, 
                    guarda tus rutinas diarias y crea tu lista de deseos. ¡Tu piel merece el mejor cuidado!
                </p>
                <asp:Button ID="btnComenzar" runat="server" Text="Comenzar" CssClass="start-btn" OnClick="btnComenzar_Click" />
            </div>

            <!-- Sección de imagen -->
            <div class="image-section">
                <img src="https://hips.hearstapps.com/hmg-prod/images/2-natural-skincare-brands-670eadb4e4fcf.jpg?crop=0.502xw:1.00xh;0.250xw,0&resize=1120:*" alt="Skincare Image" />
            </div>
        </div>
    </form>
</body>
</html>