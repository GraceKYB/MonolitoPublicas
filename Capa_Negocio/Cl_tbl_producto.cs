using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public  class Cl_tbl_producto
    {
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        public static List<tbl_producto> obtener_prove()
        {
            var lista = dc.tbl_producto.Where(pro => pro.pro_estado == 'A').ToList();
            return lista;
        }
        public static tbl_producto obtenerxid(int id)
        {
            var lista = dc.tbl_producto.FirstOrDefault(pro => pro.pro_estado == 'A' & pro.pro_id == id);
            return lista;
        }
        public static List<tbl_producto> obtenerxnom(string nom)
        {
            var lista = dc.tbl_producto.Where(pro => pro.pro_estado == 'A' & pro.pro_nombre.Contains(nom));
            return lista.ToList();
        }

        public static bool autentifica_pro(string nom)
        {
            var auto = dc.tbl_producto.Any(pro => pro.pro_nombre == nom);
            return auto;
        }

        public static void save (tbl_producto pro)
        {
            try
            {
                pro.pro_estado = 'A';
                dc.tbl_producto.InsertOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception )
            {
                throw;
            }
        }
        public static void modify(tbl_producto pro)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception )
            {
                throw;
            }
        }

        public static void delete(tbl_producto pro)
        {
            try
            {
                dc.tbl_producto.DeleteOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception )
            {
                throw;
            }
        }
        public static void guardar_imagen(int id, byte[] imagen)
        {
            var producto = obtenerxid(id);
            if (producto != null)
            {
                producto.pro_imagen = imagen;
                modify(producto); // Actualiza el producto en la base de datos
            }
        }

        public static byte[] obtener_imagen(int id)
        {
            var producto = obtenerxid(id);
            return producto?.pro_imagen.ToArray();
        }
        public static void update(tbl_producto pro)
        {
            try
            {
                var producto = obtenerxid(pro.pro_id);
                if (producto != null)
                {
                    producto.pro_nombre = pro.pro_nombre;
                    producto.pro_cantidad = pro.pro_cantidad;
                    producto.prov_id = pro.prov_id;
                    producto.pro_imagen = pro.pro_imagen;

                    modify(producto); // Actualiza el producto en la base de datos
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
