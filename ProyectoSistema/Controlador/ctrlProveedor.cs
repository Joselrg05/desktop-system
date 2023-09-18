using ProyectoSistema.ModeloDatos;
using ProyectoSistema.Negocio;
using System;
using System.Collections.Generic;

namespace ProyectoSistema.Controlador
{
    class ctrlProveedor
    {
        public static int Añadir(int id, string codigo, string razon, string correo, string telefono, DateTime fecha)
        {
            Proveedores objProv = new Proveedores(id, codigo, razon, correo, telefono, fecha);
            return objProv.Guardar();
        }

        public static Proveedor GetProveedor(string cod)
        {
            Proveedores objProv = new Proveedores();
            return objProv.Leer(cod);
        }

        public static List<Proveedor> Buscar()
        {
            Proveedores objProv = new Proveedores();
            return objProv.Leer();
        }

    }
}
