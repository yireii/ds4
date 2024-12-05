<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recomendaciones.aspx.cs" Inherits="YSkincare.Aspx__Front_.Recomendaciones" %>
<!DOCTYPE html>
<html>
<head>
    <title>Recomendaciones</title>
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

        h1, h3 {
            color: #dd7373;
        }

        .product-container {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 20px;
        }

        .product-item {
            background-color: white;
            border: 1px solid #e0e0e0;
            border-radius: 8px;
            padding: 20px;
            text-align: center;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s;
        }

        .product-item:hover {
            transform: scale(1.05);
        }

        .product-item img {
            width: 100px;
            height: auto;
            margin-bottom: 15px;
        }

        .product-item p {
            color: #666;
            margin: 5px 0;
        }

        .product-item button {
            background-color: #dd7373;
            color: white;
            border: none;
            padding: 10px 15px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 14px;
            transition: background-color 0.3s;
        }

        .product-item button:hover {
            background-color: #c05a5a;
        }

        .action-buttons {
            text-align: center;
            margin: 20px 0;
        }

        .action-buttons input,
        .action-buttons button {
            margin: 10px;
            padding: 10px 15px;
            border-radius: 5px;
            border: 1px solid #ddd;
            background-color: #fff;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .action-buttons button:hover {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <h1>Recomendaciones de Skincare</h1>
            <asp:Repeater ID="repeaterProductos" runat="server" OnItemCommand="repeaterProductos_ItemCommand">
                <ItemTemplate>
                    <div class="product-item">
                        <h3><%# Eval("Nombre") %></h3>
                        <p>
                            <img src="<%# Eval("Imagen") %>" alt="Imagen de producto" style="width:100px; height:auto;" />
                        </p>
                        <p><%# Eval("Categoria") %>: <%# Eval("Precio") %></p>
                        <p>Lugar: <%# Eval("LugarDeCompra") %></p>
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar a Rutina" CommandName="Agregar" CommandArgument='<%# Eval("Id") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="action-buttons">
                <asp:TextBox ID="txtNombreRutina" runat="server" Placeholder="Nombre de la Rutina"></asp:TextBox>
                <asp:Button ID="btnGuardarRutina" runat="server" Text="Guardar Rutina" OnClick="btnGuardarRutina_Click" />
                <asp:Button ID="btnVerRutina" runat="server" Text="Ver Rutina" OnClick="btnVerRutina_Click" />
            </div>
        </div>
    </form>
</body>
</html>