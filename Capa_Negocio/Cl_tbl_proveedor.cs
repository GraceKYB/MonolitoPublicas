using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Cl_tbl_proveedor
    {
        private static DataClasses1DataContext dc = new DataClasses1DataContext();
        
        public static List<tbl_proveedor> obtener_prove()
        {
            var lista = dc.tbl_proveedor.Where(prov => prov.prov_estado == 'A').ToList();
                return lista;
        }
     }
}
