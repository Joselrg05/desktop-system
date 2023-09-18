using ProyectoSistema.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSistema.Negocio
{
    class Proveedores
    {
        private Proveedor proveedor;

        public Proveedores() { }

        public Proveedores(int id, string codigo, string razon, string correo, string telefono, DateTime fecha)
        {

            //Instanciamos un objeto de la clase de proveedor
            // y los igualamos a los argumentos del constructor...
            proveedor = new Proveedor();
            proveedor.Id = id;
            proveedor.Codigo = codigo;
            proveedor.RazónSocial = razon;
            proveedor.Correo = correo;
            proveedor.Telefono = telefono;
            proveedor.Fechacreacion = fecha;
            proveedor.Estado = true;
        }

        public int Guardar()
        {
            int valor = 0;
            //Mandamos a llamar a nuestro contexto de BD, que gracias a Entity framework nos facilita...
            Sistema_VentaEntities connect = new Sistema_VentaEntities();
            Proveedor objProveedor = new Proveedor();

            //Registro => variable de tipo var, que nos ayudara a comparar dichos datos del proveedor...
            var registro = connect.Proveedor.FirstOrDefault(a => a.Codigo == proveedor.Codigo);

            //Inicializamos una condición con nuestro registro del proveedor...
            if (registro != null)
            {
                //listProv => variable de rango que nos facilita la consulta a nuestro contexto de BD
                var update = (from listProv in connect.Proveedor where listProv.Codigo == this.proveedor.Codigo select listProv).FirstOrDefault();

                update.Id = proveedor.Id;
                update.Codigo = proveedor.Codigo;
                update.RazónSocial = proveedor.RazónSocial;
                update.Correo = proveedor.Correo;
                update.Telefono = proveedor.Telefono;
                update.Fechacreacion = proveedor.Fechacreacion;
                update.Estado = proveedor.Estado;
            }
            else
            {
                //Si no se cumple lo prmero, se viene lo sieguiente...
                objProveedor.Id = proveedor.Id;
                objProveedor.Codigo = proveedor.Codigo;
                objProveedor.RazónSocial = proveedor.RazónSocial;
                objProveedor.Telefono = proveedor.Telefono;
                objProveedor.Correo = proveedor.Correo;
                objProveedor.Fechacreacion = proveedor.Fechacreacion;
                objProveedor.Estado = proveedor.Estado;

                connect.Proveedor.Add(objProveedor);
            }

            //Controlamos las excepciones haciendo uso de TRY-CATCH...
            try
            {
                //valor => variable de tipo entero que se declaro anteriormente al inicio del constructor...
                valor = connect.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
                throw new InvalidOperationException();
                throw new System.Data.Entity.Infrastructure.DbUpdateException();
            }
            return valor;
        }

        public Proveedor Leer(string filtro)
        {
            //Instanciamos un obj de nuestro contexto de nuestra BD
            Sistema_VentaEntities connect = new Sistema_VentaEntities();

            try
            {
                //Instanciamos un obj de la clase Proveedor...
                //Encapsulamos la operación que se tiene que realizar
                Proveedor proveedor = connect.Proveedor.First(a => a.Codigo == filtro);
                return proveedor;
            }
            catch
            {
                //Si no cumple los requisitos simplemente retorna null...
                return null;
            }
        }

        public List<Proveedor> Leer()
        {
            Sistema_VentaEntities connect = new Sistema_VentaEntities();

            var listProv = connect.Proveedor.Select(a => new
            {
                Id = a.Id,
                Codigo = a.Codigo,
                Razon = a.RazónSocial,
                Numero = a.Telefono,
                Email = a.Correo,
                Fecha = a.Fechacreacion,
                Estado = a.Estado

            }).ToList().Select(e => new Proveedor()
            {
                Id = e.Id,
                Codigo = e.Codigo,
                RazónSocial = e.Razon,
                Correo = e.Email,
                Telefono = e.Numero,
                Fechacreacion = e.Fecha,
                Estado = e.Estado
            });
            return listProv.ToList();
        }
    }
}
