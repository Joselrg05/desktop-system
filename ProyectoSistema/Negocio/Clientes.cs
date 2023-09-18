using ProyectoSistema.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSistema.Negocio
{
    class Clientes
    {
        //Instanciamos un obj privado de tipo cliente....
        private Cliente cliente;

        //Constructor vacío...
        //(Nos ayudara más adelante)
        public Clientes()
        {

        }

        //Creamos otro constructor, pero este contendra sus argumentos....
        public Clientes(int id, string codigo, string nombres,
                        string apellido1, string apellido2, string telefono, string correo, DateTime fecha)
        {
            //Igualamos las instancia de nuestro contexto de BD
            //a los argumentos de nuestro constructor...
            cliente = new Cliente();
            cliente.Id = id;
            cliente.Codigo = codigo;
            cliente.Nombres = nombres;
            cliente.Apellido1 = apellido1;
            cliente.Apellido1 = apellido2;
            cliente.Telefono = telefono;
            cliente.Correo = correo;
            cliente.Fechacreacion = fecha;
            cliente.Estado = true;
        }

        public int Guardar()
        {
            int valor = 0;
            //Llamamos a nuestro contexto de base de datos...
            Sistema_VentaEntities connect = new Sistema_VentaEntities();
            //Instanciamos otro objeto de nuestro clase Cliente...
            Cliente objCliente = new Cliente();

            //Decalaramos una variable de tipo Var, donde almacenaremos los registro de nuestro clientes....
            //Haciendo uso de un comando de Entity framework nos facilita "FirstOrDefault"...
            var registro = connect.Cliente.FirstOrDefault(a => a.Codigo == cliente.Codigo); //En esta instrucción hacemos una igaualación del registro
                                                                                            //para verificar si cumple dicha condición...

            //Hacemos uso de una condicional en caso de que nuestro registro de tipo Var sea distinto al que buscamos...
            if (registro != null)
            {
                //update => modificar, actualizar, etc...
                //Tambien hacemos uso de una variable de rango que se llamara cliList
                var update = (from cliList in connect.Cliente where cliList.Codigo == cliente.Codigo select cliList).FirstOrDefault();

                update.Id = cliente.Id;
                update.Codigo = cliente.Codigo;
                update.Nombres = cliente.Nombres;
                update.Apellido1 = cliente.Apellido1;
                update.Apellido1 = cliente.Apellido2;
                update.Telefono = cliente.Telefono;
                update.Correo = cliente.Correo;
                update.Fechacreacion = cliente.Fechacreacion;
                update.Estado = cliente.Estado;
            }

            //En caso de que no se cumpla la primera condición se hace lo siguiente...
            else
            {
                objCliente.Id = cliente.Id;
                objCliente.Codigo = cliente.Codigo;
                objCliente.Nombres = cliente.Nombres;
                objCliente.Apellido1 = cliente.Apellido1;
                objCliente.Apellido2 = cliente.Apellido2;
                objCliente.Telefono = cliente.Telefono;
                objCliente.Fechacreacion = cliente.Fechacreacion;
                objCliente.Estado = cliente.Estado;

                //Guardamos el el registro del objeto cliete en nuestro contexto de nuestra base de datos...
                connect.Cliente.Add(objCliente);
            }


            //Ahora bien vamos a suplir nuestras excepciones haciendo uso de la función try-catch...
            try
            {
                //Valor => Variable definida al comienzo del constructor, es de tipo entero...
                valor = connect.SaveChanges();
            }
            catch
            {
                throw new ArgumentNullException();
                throw new InvalidOperationException();
                throw new System.Data.Entity.Infrastructure.DbUpdateException();
            }

            //Retornamos la variable valor; puesto que es un constructor de tipo entero y no uno de vacío...
            return valor;
        }

        public Cliente Leer(string filtro)
        {
            //Instanciamos nuestro contexto de nuestra Base de datos...
            Sistema_VentaEntities conexion = new Sistema_VentaEntities();
            try
            {
                //instanciamos un objeto de la clase Cliente...
                //Declaramos u a variable de rango que me permita usar el comando FIRST...
                Cliente objcliente = conexion.Cliente.First(e => e.Codigo == filtro);
                return objcliente;
            }
            catch
            {
                //Si no se cumple pues, simplemtente retornamos null...
                return null;
            }
        }

        //Necesitamos hacer uso de una lista de cliente, tipo arreglo o pila...
        public List<Cliente> Listar()
        {
            //Mandamos a llamar a nuestro contexto de BD...
            Sistema_VentaEntities sistema = new Sistema_VentaEntities();

            var listaCliente = sistema.Cliente.Select(a => new
            {
                Id = a.Id,
                Codigo = a.Codigo,
                Nombres = a.Nombres,
                Apellidos = a.Apellido1 + " " + a.Apellido2,
                Celular = a.Telefono,
                Correo = a.Correo,
                Fecha = a.Fechacreacion,
                Estado = a.Estado

            }).ToList().Select(a => new Cliente()
            {
                Id = a.Id,
                Codigo = a.Codigo,
                Nombres = a.Nombres,
                Apellido1 = a.Apellidos,
                Telefono = a.Celular,
                Correo = a.Correo,
                Fechacreacion = a.Fecha,
                Estado = a.Estado
            });

            //Retornamos la lista de Clientes...
            return listaCliente.ToList();

        }
    }
}
