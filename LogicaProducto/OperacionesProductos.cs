using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosProductos;

namespace LogicaProducto
{
    public class OperacionesProductos : IDisposable
    {
        //recursos manejados - permite manejar los recursos de la conexion con la base de datos
        private Component componentes = new Component();
        DatosProductos.DataClasses1DataContext datosContext;

        //indica si ya se llamo al metodo Dispose. (defautl = false)
        private Boolean disposed;
        ///<summary>
        ///implementacion de IDisposable. No se sobreescribe
        ///<summary>

        public void Dispose()
        {
            this.Dispose(true);
            //GC. SupressFinalize quita de la cola de finalizacion al objeto
            GC.SuppressFinalize(this);
        }
        ///<summary>
        ///limpia los recursos manejados y no manejados.
        ///<summary>
        ///<param name="disposing">
        ///si es true, el metodos es llamado directamente o indirectamente
        ///desde el codigo del usuario.
        ///si es false, el metodo es llamado por el finalizador
        ///y solo los recursos no manejados son finalizados.
        ///</param> 
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //llamamos al Dispose de todos los recursos manejados
                    this.componentes.Dispose();
                    this.componentes = null;
                }
            }
            this.disposed = true;
        }

        ///<summary>
        ///destructor de la instancia
        ///<summary>
        ~OperacionesProductos()
        {
            this.Dispose(false);
        }
        public OperacionesProductos(string conexion)
        {
            datosContext = new DatosProductos.DataClasses1DataContext(conexion);
        }

        //muestra todo
        #region SELECT
        public DataTable Recupera()
        {
            DataTable dt = new DataTable();
            try
            {
                using (DataClasses1DataContext db =new DataClasses1DataContext())
                {
                    //va al procedimiento almacenado y recupera todos los datos que almacena
                    return dt = CustomDataTable.CopyToDataTable(db.mostrarProducto().ToArray());
                }
            }
            catch (Exception)
            {
                dt = null;
                return dt;
            }
        }
        #endregion

        //inserta nuevo
        #region INSERT
        public bool Insertar(string codigo,string nombreProducto,string descripcion,decimal precio,int stock,string fechaDeAlta,int idMarca,int idTipo,int idTemporada,int idSexo,int idColor,int idTalle,int idPromocion,int idCalificacion,string imagen)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.insertarProducto(codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        //elimina
        #region DELETE 
        public bool Eliminar(string codigo)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.eliminaProducto(codigo);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        //actualiza registro
        #region UPDATE
        public bool Actualizar(string codigo, string nombreProducto, string descripcion, decimal precio, int stock, string fechaDeAlta, int idMarca, int idTipo, int idTemporada, int idSexo, int idColor, int idTalle, int idPromocion, int idCalificacion, string imagen)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.actualizarProductos(codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        //modifica algun registro
        #region MODIFY
        public bool Modificar(string codigo, string nombreProducto, string descripcion, decimal precio, int stock, string fechaDeAlta, int idMarca, int idTipo, int idTemporada, int idSexo, int idColor, int idTalle, int idPromocion, int idCalificacion, string imagen)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.modificaProducto(codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

    }
}
