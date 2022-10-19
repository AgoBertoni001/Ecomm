<%@ Page Title="Mi perfil" Language="C#" MasterPageFile="../Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Ecomm.Views.Perfil" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Styles/Perfil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <aside id="sidebar" class="sidebar menu">
        <div class="titulo">
            <h3>Mi cuenta</h3>
        </div>
        <div class="menu-content">
            <ul>
                <li><a href="<%= Page.ResolveUrl("../Views/AltaProducto.aspx") %>">Agregar un producto</a></li>
                <li><a href="#">Modificar un producto</a></li>
                <li><a href="#">Eliminar un producto</a></li>
            </ul>
        </div>
    </aside>
    <div class="usuario">
        <div class="usuario-productos">
            <div class="usuario-header">
                <h3>Mis productos</h3>
            </div>
            <ul><li>*mostrar productos</li></ul>
        </div>
    </div>
</asp:Content>