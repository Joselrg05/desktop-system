using ProyectoSistema.ModeloDatos;
using ProyectoSistema.Negocio;
using System;
using System.Collections.Generic;

namespace ProyectoSistema.Controlador
{
    class ctrlUsuario
    {
        public static int Agregar(int id, string codigo, string nombre, string clave, string correo, Rol rol, DateTime fecha)
        {
            Usuarios objUsua = new Usuarios(id, codigo, nombre, clave, correo, rol, fecha);
            return objUsua.Guardar();
        }

        public static Usuario Buscar(string cod)
        {
            Usuarios objUsua = new Usuarios();
            return objUsua.Buscar(cod);
        }

        public static List<Usuario> Buscar()
        {
            Usuarios objUsua = new Usuarios();
            return objUsua.Buscar();
        }
    }
}
