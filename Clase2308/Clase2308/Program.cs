using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2308
{
    class Program
    {
        static void Main(string[] args)
        {

            Producto manzana = new Producto("f2d0465a-0418-11ec-9a03-0242ac130003", 0.05, 10);
            Producto manzana2 = new Producto("f2d0465a-0418-11ec-9a03-0242ac130003", 0.05, 10);
            Producto manzana3 = new Producto("f2d0465a-0418-11ec-9a03-0242ac130003", 0.05, 10);
            Producto manzana4 = new Producto("f2d0465a-0418-11ec-9a03-0242ac130003", 0.05, 10);

            Carrito carrito = new Carrito();
            carrito.AgregarProducto(manzana);
            carrito.AgregarProducto(manzana2);
            carrito.AgregarProducto(manzana3);
            carrito.AgregarProducto(manzana4);

            Factura factura = carrito.Checkout();

            Console.WriteLine(factura.EmitirFactura());

            Console.ReadLine();
        }
    }
}
