using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2308
{
    public class Producto
    {
        private string id;
        private const int MINIMA_CANTIDAD_DE_ITEMS_PARA_DESCUENTO = 3;
        private double porcentajeDeDescuento;
        private double precio;

        public Producto(string id, double porcentajeDeDescuento, double precio)
        {
            this.id = id;
            this.porcentajeDeDescuento = porcentajeDeDescuento;
            this.precio = precio;
        }

        public string ObtenerId()
        {
            return this.id;
        }

        public double ObtenerPrecio()
        {
            return this.precio;
        }

        public double ObtenerPorcentajeDeDescuento()
        {
            return this.porcentajeDeDescuento;
        }

        public int ObtenerMinimaCantidadParaDescuento()
        {
            return MINIMA_CANTIDAD_DE_ITEMS_PARA_DESCUENTO;
        }
    }
}
