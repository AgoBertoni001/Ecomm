<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Ecomm.Views.Inicio" %>



<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Styles/Inicio.css" type="stylesheet" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row-productos">
        <div class="row-productos productos">
            <asp:GridView ID="productos" runat="server">
                
            </asp:GridView>
        </div>
     </div>
    
</asp:Content>