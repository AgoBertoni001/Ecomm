using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaProducto;
using System.Configuration;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Ecomm
{
    public partial class _Default : Page
    {
        OperacionesProductos db = new OperacionesProductos(ConfigurationManager.ConnectionStrings["connDB"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
             
        }
        public void CargarProductos()
        {
            gvdProductos.DataSource = db.Recupera();
            gvdProductos.DataBind();
        }

        public void GuardarProducto(string codigo,string nombreProducto,string descripcion,decimal precio, int stock,string fechaDeAlta,int idMarca,int idTipo,int idTemporada, int idSexo,int idColor,int idTalle,int idPromocion, int idCalificacion,string imagen)
        {
            db.Insertar(codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
        }
        protected void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto(txtCodigo.Text,txtNombre.Text, txtDescripcion.Text,decimal.Parse(txtPrecio.Text), int.Parse(txtStock.Text), txtFechaDeAlta.Text, int.Parse(txtIdMarca.Text),
                int.Parse(txtIdTipo.Text), int.Parse(txtIdTemporada.Text), int.Parse(txtIdSexo.Text), int.Parse(txtIdColor.Text), int.Parse(txtIdTalle.Text), int.Parse(txtIdPromocion.Text), 
                int.Parse(txtIdCalificacion.Text),txtImagen.Text);
            CargarProductos();
            pnlAltaProdcucto.Visible = false;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtFechaDeAlta.Text = "";
            txtIdMarca.Text = "";
            txtIdTipo.Text = "";
            txtIdTemporada.Text = "";
            txtIdSexo.Text = "";
            txtIdColor.Text = "";
            txtIdTalle.Text = "";
            txtIdPromocion.Text = "";
            txtIdCalificacion.Text = "";
            txtImagen.Text = "";
        }

        protected void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            pnlAltaProdcucto.Visible = true;
        }

    }
}