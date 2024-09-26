using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Monolito4AMPublicar.mantenimiento
{
    public partial class Listar_Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                lbl_nombre.Text = Session["admin"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                cargar_productos();
            }
        }

        private void cargar_productos()
        {
            grv_pro.DataSource = Cl_tbl_producto.obtener_prove();
            grv_pro.DataBind();
        }

        protected void grv_pro_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/mantenimiento/Frm_Productos.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                tbl_producto pro = new tbl_producto();
                pro = Cl_tbl_producto.obtenerxid(codigo);

                if (pro != null)
                {
                    Cl_tbl_producto.delete(pro);
                    cargar_productos();
                }
            }

        }

        protected void img_lupa_Click(object sender, ImageClickEventArgs e)
        {
            string op = ddl_criterio.SelectedValue;

            if (op != "")
            {
                switch (op)
                {
                    case "N":
                        var quer = Capa_Negocio.Cl_tbl_producto.obtenerxnom(txt_buscar.Text);

                        if (quer.Count() != 0)
                        {
                            grv_pro.DataSource = quer;
                            grv_pro.DataBind();
                        }
                        else
                        {
                            cargar_productos();
                        }

                        break;
                    default:
                        break;
                }
            }
        }
        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mantenimiento/Frm_Productos.aspx");
        }

        protected void grv_pro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}