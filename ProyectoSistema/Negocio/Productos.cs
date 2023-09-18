using ProyectoSistema.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSistema.Negocio
{
    class Productos
    {
        public Productos()
        {

        }

        //Definir una instancia de la capa de datos Producto
        private Producto objProduc; //Objeto privado de la clase producto

        //Definir contructores de la clase
        public Productos(int Idpro, string cod, string nombre, string descripcion,
                        decimal costoVenta, decimal costoCompra, bool estado, int stock,int categoriaId)
        {
            //Definir una instancia de objeto de la clase Producto
            objProduc = new Producto
            {
                Id = Idpro,
                Codigo = cod,
                Nombre = nombre,
                Descripcion = descripcion,
                PrecioCompra = costoCompra,
                PrecioVenta = costoVenta,
                Estado = estado,       //Variable booleano, si retorna true indicara que el producto se encuentra activo
                                       //caso contrario false = No activo...
                Stock = stock,
                CategoriaId = categoriaId
            };
        }

        public Productos( string cod, string nombre, string descripcion,
                             bool estado, int categoriaId)
        {
            //Definir una instancia de objeto de la clase Producto
            objProduc = new Producto
            {
                Codigo = cod,
                Nombre = nombre,
                Descripcion = descripcion,
                Estado = estado,       //Variable booleano, si retorna true indicara que el producto se encuentra activo
                                       //caso contrario false = No activo...
                CategoriaId = categoriaId
            };
        }

        public int Guardar()
        {
            //Declaramos una varaible que almacenara el valor a retornar
            int valor = 0;

            //Establecer la conexión a la base de datos...
            //Instanciamos un obj de tipo Sistema_Venta
            Sistema_VentaEntities connection = new Sistema_VentaEntities();
            //Ahora bien, intanciamos un obj de la clase Producto
            Producto producto = new Producto();

            //Luego confirmamos si el registro del producto es nuevo ó
            //bien si se trata de un modificación declarando una variable local...
            var registro = connection.Producto.FirstOrDefault(prod => prod.Codigo == objProduc.Codigo);

            //Seguimos.
            //Hacemos uso de un condicional if que nos permita actualizar
            if (registro != null)
            {
                var productUpdate = (from prod in connection.Producto
                                     where producto.Codigo == objProduc.Codigo
                                     select prod).FirstOrDefault();

                //Procesar la modificación del registro
                productUpdate.Codigo = objProduc.Codigo;
                productUpdate.Nombre = objProduc.Nombre;
                productUpdate.Descripcion = objProduc.Descripcion;
                productUpdate.PrecioCompra = objProduc.PrecioCompra;
                productUpdate.PrecioVenta = objProduc.PrecioVenta;
                productUpdate.Estado = objProduc.Estado;
                productUpdate.Stock = objProduc.Stock;
                productUpdate.CategoriaId = objProduc.CategoriaId;
            }
            else
            {
                producto.Codigo = objProduc.Codigo;
                producto.Nombre = objProduc.Nombre;
                producto.Descripcion = objProduc.Descripcion;
                producto.PrecioCompra = objProduc.PrecioCompra;
                producto.PrecioVenta = objProduc.PrecioVenta;
                producto.Estado = objProduc.Estado;
                producto.Stock = objProduc.Stock;
                connection.Producto.Add(producto);
            }

            //Mandar a almacenar dicho objeto
            try
            {
                valor = connection.SaveChanges();
                //Proceso guardado
            }
            catch
            {
                //Definimos nuestras excepciones
                throw new ArgumentException();
                throw new InvalidOperationException();
                throw new System.Data.Entity.Infrastructure.DbUpdateException();
            }
            return valor;
        }

        //Leer la informacion de la instancia producto por medio del argumento filtro
        //Filter => valor por el cual se busca la instancia de producto
        //return instancia del objeto producto si se encuentra, en caso contrario sera null...
        public Producto Leer(string filter)
        {
            //Establecer contexto de la conexion 
            Sistema_VentaEntities connection = new Sistema_VentaEntities();
            //Hacer la consulta 
            Producto product = connection.Producto.First(prod => prod.Codigo == filter);

            //retornar el producto si es encontrado.
            return product;
        }

        public List<Producto> Leer()
        {
            Sistema_VentaEntities connection = new Sistema_VentaEntities();

            //Objeto anonimos
            var listaProducto = connection.Producto.Select(pdt => new
            {
                codigo = pdt.Codigo,
                nombre = pdt.Nombre,
                descripcion = pdt.Descripcion,
                precioCompra = pdt.PrecioCompra,
                precioVenta = pdt.PrecioVenta,
                estado = pdt.Estado,
                stock = pdt.Stock
            }
            ).ToList().Select(pdts => new Producto()
            {
                Codigo = pdts.codigo,
                Nombre = pdts.nombre,
                Descripcion = pdts.descripcion,
                PrecioCompra = pdts.precioCompra,
                PrecioVenta = pdts.precioVenta,
                Estado = pdts.estado,
                Stock = pdts.stock
            }
            );
            return listaProducto.Where(pdt => pdt.Estado != false).ToList();
        }
        //Fin del metodo...
    }
}
