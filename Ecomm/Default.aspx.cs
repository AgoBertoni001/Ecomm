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
                CargarMarca();
                CargarTipo();
                CargarTemporada();
                CargarSexo();
                CargarColor();
                CargarTalle();
                CargarPromocion();
                CargarCalificacion();
            }

        }
        public void CargarProductos()
        {
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
            GuardarProducto(txtCodigo.Text,txtNombre.Text, txtDescripcion.Text,decimal.Parse(txtPrecio.Text), int.Parse(txtStock.Text), txtFechaDeAlta.Text, int.Parse(ddlMarca.Text),
                int.Parse(ddlTipo.Text), int.Parse(ddlTemporada.Text), int.Parse(ddlSexo.Text), int.Parse(ddlColor.Text), int.Parse(ddlTalle.Text), int.Parse(ddlPromocion.Text), 
                int.Parse(ddlCalificacion.Text),txtImagen.Text);
            CargarProductos();
            pnlAltaProdcucto.Visible = false;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtFechaDeAlta.Text = "";
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
            ddlMarca.Text = row.Cells[6].Text;
            ddlTipo.Text = row.Cells[7].Text;
            ddlTemporada.Text = row.Cells[8].Text;
            ddlSexo.Text = row.Cells[9].Text;
            ddlColor.Text = row.Cells[10].Text;
            ddlTalle.Text = row.Cells[11].Text;
            ddlPromocion.Text = row.Cells[12].Text;
            ddlCalificacion.Text = row.Cells[13].Text;
            txtImagen.Text = row.Cells[14].Text;
        }

        public void ActualizarProducto(string codigo, string nombreProducto, string descripcion, decimal precio, int stock, string fechaDeAlta, int idMarca, int idTipo, int idTemporada, int idSexo, int idColor, int idTalle, int idPromocion, int idCalificacion, string imagen)
        {
            db.Actualizar(codigo, nombreProducto, descripcion, precio, stock, fechaDeAlta, idMarca, idTipo, idTemporada, idSexo, idColor, idTalle, idPromocion, idCalificacion, imagen);
        }

        protected void btnActualizar_Click(object sender,EventArgs e)
        {
            pnlAltaProdcucto.Visible = false;
            ActualizarProducto(lblCodigo.Text, txtNombre.Text, txtDescripcion.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtStock.Text), txtFechaDeAlta.Text, int.Parse(ddlMarca.Text),
                int.Parse(ddlTipo.Text), int.Parse(ddlTemporada.Text), int.Parse(ddlSexo.Text), int.Parse(ddlColor.Text), int.Parse(ddlTalle.Text), int.Parse(ddlPromocion.Text),
                int.Parse(ddlCalificacion.Text), txtImagen.Text);
            btnActualizar.Visible = false;
            btnGuardarProducto.Visible = Visible;
            CargarProductos();
        }

        public void EliminarProducto(string codigo)
        {
            db.Eliminar(codigo);
        }

        protected void lkbEliminar_Click(object sender,EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            gvdProductos.SelectedIndex = row.RowIndex;
            lblCodigo.Text = row.Cells[0].Text;
            EliminarProducto(lblCodigo.Text);
            CargarProductos();
        }

        public void CargarMarca()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionMarca";
                cmd.Connection = conn;
                conn.Open();
                ddlMarca.DataSource = cmd.ExecuteReader();
                ddlMarca.DataTextField = "nombreMarca";
                ddlMarca.DataValueField = "id";
                ddlMarca.DataBind();
                ddlMarca.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarTipo()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionTipo";
                cmd.Connection = conn;
                conn.Open();
                ddlTipo.DataSource = cmd.ExecuteReader();
                ddlTipo.DataTextField = "nombreTipo";
                ddlTipo.DataValueField = "id";
                ddlTipo.DataBind();
                ddlTipo.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarTemporada()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionTemporada";
                cmd.Connection = conn;
                conn.Open();
                ddlTemporada.DataSource = cmd.ExecuteReader();
                ddlTemporada.DataTextField = "nombreTemporada";
                ddlTemporada.DataValueField = "id";
                ddlTemporada.DataBind();
                ddlTemporada.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarSexo()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionSexo";
                cmd.Connection = conn;
                conn.Open();
                ddlSexo.DataSource = cmd.ExecuteReader();
                ddlSexo.DataTextField = "nombreSexo";
                ddlSexo.DataValueField = "id";
                ddlSexo.DataBind();
                ddlSexo.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarColor()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionColor";
                cmd.Connection = conn;
                conn.Open();
                ddlColor.DataSource = cmd.ExecuteReader();
                ddlColor.DataTextField = "nombreColor";
                ddlColor.DataValueField = "id";
                ddlColor.DataBind();
                ddlColor.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarTalle()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionTalle";
                cmd.Connection = conn;
                conn.Open();
                ddlTalle.DataSource = cmd.ExecuteReader();
                ddlTalle.DataTextField = "medida";
                ddlTalle.DataValueField = "id";
                ddlTalle.DataBind();
                ddlTalle.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarPromocion()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionPromocion";
                cmd.Connection = conn;
                conn.Open();
                ddlPromocion.DataSource = cmd.ExecuteReader();
                ddlPromocion.DataTextField = "nombrePromocion";
                ddlPromocion.DataValueField = "id";
                ddlPromocion.DataBind();
                ddlPromocion.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        public void CargarCalificacion()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleccionCalificacion";
                cmd.Connection = conn;
                conn.Open();
                ddlCalificacion.DataSource = cmd.ExecuteReader();
                ddlCalificacion.DataTextField = "valoracion";
                ddlCalificacion.DataValueField = "id";
                ddlCalificacion.DataBind();
                ddlCalificacion.Items.Insert(0, new ListItem("- - Seleccionar - -", "0"));
            }
        }

        protected void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }protected void ddlCalificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}