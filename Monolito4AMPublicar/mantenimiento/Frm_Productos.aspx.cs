using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;

namespace Monolito4AMPublicar.mantenimiento
{
    public partial class Frm_Productos : System.Web.UI.Page
    {
        private tbl_producto productoinfo = new tbl_producto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["Cod"] != null)
                {
                    lnk_nuevo.Visible = false;
                    lnk_editar.Visible = true;

                    int codi = Convert.ToInt32(Request["cod"]);
                    productoinfo = Cl_tbl_producto.obtenerxid(codi);

                    if(productoinfo != null)
                    {
                        txt_nombre.Text = productoinfo.pro_nombre;
                        txt_cantidad.Text = productoinfo.pro_cantidad.ToString();
                        ddl_proveedor.SelectedValue = productoinfo.prov_id.ToString();
                        lnk_guardar.Visible = false;
                    }
                }
                cargar_proveedor();
            }
        }

        private void cargar_proveedor()
        {
            List<tbl_proveedor> listprov = new List<tbl_proveedor>();
            listprov = Cl_tbl_proveedor.obtener_prove();
            listprov.Insert(0, new tbl_proveedor() { prov_nombre = "seleccione" });

            ddl_proveedor.DataSource = listprov;
            ddl_proveedor.DataTextField = "prov_nombre";
            ddl_proveedor.DataValueField = "prov_id";
            ddl_proveedor.DataBind();
        }

        private void cargar_producto(int id)
        {
            productoinfo = Cl_tbl_producto.obtenerxid(id);
            if (productoinfo != null)
            {
                txt_nombre.Text = productoinfo.pro_nombre;
                txt_cantidad.Text = productoinfo.pro_cantidad.ToString();
                ddl_proveedor.SelectedValue = productoinfo.prov_id.ToString();
               
            }
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            hfProductId.Value = "0";
            txt_nombre.Text = "";
            txt_cantidad.Text = "0";
            ddl_proveedor.SelectedIndex = 0;
            
        }

        protected void lnk_guardar_Click(object sender, EventArgs e)
        {
            bool existe = Cl_tbl_producto.autentifica_pro(txt_nombre.Text);
            if (existe)
            {
                lbl_mensaje.Text = "Producto existente";
            }
            else
            {
                lbl_mensaje.Text = "";
                guardar_modificar_datos(Convert.ToInt32(hfProductId.Value));
            }
        }

        public void guardar_modificar_datos(int id)
        {
            if (id == 0)
            {
                try
                {
                    productoinfo = new tbl_producto();
                    productoinfo.pro_nombre = txt_nombre.Text;
                    productoinfo.pro_cantidad = Convert.ToInt32(txt_cantidad.Text);
                    productoinfo.prov_id = Convert.ToInt32(ddl_proveedor.SelectedValue);

                    Cl_tbl_producto.save(productoinfo);
                    lbl_mensaje.Text = "Datos guardados";
                }
                catch (Exception ex)
                {
                    lbl_mensaje.Text = "Error al guardar: " + ex.Message;
                }
            }
            else
            {
                try
                {
                    productoinfo = Cl_tbl_producto.obtenerxid(id);
                    if (productoinfo != null)
                    {
                        productoinfo.pro_nombre = txt_nombre.Text;
                        productoinfo.pro_cantidad = Convert.ToInt32(txt_cantidad.Text);
                        productoinfo.prov_id = Convert.ToInt32(ddl_proveedor.SelectedValue);

                        Cl_tbl_producto.update(productoinfo);
                        lbl_mensaje.Text = "Datos actualizados";
                    }
                }
                catch (Exception ex)
                {
                    lbl_mensaje.Text = "Error al actualizar: " + ex.Message;
                }
            }
        }

        protected void lnk_editar_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos(Convert.ToInt32(Request["cod"]));
        }

        protected void lnk_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mantenimiento/Listar_Productos.aspx");
        }
    }
}
