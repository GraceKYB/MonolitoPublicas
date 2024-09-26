using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Cl_tbl_tipo_usuario
    {
        //conexion
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        public static List<tbl_tipo_usuario> obtener_tusu()
        {
            var lista = dc.tbl_tipo_usuario.Where(x => x.tusu_estado == 'A').ToList();
            return lista;
        }
    }
}
