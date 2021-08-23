using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2308
{
    public class Carrito
    {
        //private Producto[] productos;
        //private int indiceUltimoProducto;
        private List<Producto> productos;

        public Carrito()
        {
            //this.productos = new Producto[10];
            this.productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            //this.productos[indiceUltimoProducto] = producto;
            //this.indiceUltimoProducto++;
            this.productos.Add(producto);
        }

        public Factura Checkout()
        {
            Factura factura = new Factura();
            List<string> idsProductosProcesados = new List<string>();
            double total = 0.0;

            // List<Producto> productosUtilizatos = this.productos.Where(p => p != null).ToList();

            foreach (Producto producto in this.productos)
            {
                if (idsProductosProcesados.Contains(producto.ObtenerId())) continue;

                int cantidadDeProductos = this.productos.Count(p => p.ObtenerId() == producto.ObtenerId());
                idsProductosProcesados.Add(producto.ObtenerId());

                if (producto.ObtenerMinimaCantidadParaDescuento() <= cantidadDeProductos)
                {
                    double precioConDescuento = producto.ObtenerPrecio() * producto.ObtenerPorcentajeDeDescuento() * cantidadDeProductos;
                    total += precioConDescuento;
                    factura.AgregarLinea($"Producto ${producto.ObtenerId()} X {cantidadDeProductos} - Precio ${precioConDescuento} Descuento {producto.ObtenerPorcentajeDeDescuento()}");
                }
                else
                {
                    double precioSinDescuento = producto.ObtenerPrecio() * cantidadDeProductos;
                    total += precioSinDescuento;
                    factura.AgregarLinea($"Producto ${producto.ObtenerId()} X {cantidadDeProductos} - Precio ${precioSinDescuento}");
                }

            }

            return factura;
        }
    }
}
