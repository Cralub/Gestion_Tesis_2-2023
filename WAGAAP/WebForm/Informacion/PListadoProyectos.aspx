<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PListadoProyectos.aspx.cs" Inherits="WebForm_Usuario_PListadoProyectos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet"/>

    <link rel="stylesheet" href="../../Estilo/CSSPrincipal.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptProyectos" runat="server">
                <HeaderTemplate>
                    <table class="Tabla_Contenido">
                        <thead>
                            <tr>
                                <th>MODALIDAD</th>
                                <th>TITULO</th>
                                <th>OBJETIVO</th>
                                <th>DOCUMENTO</th>
                                <th>FECHA DE ENTREGA</th>
                                <th>ESTADO</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                            <tr>
                                <td><%# Eval("Modalidad") %></td>
                                <td><%# Eval("Titulo") %></td>
                                <td><%# Eval("Objetivo") %></td>
                                <td><%# Eval("Documento") %></td>
                                <td><%# Eval("FechaEntrega") %></td>
                                <td><asp:Label runat="server" ID="lblEstadoEntrega" class="Estado_Entrega"></asp:Label></td>
                            </tr>
                </ItemTemplate>
                <FooterTemplate>
                        </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
