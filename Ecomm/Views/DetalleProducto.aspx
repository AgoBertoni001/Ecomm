<%@ Page Title="DetallesProducto" Language="C#" MasterPageFile="../Site.Master" AutoEventWireup="true" CodeBehind="DetallesProducto.aspx.cs" Inherits="Ecomm.Views.DetallesProducto" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Styles/Inicio.css" type="stylesheet" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="conteiner">
            <div class="datosProducto">
                <div class="datosProducto imgProducto">
                    <img src="https://deliverind.com.ar/wp-content/uploads/2021/09/remera-oversize-x3-scaled.jpg" height="350em" />
                </div>
                <div class="datosProducto favorito">
                    <button type="button" id="btnFavorito"><img src="img/imgFavorito.png" height="30em" /></button>
                </div>
                <div class="datosProducto nombrePrecioProducto">
                    <h1>Nombre del producto</h1>
                    <h2>$$$$</h2>
                </div>
                <div class="datosProducto colorProducto">
                    <h4>Color:</h4>
                    <select name="sboxColores" id="colores">
                        <option value="celese">Celeste</option>
                        <option value="rojo">Rojo</option>
                        <option value="verde">Verde</option>
                    </select>
                </div>
                <div class="datosProducto talleProducto">
                    <h4>Talle:</h4>
                    <select name="sboxTalles" id="talles">
                        <option value="s">S</option>
                        <option value="m">M</option>
                        <option value="l">L</option>
                    </select>
                    <a href="../imgTalles.jpg" target:"_top"></a>
                </div>
                <div class="datosProducto stockProducto">
                    <h3>Stock disponible: XX</h3>
                </div>
                <div>
                    <h4>Cantidad:</h4>
                    <select name="sboxCantidad" id="cantidad">
                        <option value="1">1 unidad</option>
                        <option value="2">2 unidades</option>
                        <option value="3">3 unidades</option>
                        <option value="4">4 unidades</option>
                        <option value="5">5 unidades</option>
                    </select>
                </div>
                <div>
                    <button type="button" id="btnComprar">Comprar ahora</button>
                    <button type="button" id="btnAgregarCarrito">Agregar al carrito</button>
                </div>
            </div>
        </div>
</asp:Content>