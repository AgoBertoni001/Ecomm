<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecomm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div>	
			 <asp:GridView ID="gvdProductos" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="nombreProducto" HeaderText="Nombre" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:BoundField DataField="fechaDeAlta" HeaderText="Fecha De Alta" />
                    <asp:BoundField DataField="iMarca" HeaderText="Marca" /> 
                    <asp:BoundField DataField="idMarca" HeaderText="Marca" />
                    <asp:BoundField DataField="idTipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="idTemporada" HeaderText="Temporada" />
                    <asp:BoundField DataField="idSexo" HeaderText="Sexo" />
                    <asp:BoundField DataField="idColor" HeaderText="Color" />
                    <asp:BoundField DataField="idTalle" HeaderText="Talle" />
                    <asp:BoundField DataField="idPromocion" HeaderText="Promoción" />
                    <asp:BoundField DataField="idCalificacion" HeaderText="Calificacion" />
                    <asp:BoundField DataField="imagen" HeaderText="imagen" />
                </Columns>
            </asp:GridView>
        </div>
		

       
         </div>

	<div>
		<asp:Button ID="btnNuevoProducto" runat="server" OnClick="btnNuevoProducto_Click" Text="Nuevo Producto"/>
	</div>

    
	            <asp:Panel ID="pnlAltaProdcucto" runat="server" Visible="false">
                    <div>
		                <asp:Label ID="lblCodigo" Text="Codigo" runat="server"></asp:Label>
		                <asp:TextBox ID="txtCodigo" runat="server"/>
	                </div>
	                <div>
		                <asp:Label ID="lblNombre" Text="Nombre" runat="server"></asp:Label>
		                <asp:TextBox ID="txtNombre" runat="server"/>
	                </div>
	                <div>
		                <asp:Label ID="lblDescripcion" Text="Descripcion" runat="server"></asp:Label>
		                <asp:TextBox ID="txtDescripcion" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblPrecio" Text="Precio" runat="server"></asp:Label>
		                <asp:TextBox ID="txtPrecio" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblStock" Text="Stock" runat="server"></asp:Label>
		                <asp:TextBox ID="txtStock" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblFechaDeAlta" Text="FehaDeAlta" runat="server"></asp:Label>
		                <asp:TextBox ID="txtFechaDeAlta" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdMarca" Text="Marca" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdMarca" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdTipo" Text="Tipo" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdTipo" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdTemporada" Text="Temporada" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdTemporada" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdSexo" Text="Sexo" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdSexo" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdColor" Text="Color" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdColor" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdTalle" Text="Talle" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdTalle" runat="server"/>
	                </div>
					 <div>
		                <asp:Label ID="lblIdPromocion" Text="Promocion" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdPromocion" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdCalificacion" Text="Calificacion" runat="server"></asp:Label>
		                <asp:TextBox ID="txtIdCalificacion" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblImagen" Text="Imagen" runat="server"></asp:Label>
		                <asp:TextBox ID="txtImagen" runat="server"/>
	                </div>
	                <br />
                
                    <br />
                <asp:Button ID="btnGuardarProducto" runat="server" Text="Guardar Producto" OnClick="btnGuardarProducto_Click" />
				
                </asp:Panel>




   

</asp:Content>
