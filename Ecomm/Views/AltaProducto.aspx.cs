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

namespace Ecomm.Views
{
    public partial class AltaProducto : System.Web.UI.Page
    {
        OperacionesProductos db = new OperacionesProductos(ConfigurationManager.ConnectionStrings["connDB"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}