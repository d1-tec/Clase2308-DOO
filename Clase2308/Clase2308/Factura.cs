using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2308
{
    public class Factura
    {
        private List<string> lineas;

        public Factura()
        {
            this.lineas = new List<string>();
        }

        public void AgregarLinea(string linea)
        {
            this.lineas.Add(linea);
        }

        public string EmitirFactura()
        {
            string lineasFactura = "";

            foreach (string lineaActual in this.lineas)
            {
                lineasFactura += lineaActual + "\n";
            }

            return lineasFactura;
        }
    }
}
