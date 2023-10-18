﻿<%@ Page Title="Lista Observaciones" Language="C#" MasterPageFile="~/PaginaMaestra/MPNavegacion.master" AutoEventWireup="true" CodeFile="PListaObservacion.aspx.cs" Inherits="WebForm_PListaObservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div><asp:Button  ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click"/></div>

        <asp:GridView ID="grvListaObservacionesTipo" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="grvListaObservacionesTipo_RowCommand">
            <Columns>
                <asp:BoundField DataField="TipoObservacion" HeaderText="Tipo" Visible="true"/>
                <asp:BoundField DataField="CodigoObservacion" Visible="true" />
                <asp:BoundField DataField="EstadoObservacion" HeaderText="Estado" Visible="true" />
                <asp:BoundField DataField="ComentarioObservacion" HeaderText="Comentario" />
                 <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton"/>
            </Columns>
</asp:GridView>
    </div>
</asp:Content>
