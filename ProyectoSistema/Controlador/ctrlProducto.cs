using ProyectoSistema.ModeloDatos;
using ProyectoSistema.Negocio;
using System.Collections.Generic;

namespace ProyectoSistema.Controlador
{
    class ctrlProducto
    {
        public static int Agregar(int idProd, string codProd, string nomProd,
                                 string descr, decimal precioCompra, decimal precioVenta, bool estado,int stock, int categId)
        {
            Productos prod = new Productos(idProd, codProd, nomProd, descr,
                                            precioCompra, precioVenta, estado, stock, categId);
            //Mandar a llamar el metodo guardar
            return prod.Guardar();
        }

        public static int GuardarProducto(string codProd, string nomProd,
                                 string descr, bool estado, int cat)
        {
            Productos prod = new Productos( codProd, nomProd, descr,
                                            estado, cat);
            //Mandar a llamar el metodo guardar
            return prod.Guardar();
        }

        public static Producto Buscar(string cod)
        {
            Productos prod = new Productos();
            return prod.Leer(cod);
        }

        public static List<Producto> Buscar()
        {
            Productos prod = new Productos();
            return prod.Leer();
        }
    }
}
