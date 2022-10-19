<%@ Page Title="Categorias" Language="C#" MasterPageFile="../Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="Ecomm.Views.Categorias" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Styles/Categorias.css" type="stylesheet" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="categorias-list">
        <asp:DataList ID="listaPromociones" runat="server">
            <ItemTemplate> 
                <h3>Promociones</h3>
                <ul>
                    <li><%=Eval("nombre") %></li>
                </ul>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" connectionString="<%= connectionToSql:connBD %>"
             SelectCommand="SELECT nombre FROM Promocion">
        </asp:SqlDataSource>  
    </div>
    <div class="categorias-list">
        <asp:DataList ID="listaMarca" runat="server">
            <ItemTemplate> 
                <h3>Marcas</h3>
                <ul>
                    <li><%=Eval("nombre") %></li>
                </ul>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" connectionString="<%= connectionToSql:connBD %>"
             SelectCommand="SELECT [codigo],[nombre] FROM [Marca]">
        </asp:SqlDataSource>  
    </div>

</asp:Content>