using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;
using System.Data.Linq;

namespace Monolito4AMPublicar
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }


        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }
        protected void ingresar()
        {
            if (string.IsNullOrEmpty(txt_cedula.Text))
            {
                lbl_sms_datos.Text = "Ingrese su cedula";
            }
            else if (string.IsNullOrEmpty(txt_pass.Text))
            {
                lbl_sms_datos.Text = "Ingrese su contraseña";
            }
            else
            {
                bool existe = Cl_tbl_usuario.autentificaxced
                    (txt_cedula.Text);
                {
                    if (existe)
                    {
                        bool existeusu = Cl_tbl_usuario.auntentificarxcp
                            (txt_cedula.Text, txt_pass.Text);


                        if (existeusu)
                        {
                            tbl_usuario usuinfo = new tbl_usuario();
                            usuinfo = Cl_tbl_usuario.obtenerxcp
                                (txt_cedula.Text, txt_pass.Text);

                            int tusu = Convert.ToInt32(usuinfo.tusu_id);
                            if (tusu == 1)
                            {
                                Session["admin"] = usuinfo.usu_nombre_completo;
                                Response.Redirect("~/mantenimiento/Frm_Productos.aspx");

                            }
                            if (tusu == 2)
                            {
                                Response.Redirect("~/mantenimiento/Usuario.aspx");
                            }
                            else
                            {
                                lbl_sms_datos.Text = "Credenciales incorrectas";
                            }
                        }
                        else
                        {
                            lbl_sms_datos.Text = "Usuario no existe";
                        }
                    }
                }
            }

        }

        protected void lnk_registrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrar.aspx");
        }

        protected void lnk_olvido_Click(object sender, EventArgs e)
        {
            Label1.Visible = txt_pass.Visible = btn_ingresar.Visible = false;
        }

        protected void lnk_recuperar_Click(object sender, EventArgs e)
        {
            bool existe = Cl_tbl_usuario.autentificaxced
                    (txt_cedula.Text);

            if (string.IsNullOrEmpty(txt_cedula.Text))
            {
                lbl_sms_datos.Text = "Ingrese su cédula para recuperar la contraseña";
            }
            else if (!existe)
            {
                lbl_sms_datos.Text = "Cédula no existe";
            }
            else
            {
                var datosUsu = Cl_tbl_usuario.obtenerxced
                    (txt_cedula.Text);
                string to = datosUsu.usu_correo;
                string msj = "Su contraseña olvidada es : " + datosUsu.usu_contraseña;

                if (new Mail().envia_correo(to, msj))
                {
                    lbl_sms_datos.Text = "Datos enviados a su correo";
                }
                else
                {
                    lbl_sms_datos.Text = "Correo no enviado";
                }
            }
        }
    }
}
