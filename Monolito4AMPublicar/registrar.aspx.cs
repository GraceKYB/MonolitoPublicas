using Capa_Datos;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Text;


namespace Monolito4AMPublicar
{
    public partial class registrar : System.Web.UI.Page
    {
        //manejar infromacion
        private tbl_usuario usuarioinfo = new tbl_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_tusu();
            }
        }

        private void cargar_tusu()
        {
            List<tbl_tipo_usuario> listatusu = new List<tbl_tipo_usuario>();
            listatusu = Cl_tbl_tipo_usuario.obtener_tusu();
            listatusu.Insert(0, new tbl_tipo_usuario() { tusu_nombre = "Seleccione" });

            ddl_Perfil.DataSource = listatusu;
            ddl_Perfil.DataTextField = "tusu_nombre";
            ddl_Perfil.DataValueField = "tusu_id";
            ddl_Perfil.DataBind();
        }

        protected void lnk_regresa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }



        protected void btn_Registrar_Click1(object sender, EventArgs e)
        {
            string cedula = txt_cedula.Text.Trim();
            string nombres = txt_nombres.Text.Trim();
            string direccion = txt_direccion.Text.Trim();
            string contraseña = txt_contraseña.Text.Trim();
            string correo = txt_correo.Text.Trim();

            // Validación de cédula
            if (string.IsNullOrEmpty(cedula) || cedula.Length != 10 || !cedula.All(char.IsDigit))
            {
                lbl_sms_cedula.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_cedula.Text = "La cédula debe contener exactamente 10 dígitos numéricos.";
                return;
            }

            // Validación de nombres y dirección
            // Verificar que se ingresen dos nombres y dos apellidos
            string[] partesNombre = nombres.Split(' ');

            if (partesNombre.Length != 4)
            {
                lbl_sms_nombres.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_nombres.Text = "Ingrese dos nombres y dos apellidos.";
                return;
            }

            // Verificar que todos los caracteres sean letras
            if (!nombres.All(c => char.IsLetter(c) || c == ' '))
            {
                lbl_sms_nombres.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_nombres.Text = "Los nombres solo pueden contener letras.";
                return;
            }

            // Verificar longitud máxima
            if (nombres.Length > 100)
            {
                lbl_sms_nombres.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_nombres.Text = "Los nombres solo pueden contener un máximo de 100 caracteres.";
                return;
            }

            // Si se pasan todas las validaciones, continuar con el proceso
            // Aquí puedes poner el código que deseas ejecutar si la validación es exitosa



            // Validación dirección
            //if (!direccion.All(char.IsLetter))
            if (direccion.Length >100)
            {
                lbl_sms_direccion.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_direccion.Text = "La dirección solo pueden contener un máximo de 100 carácteres.";
                return;
            }



            // Validación de contraseña
            if (string.IsNullOrEmpty(contraseña) || contraseña.Length < 8 || contraseña.Length > 20 || !contraseña.Any(char.IsUpper) ||
                !contraseña.Any(char.IsLower) || !contraseña.Any(char.IsDigit) || !contraseña.Any(char.IsPunctuation))
            {
                lbl_sms_contra.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_contra.Text = "La contraseña debe tener entre 8 y 20 caracteres, al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.";
                return;

            }


            // Validación de correo electrónico


            if (!IsValidEmail(correo))
            {
                lbl_sms_correo.ForeColor = System.Drawing.Color.DarkRed;
                lbl_sms_correo.Text = "Ingrese un correo electrónico válido.";
                return;
            }


            try
            {
                bool existe = Cl_tbl_usuario.repetidos
                    (txt_cedula.Text);
                {
                    if (existe)
                    {
                        lbl_sms_cedula.ForeColor = System.Drawing.Color.DarkRed;
                        lbl_sms_cedula.Text = " La cedula no puede repetirse";
                    }

                    else
                    {

                        usuarioinfo = new tbl_usuario();

                        usuarioinfo.usu_cedula = txt_cedula.Text.Trim();
                        usuarioinfo.usu_nombre_completo = txt_nombres.Text.Trim();
                        usuarioinfo.usu_direccion = txt_direccion.Text.Trim();
                        usuarioinfo.usu_contraseña = txt_contraseña.Text.Trim();
                        usuarioinfo.usu_correo = txt_correo.Text.Trim();
                        
                        string encryptedContrasenia = AESCryptographer.Encrypt(usuarioinfo.usu_contraseña);
                        byte[] bytes = Encoding.ASCII.GetBytes(encryptedContrasenia); 
                        usuarioinfo.usu_contra_enc = new Binary(bytes);

                        usuarioinfo.tusu_id = Convert.ToInt32(ddl_Perfil.SelectedValue);

                        Cl_tbl_usuario.save(usuarioinfo);

                        lbl_mensajes.ForeColor = System.Drawing.Color.Green;
                        lbl_mensajes.Text = "Datos guardados";

                        lbl_sms_cedula.Text = null;
                        lbl_sms_nombres.Text = null;
                        lbl_sms_direccion.Text = null;
                        lbl_sms_contra.Text = null;
                        lbl_sms_correo.Text = null;

                    }
                }

            }
            catch (Exception)
            {
                lbl_mensajes.ForeColor = System.Drawing.Color.DarkRed;
                lbl_mensajes.Text = "Datos no guardados";
            }


        }
        private bool IsValidEmail(string email)
        {
            try
            {


                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {


                return false;
            }
        }
    }
}