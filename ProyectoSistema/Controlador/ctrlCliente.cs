using ProyectoSistema.ModeloDatos;
using ProyectoSistema.Negocio;
using System;
using System.Collections.Generic;

namespace ProyectoSistema.Controlador
{
    class ctrlCliente
    {
        public static int Agregar(int id, string codigo, string nombres,
                                 string apellido1, string apellido2, string telefono, string correo, DateTime fecha)
        {
            Clientes objClie = new Clientes(id, codigo, nombres, apellido1, apellido2, telefono, correo, fecha);
            return objClie.Guardar();
        }

        public static Cliente Buscar(string filtro)
        {
            Clientes objClie = new Clientes();
            return objClie.Leer(filtro);
        }

        public static List<Cliente> Buscar()
        {
            Clientes objClie = new Clientes();
            return objClie.Listar();
        }
    }
}
