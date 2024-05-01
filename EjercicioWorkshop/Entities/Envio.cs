using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWorkshop.Entities
{
    public class Envio
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Contenido { get; set; }

        public string Enviar(string origen, string destino, string contenido)
        {
            this.Origen = origen;
            this.Destino = destino;
            this.Contenido = contenido;
            return "Paquete enviado! Destino: " + destino + ", Origen: " + origen + ", Contenido: ";
        }

    }
}
