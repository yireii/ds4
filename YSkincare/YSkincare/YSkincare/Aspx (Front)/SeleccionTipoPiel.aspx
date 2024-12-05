<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionTipoPiel.aspx.cs" Inherits="YSkincare.Aspx__Front_.SeleccionTipoPiel" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seleccionar Tipo de Piel</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            text-align: center;
        }

        h2 {
            margin-top: 20px;
        }

        .grid-container {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 20px;
            padding: 20px;
            max-width: 1200px;
            margin: auto;
        }

        .card {
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 15px;
            text-align: center;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            transition: transform 0.2s, box-shadow 0.2s;
        }

        .card:hover {
            transform: scale(1.05);
            box-shadow: 0 6px 10px rgba(0, 0, 0, 0.15);
        }

        .card img {
            width: 100%;
            height: auto;
            border-radius: 8px;
        }

        .card h3 {
            font-size: 18px;
            margin: 10px 0 5px;
        }

        .card p {
            font-size: 14px;
            color: #666;
            margin-bottom: 10px;
        }

        .card button {
            background-color: #ff6f61;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.2s;
        }

        .card button:hover {
            background-color: #ff4a3d;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Selecciona tu tipo de piel</h2>
        <div class="grid-container">
            <asp:Repeater ID="repeaterTiposDePiel" runat="server">
                <ItemTemplate>
                    <div class="card">
                        <!-- Imagen (opcional) -->
                        <h3><%# Eval("Nombre") %></h3>
                        <p><%# Eval("Descripcion") %></p>
                        <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandArgument='<%# Eval("Id") %>' OnClick="btnSeleccionar_Click" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
