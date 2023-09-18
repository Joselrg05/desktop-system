using ProyectoSistema.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSistema.Negocio
{
    class Usuarios
    {
        //Instanciamis un objeto de la clase usuario y lo protegemos...
        private Usuario usuario;

        //Constructor vacío...
        public Usuarios() { }

        //Contructor con argumentos específicos
        public Usuarios(int id, string codigo, string nombre, string clave, string correo, Rol rol, DateTime fecha)
        {
            usuario = new Usuario()
            {
                Id = id,
                Codigo = codigo,
                NombreCompleto = nombre,
                Clave = clave,
                Correo = correo,
                Rol = rol,
                Fechacreacion = fecha,
                Estado = true
            }; //El punto coma esta afuera del constructor 
               //puesto que es un manera de simplificar la sintaxis del lenguaje C#...
        }

        public int Guardar()
        {
            //Valor => variable que me específicara si mi usuario fue guardado exitosamente...
            int valor = 0;
            //Traemos a nuestro contexto de Bases de datos...
            Sistema_VentaEntities connect = new Sistema_VentaEntities();
            Usuario user = new Usuario();

            //Registro, variable que almacena el primer elemento de una
            //secuencia o un valor predeterminado si no se encuentra ningún elemento con ayuda de
            //nuestro comando "FirstOrDefault".
            var registro = connect.Usuario.FirstOrDefault(e => e.Codigo == usuario.Codigo);

            if (registro != null)
            {
                //listUser, hacemos uso de una variable de rango, que enlaza a la 
                //nuestro contexto de bases de datos y compara por medio de codigo y si son similares
                //selecciona ese item del contexto de BD y lo devuelve haciendo uso de FirstOrDefault...
                var update = (from listUser in connect.Usuario where listUser.Codigo == usuario.Codigo select listUser).FirstOrDefault();

                update.Codigo = usuario.Codigo;
                update.NombreCompleto = usuario.NombreCompleto;
                update.Clave = usuario.Clave;
                update.Correo = usuario.Correo;
                update.Rol = usuario.Rol;
                update.Fechacreacion = usuario.Fechacreacion;
                update.Estado = usuario.Estado;
            }
            else
            {
                user.Codigo = usuario.Codigo;
                user.NombreCompleto = usuario.NombreCompleto;
                user.Clave = usuario.Clave;
                user.Correo = usuario.Correo;
                user.Rol = usuario.Rol;
                user.Fechacreacion = usuario.Fechacreacion;
                user.Estado = usuario.Estado;

                connect.Usuario.Add(user);
            }

            //Hacemos uso de try-catch (sentencia para el manejo de errores)
            try
            {
                //se encarga de encapsular todas las operaciones.
                valor = connect.SaveChanges();
            }
            catch
            {
                //captura los errores generados en el bloque Try, aquí se manejan las diferentes excepciones.
                throw new ArgumentException();
                throw new InvalidOperationException();
                throw new System.Data.Entity.Infrastructure.DbUpdateException();
            }
            return valor;
        }

        public Usuario Buscar(string filtro)
        {
            //Instanciamos nuestro contexto de BD
            Sistema_VentaEntities ctx = new Sistema_VentaEntities();

            try
            {
                //Encapsulamos las operación a realizar
                Usuario usuario = ctx.Usuario.First(e => e.Codigo == filtro);
                return usuario;
            }
            catch
            {
                return null;
            }
        }

        public List<Usuario> Buscar()
        {
            Sistema_VentaEntities ctx = new Sistema_VentaEntities();

            var listUser = ctx.Usuario.Select(e => new
            {
                Codigo = e.Codigo,
                Nombres = e.NombreCompleto,
                Clave = e.Clave,
                Correo = e.Correo,
                Rol = e.Rol,
                FechaCreacion = e.Fechacreacion,
                Estado = e.Estado

            }).ToList().Select(e => new Usuario()
            {
                Codigo = e.Codigo,
                NombreCompleto = e.Nombres,
                Clave = e.Clave,
                Correo = e.Correo,
                Rol = e.Rol,
                Fechacreacion = e.FechaCreacion,
                Estado = e.Estado
            });

            return listUser.ToList();
        }
    }
}
