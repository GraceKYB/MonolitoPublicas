using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Cl_tbl_usuario
    {
        //instanciamos la conexion
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        public static List<tbl_usuario> obtener_tusu()
        {
            var lista = dc.tbl_usuario.Where(x => x.usu_estado == 'A').ToList();
            return lista;
        }

        public static bool autentificaxced(string cedula)
        {
            var lista = dc.tbl_usuario.Any(x => x.usu_estado == 'A' & x.usu_cedula == cedula);
            return lista;
        }

        public static bool auntentificarxcp(string cedula, string pass)
        {
            var lista = dc.tbl_usuario.Any(x => x.usu_estado == 'A' & x.usu_cedula == cedula & x.usu_contraseña == pass);
            return lista;
        }

        public static bool repetidos(string cedula)
        {
            var lista = dc.tbl_usuario.Any(x => x.usu_estado == 'A' & x.usu_cedula == cedula);
            return lista;
        }
        public static tbl_usuario obtenerxced(string cedula)
        {
            var lista = dc.tbl_usuario.FirstOrDefault(x => x.usu_estado == 'A' & x.usu_cedula == cedula);
            return lista;
        }

        public static tbl_usuario obtenerxcp(string cedula, string pass)
        {
            var lista = dc.tbl_usuario.FirstOrDefault(x => x.usu_estado == 'A' & x.usu_cedula == cedula & x.usu_contraseña == pass);
            return lista;
        }

        //guardar y modificar

        public static void save(tbl_usuario usu)
        {
            try
            {
                usu.usu_fecha_creacion = DateTime.Now;
                usu.usu_estado = 'A';
                dc.tbl_usuario.InsertOnSubmit(usu);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados </br>" + ex.Message);

            }
        }

        public static void mody(tbl_usuario usu)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido modificados </br>" + ex.Message);
            }
        }

    }
}
