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
using System.Data.SqlClient;
using System.Data;

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
        //hace que se llene el gridview
        public void CargarProductos()
        {
            //Conexion a base de datos
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionProductos";
                cmd.Connection = conn;
                conn.Open();
                gvdProductos.DataSource = cmd.ExecuteReader();
                gvdProductos.DataBind();
            }
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

        protected void lkbActualizar_Click(object sender, EventArgs e)
        {
            pnlAltaProdcucto.Visible = true;
            btnActualizar.Visible = true;
            btnGuardarProducto.Visible = false;
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            lblCodigo.Text = row.Cells[0].Text;
            txtNombre.Text = row.Cells[1].Text;
            txtDescripcion.Text = row.Cells[2].Text;
            txtPrecio.Text = row.Cells[3].Text;
            txtStock.Text = row.Cells[4].Text;
            txtFechaDeAlta.Text = row.Cells[5].Text;
            txtIdMarca.Text = row.Cells[6].Text;
            txtIdTipo.Text = row.Cells[7].Text;
            txtIdTemporada.Text = row.Cells[8].Text;
            txtIdSexo.Text = row.Cells[9].Text;
            txtIdColor.Text = row.Cells[10].Text;
            txtIdTalle.Text = row.Cells[11].Text;
            txtIdPromocion.Text = row.Cells[12].Text;
            txtIdCalificacion.Text = row.Cells[13].Text;
            txtImagen.Text = row.Cells[14].Text;
        }

        public void ActualizarProducto(string codigo, string nombreProducto, string descripcion, decimal precio, int stock, string fechaDeAlta, int idMarca, int idTipo, int idTemporada, int idSexo, int idColor, int idTalle, int idPromocion, int idCalificacion, string imagen)
        {
            db.Actualizar(codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
        }

        protected void btnActualizar_Click(object sender,EventArgs e)
        {
            pnlAltaProdcucto.Visible = false;
            ActualizarProducto(lblCodigo.Text, txtNombre.Text, txtDescripcion.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtStock.Text), txtFechaDeAlta.Text, int.Parse(txtIdMarca.Text),
                int.Parse(txtIdTipo.Text), int.Parse(txtIdTemporada.Text), int.Parse(txtIdSexo.Text), int.Parse(txtIdColor.Text), int.Parse(txtIdTalle.Text), int.Parse(txtIdPromocion.Text),
                int.Parse(txtIdCalificacion.Text), txtImagen.Text);
            btnActualizar.Visible = false;
            btnGuardarProducto.Visible = Visible;
            CargarProductos();
        }

        public void eliminarProducto(string codigo)
        {
            db.Eliminar(codigo);
        }

        protected void lkbEliminar_Click(object sender,EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            gvdProductos.SelectedIndex = row.RowIndex;
            lblCodigo.Text = row.Cells[0].Text;
            eliminarProducto(lblCodigo.Text);
            CargarProductos();
        }

    }
}