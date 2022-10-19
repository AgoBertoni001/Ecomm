<%@ Page Title="AltaProducto" Language="C#" MasterPageFile="../Site.Master" AutoEventWireup="true" CodeBehind="AltaProducto.aspx.cs" Inherits="Ecomm.Views.AltaProducto" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Styles/AltaProducto.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="alta-producto">
            <h3>Ingrese los datos de su nuevo producto:</h3>
            <ul class="registroProducto">
                <li><input type="text" name="prod-nombre" placeholder="Nombre"/></li>
                <li><input type="text" name="prod-descripcion" placeholder="Descripción"/></li>
                <li><input type="number" name="prod-precio" placeholder="Precio"/></li>
                <li><input type="number" name="prod-stock" placeholder="Stock disponible"/></li>
                <li>
                    <select>
                        <optgroup label="Tipo">
                            <option value="1">Remera</option>
                            <option value="2">Pantalon</option>
                        </optgroup>
                    </select>
                </li>
                <li>
                    <select>
                        <optgroup label="Genero">
                            <option value="1">Mujer</option>
                            <option value="2">Hombre</option>
                            <option value="3">Unisex</option>
                        </optgroup>
                    </select>
                </li>
                <li>
                    <select>
                        <optgroup label="Marca">
                            <option value="1">Adidas</option>
                            <option value="2">Nike</option>
                            <option value="3">Converse</option>
                        </optgroup>
                    </select>
                </li>
                <li>
                    <select>
                        <optgroup label="Temporada">
                            <option value="1">Invierno</option>
                            <option value="2">Verano</option>
                            <option value="3">Atemporal</option>
                        </optgroup>
                    </select>
                </li>
                <li><select> <!-- hacerlo cheklist dropdown-->
                        <optgroup label="Talle">
                            <option value="XS">XS</option>
                            <option value="S">S</option>
                        </optgroup>
                    </select></li>
                <li><input type="file" id="imagen-producto" name="imagenProducto" /></li>
            </ul>
        <button type="submit" id="btnSubmit">Agregar producto</button>
        <button type="button"><a href="<%= Page.ResolveUrl("../Views/Perfil.aspx") %>">Cancelar</a></button>
        </div>
</asp:Content>