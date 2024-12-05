<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rutina.aspx.cs" Inherits="YSkincare.Aspx__Front_.Rutina" %>
<!DOCTYPE html>
<html>
<head>
    <title>Mi Rutina de Skincare</title>
    <style>
        /* Reset some default styles */
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
        }

        .main {
            width: 100%;
            max-width: 1200px;
            margin: 20px auto;
            padding: 20px;
        }

        h1 {
            color: #dd7373;
            text-align: center;
            margin-bottom: 20px;
        }

        .routine-container {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 20px;
        }

        .routine-item {
            background-color: white;
            border: 1px solid #e0e0e0;
            border-radius: 8px;
            padding: 20px;
            text-align: center;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s;
        }

        .routine-item:hover {
            transform: scale(1.05);
        }

        .routine-item h3 {
            color: #dd7373;
            font-size: 18px;
            margin: 10px 0;
        }

        .routine-item p {
            color: #666;
            margin: 5px 0;
        }

        .action-button {
            background-color: #dd7373;
            color: white;
            border: none;
            padding: 10px 15px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 14px;
            transition: background-color 0.3s;
            display: block;
            margin: 20px auto 0;
        }

        .action-button:hover {
            background-color: #c05a5a;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <h1>Mi Rutina de Skincare</h1>
            <div class="routine-container">
                <asp:Repeater ID="repeaterRutina" runat="server">
                    <ItemTemplate>
                        <div class="routine-item">
                            <h3><%# Eval("Nombre") %></h3>
                            <p><%# Eval("Categoria") %>: <%# Eval("Precio") %></p>
                            <p>Lugar: <%# Eval("LugarDeCompra") %></p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver a Recomendaciones" CssClass="action-button" OnClick="btnVolver_Click" />
        </div>
    </form>
</body>
</html>