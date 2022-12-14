#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatosProductos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ecommerce")]
	public partial class CatalogoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertProducto(Producto instance);
    partial void UpdateProducto(Producto instance);
    partial void DeleteProducto(Producto instance);
    #endregion
		
		public CatalogoDataContext() : 
				base(global::DatosProductos.Properties.Settings.Default.EcommerceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Producto> Producto
		{
			get
			{
				return this.GetTable<Producto>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.obtenerProductos")]
		public ISingleResult<obtenerProductosResult> obtenerProductos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<obtenerProductosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.modificaProducto")]
		public int modificaProducto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nombreProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> stock, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string fechaDeAlta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idMarca, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTipo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTemporada, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idSexo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idColor, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTalle, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idPromocion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idCalificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(250)")] string imagen)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertarProducto")]
		public int insertarProducto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nombreProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> stock, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string fechaDeAlta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idMarca, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTipo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTemporada, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idSexo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idColor, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTalle, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idPromocion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idCalificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(250)")] string imagen)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eliminaProducto")]
		public int eliminaProducto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.actualizarProductos")]
		public int actualizarProductos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string nombreProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> stock, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string fechaDeAlta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idMarca, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTipo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTemporada, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idSexo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idColor, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idTalle, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idPromocion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idCalificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(250)")] string imagen)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.seleccionProductos")]
		public ISingleResult<seleccionProductosResult> seleccionProductos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<seleccionProductosResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto")]
	public partial class Producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _codigo;
		
		private string _nombreProducto;
		
		private string _descripcion;
		
		private System.Nullable<decimal> _precio;
		
		private System.Nullable<int> _stock;
		
		private string _fechaDeAlta;
		
		private System.Nullable<int> _idMarca;
		
		private System.Nullable<int> _idTipo;
		
		private System.Nullable<int> _idTemporada;
		
		private System.Nullable<int> _idSexo;
		
		private System.Nullable<int> _idColor;
		
		private System.Nullable<int> _idTalle;
		
		private System.Nullable<int> _idPromocion;
		
		private System.Nullable<int> _idCalificacion;
		
		private string _imagen;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    partial void OnnombreProductoChanging(string value);
    partial void OnnombreProductoChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    partial void OnprecioChanging(System.Nullable<decimal> value);
    partial void OnprecioChanged();
    partial void OnstockChanging(System.Nullable<int> value);
    partial void OnstockChanged();
    partial void OnfechaDeAltaChanging(string value);
    partial void OnfechaDeAltaChanged();
    partial void OnidMarcaChanging(System.Nullable<int> value);
    partial void OnidMarcaChanged();
    partial void OnidTipoChanging(System.Nullable<int> value);
    partial void OnidTipoChanged();
    partial void OnidTemporadaChanging(System.Nullable<int> value);
    partial void OnidTemporadaChanged();
    partial void OnidSexoChanging(System.Nullable<int> value);
    partial void OnidSexoChanged();
    partial void OnidColorChanging(System.Nullable<int> value);
    partial void OnidColorChanged();
    partial void OnidTalleChanging(System.Nullable<int> value);
    partial void OnidTalleChanged();
    partial void OnidPromocionChanging(System.Nullable<int> value);
    partial void OnidPromocionChanged();
    partial void OnidCalificacionChanging(System.Nullable<int> value);
    partial void OnidCalificacionChanged();
    partial void OnimagenChanging(string value);
    partial void OnimagenChanged();
    #endregion
		
		public Producto()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreProducto", DbType="NVarChar(50)")]
		public string nombreProducto
		{
			get
			{
				return this._nombreProducto;
			}
			set
			{
				if ((this._nombreProducto != value))
				{
					this.OnnombreProductoChanging(value);
					this.SendPropertyChanging();
					this._nombreProducto = value;
					this.SendPropertyChanged("nombreProducto");
					this.OnnombreProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="NVarChar(250)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock", DbType="Int")]
		public System.Nullable<int> stock
		{
			get
			{
				return this._stock;
			}
			set
			{
				if ((this._stock != value))
				{
					this.OnstockChanging(value);
					this.SendPropertyChanging();
					this._stock = value;
					this.SendPropertyChanged("stock");
					this.OnstockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaDeAlta", DbType="NVarChar(50)")]
		public string fechaDeAlta
		{
			get
			{
				return this._fechaDeAlta;
			}
			set
			{
				if ((this._fechaDeAlta != value))
				{
					this.OnfechaDeAltaChanging(value);
					this.SendPropertyChanging();
					this._fechaDeAlta = value;
					this.SendPropertyChanged("fechaDeAlta");
					this.OnfechaDeAltaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMarca", DbType="Int")]
		public System.Nullable<int> idMarca
		{
			get
			{
				return this._idMarca;
			}
			set
			{
				if ((this._idMarca != value))
				{
					this.OnidMarcaChanging(value);
					this.SendPropertyChanging();
					this._idMarca = value;
					this.SendPropertyChanged("idMarca");
					this.OnidMarcaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipo", DbType="Int")]
		public System.Nullable<int> idTipo
		{
			get
			{
				return this._idTipo;
			}
			set
			{
				if ((this._idTipo != value))
				{
					this.OnidTipoChanging(value);
					this.SendPropertyChanging();
					this._idTipo = value;
					this.SendPropertyChanged("idTipo");
					this.OnidTipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTemporada", DbType="Int")]
		public System.Nullable<int> idTemporada
		{
			get
			{
				return this._idTemporada;
			}
			set
			{
				if ((this._idTemporada != value))
				{
					this.OnidTemporadaChanging(value);
					this.SendPropertyChanging();
					this._idTemporada = value;
					this.SendPropertyChanged("idTemporada");
					this.OnidTemporadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSexo", DbType="Int")]
		public System.Nullable<int> idSexo
		{
			get
			{
				return this._idSexo;
			}
			set
			{
				if ((this._idSexo != value))
				{
					this.OnidSexoChanging(value);
					this.SendPropertyChanging();
					this._idSexo = value;
					this.SendPropertyChanged("idSexo");
					this.OnidSexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idColor", DbType="Int")]
		public System.Nullable<int> idColor
		{
			get
			{
				return this._idColor;
			}
			set
			{
				if ((this._idColor != value))
				{
					this.OnidColorChanging(value);
					this.SendPropertyChanging();
					this._idColor = value;
					this.SendPropertyChanged("idColor");
					this.OnidColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTalle", DbType="Int")]
		public System.Nullable<int> idTalle
		{
			get
			{
				return this._idTalle;
			}
			set
			{
				if ((this._idTalle != value))
				{
					this.OnidTalleChanging(value);
					this.SendPropertyChanging();
					this._idTalle = value;
					this.SendPropertyChanged("idTalle");
					this.OnidTalleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPromocion", DbType="Int")]
		public System.Nullable<int> idPromocion
		{
			get
			{
				return this._idPromocion;
			}
			set
			{
				if ((this._idPromocion != value))
				{
					this.OnidPromocionChanging(value);
					this.SendPropertyChanging();
					this._idPromocion = value;
					this.SendPropertyChanged("idPromocion");
					this.OnidPromocionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCalificacion", DbType="Int")]
		public System.Nullable<int> idCalificacion
		{
			get
			{
				return this._idCalificacion;
			}
			set
			{
				if ((this._idCalificacion != value))
				{
					this.OnidCalificacionChanging(value);
					this.SendPropertyChanging();
					this._idCalificacion = value;
					this.SendPropertyChanged("idCalificacion");
					this.OnidCalificacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagen", DbType="NVarChar(250)")]
		public string imagen
		{
			get
			{
				return this._imagen;
			}
			set
			{
				if ((this._imagen != value))
				{
					this.OnimagenChanging(value);
					this.SendPropertyChanging();
					this._imagen = value;
					this.SendPropertyChanged("imagen");
					this.OnimagenChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class obtenerProductosResult
	{
		
		private string _codigo;
		
		private string _nombreProducto;
		
		private string _descripcion;
		
		private System.Nullable<decimal> _precio;
		
		private System.Nullable<int> _stock;

        private string _fechaDeAlta;

        private System.Nullable<int> _idMarca;
		
		private System.Nullable<int> _idTipo;
		
		private System.Nullable<int> _idTemporada;
		
		private System.Nullable<int> _idSexo;
		
		private System.Nullable<int> _idColor;
		
		private System.Nullable<int> _idTalle;
		
		private System.Nullable<int> _idPromocion;
		
		private System.Nullable<int> _idCalificacion;
		
		private string _imagen;
		
		public obtenerProductosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this._codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreProducto", DbType="NVarChar(50)")]
		public string nombreProducto
		{
			get
			{
				return this._nombreProducto;
			}
			set
			{
				if ((this._nombreProducto != value))
				{
					this._nombreProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="NVarChar(250)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this._descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this._precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock", DbType="Int")]
		public System.Nullable<int> stock
		{
			get
			{
				return this._stock;
			}
			set
			{
				if ((this._stock != value))
				{
					this._stock = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaDeAlta", DbType="NVarChar(50)")]
		public string fechaDeAlta
		{
			get
			{
				return this._fechaDeAlta;
			}
			set
			{
				if ((this._fechaDeAlta != value))
				{
					this._fechaDeAlta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idMarca", DbType="Int")]
		public System.Nullable<int> idMarca
		{
			get
			{
				return this._idMarca;
			}
			set
			{
				if ((this._idMarca != value))
				{
					this._idMarca = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipo", DbType="Int")]
		public System.Nullable<int> idTipo
		{
			get
			{
				return this._idTipo;
			}
			set
			{
				if ((this._idTipo != value))
				{
					this._idTipo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTemporada", DbType="Int")]
		public System.Nullable<int> idTemporada
		{
			get
			{
				return this._idTemporada;
			}
			set
			{
				if ((this._idTemporada != value))
				{
					this._idTemporada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSexo", DbType="Int")]
		public System.Nullable<int> idSexo
		{
			get
			{
				return this._idSexo;
			}
			set
			{
				if ((this._idSexo != value))
				{
					this._idSexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idColor", DbType="Int")]
		public System.Nullable<int> idColor
		{
			get
			{
				return this._idColor;
			}
			set
			{
				if ((this._idColor != value))
				{
					this._idColor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTalle", DbType="Int")]
		public System.Nullable<int> idTalle
		{
			get
			{
				return this._idTalle;
			}
			set
			{
				if ((this._idTalle != value))
				{
					this._idTalle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPromocion", DbType="Int")]
		public System.Nullable<int> idPromocion
		{
			get
			{
				return this._idPromocion;
			}
			set
			{
				if ((this._idPromocion != value))
				{
					this._idPromocion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCalificacion", DbType="Int")]
		public System.Nullable<int> idCalificacion
		{
			get
			{
				return this._idCalificacion;
			}
			set
			{
				if ((this._idCalificacion != value))
				{
					this._idCalificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagen", DbType="NVarChar(250)")]
		public string imagen
		{
			get
			{
				return this._imagen;
			}
			set
			{
				if ((this._imagen != value))
				{
					this._imagen = value;
				}
			}
		}
	}
	
	public partial class seleccionProductosResult
	{
		
		private string _Codigo;
		
		private string _NombreProducto;
		
		private string _Descripcion;
		
		private System.Nullable<decimal> _Precio;
		
		private System.Nullable<int> _Stock;
		private string _FechaDeAlta; 
		
		private System.Nullable<int> _Marca;
		
		private System.Nullable<int> _Tipo;
		
		private System.Nullable<int> _Temporada;
		
		private System.Nullable<int> _Sexo;
		
		private System.Nullable<int> _Color;
		
		private System.Nullable<int> _Talle;
		
		private System.Nullable<int> _Promocion;
		
		private System.Nullable<int> _Calificacion;
		
		private string _Imagen;
		
		public seleccionProductosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreProducto", DbType="NVarChar(50)")]
		public string NombreProducto
		{
			get
			{
				return this._NombreProducto;
			}
			set
			{
				if ((this._NombreProducto != value))
				{
					this._NombreProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="NVarChar(250)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stock", DbType="Int")]
		public System.Nullable<int> Stock
		{
			get
			{
				return this._Stock;
			}
			set
			{
				if ((this._Stock != value))
				{
					this._Stock = value;
				}
			}
		}

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FechaDeAlta", DbType = "NVarChar(250)")]
        public string FechaDeAlta
        {
            get
            {
                return this._FechaDeAlta;
            }
            set
            {
                if ((this._FechaDeAlta != value))
                {
                    this._FechaDeAlta = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marca", DbType="Int")]
		public System.Nullable<int> Marca
		{
			get
			{
				return this._Marca;
			}
			set
			{
				if ((this._Marca != value))
				{
					this._Marca = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo", DbType="Int")]
		public System.Nullable<int> Tipo
		{
			get
			{
				return this._Tipo;
			}
			set
			{
				if ((this._Tipo != value))
				{
					this._Tipo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Temporada", DbType="Int")]
		public System.Nullable<int> Temporada
		{
			get
			{
				return this._Temporada;
			}
			set
			{
				if ((this._Temporada != value))
				{
					this._Temporada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="Int")]
		public System.Nullable<int> Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="Int")]
		public System.Nullable<int> Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this._Color = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Talle", DbType="Int")]
		public System.Nullable<int> Talle
		{
			get
			{
				return this._Talle;
			}
			set
			{
				if ((this._Talle != value))
				{
					this._Talle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Promocion", DbType="Int")]
		public System.Nullable<int> Promocion
		{
			get
			{
				return this._Promocion;
			}
			set
			{
				if ((this._Promocion != value))
				{
					this._Promocion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Calificacion", DbType="Int")]
		public System.Nullable<int> Calificacion
		{
			get
			{
				return this._Calificacion;
			}
			set
			{
				if ((this._Calificacion != value))
				{
					this._Calificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="NVarChar(250)")]
		public string Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this._Imagen = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
