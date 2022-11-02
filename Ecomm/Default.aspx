<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecomm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

	<div class="jumbotron">
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
		                <asp:Label ID="lblFechaDeAlta" Text="Feha De Alta" runat="server"></asp:Label>
		                <asp:TextBox ID="txtFechaDeAlta" runat="server"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdMarca" Text="Marca" runat="server"></asp:Label>
						<asp:DropDownList ID="ddlMarca" runat="server" OnSelectedIndexChanged="ddlMarca_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdTipo" Text="Tipo" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlTipo" runat="server" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdTemporada" Text="Temporada" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlTemporada" runat="server" OnSelectedIndexChanged="ddlTemporada_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdSexo" Text="Sexo" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlSexo" runat="server" OnSelectedIndexChanged="ddlSexo_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdColor" Text="Color" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlColor" runat="server" OnSelectedIndexChanged="ddlColor_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdTalle" Text="Talle" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlTalle" runat="server" OnSelectedIndexChanged="ddlTalle_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
					 <div>
		                <asp:Label ID="lblIdPromocion" Text="Promocion" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlPromocion" runat="server" OnSelectedIndexChanged="ddlPromocion_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblIdCalificacion" Text="Calificacion" runat="server"></asp:Label>
		                <asp:DropDownList ID="ddlCalificacion" runat="server" OnSelectedIndexChanged="ddlCalificacion_SelectedIndexChanged" AutoPostBack="true" Width="300"/>
	                </div>
                    <div>
		                <asp:Label ID="lblImagen" Text="Imagen" runat="server"></asp:Label>
		                <asp:TextBox ID="txtImagen" runat="server"/>
	                </div>
	                <br />
                
                    <br />
                <asp:Button ID="btnGuardarProducto" runat="server" Text="Guardar Producto" OnClick="btnGuardarProducto_Click" />
				<asp:Button ID="btnActualizar" runat="server" Text="Actualizar Producto" OnClick="btnActualizar_Click" />
                </asp:Panel>




	<div class="jumbotron">
		
			<h1>PRODUCTOS</h1>		

	<asp:GridView ID="gvdProductos" runat="server" AutoGenerateColumns="false" >
                <Columns>

                    <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="nombreProducto" HeaderText="Nombre Producto" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:BoundField DataField="fechaDeAlta" HeaderText="Fecha de alta" />
                    <asp:BoundField DataField="idMarca" HeaderText="Id Marca" /> 
                    <asp:BoundField DataField="idTipo" HeaderText="Id Tipo" />
                    <asp:BoundField DataField="idTemporada" HeaderText="Id Temporada" />
                    <asp:BoundField DataField="idSexo" HeaderText="Id Sexo" />
                    <asp:BoundField DataField="idColor" HeaderText="Id Color" />
                    <asp:BoundField DataField="idTalle" HeaderText="Id Talle" />
                    <asp:BoundField DataField="idPromocion" HeaderText="Id Promoción" />
                    <asp:BoundField DataField="idCalificacion" HeaderText="Id Calificacion" />
                    <asp:BoundField DataField="imagen" HeaderText="Imagen" />

					<asp:TemplateField>
						<ItemTemplate>
							<asp:LinkButton ID="lkbActualizar" runat="server" Text="Actualizar" OnClick="lkbActualizar_Click"/>
						</ItemTemplate>
					</asp:TemplateField>

					<asp:TemplateField>
						<ItemTemplate>
							<asp:LinkButton ID="lkbEliminar" runat="server" Text="Eliminar" OnClick="lkbEliminar_Click" />
						</ItemTemplate>
					</asp:TemplateField>

                </Columns>
    </asp:GridView>
		
	</div>




</asp:Content>
