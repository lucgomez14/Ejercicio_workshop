using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWorkshop.Entities
{
    public class Envio
    {
        public string Enviar(string orig, string desti, string conte)
        {
            this.ori = orig;
            this.dest = desti;
            this.cont = conte;
            return "Paquete enviado! Destino: " + desti + ", Origen: " + orig + ", Contenido: " + conte;
        }
        private string ori;
        public string Ori
        {
            set { this.ori = value; }
            get { return this.ori; }
        }
        private string dest;
        public string Dests
        {
            set { this.dest = value; } 
            get { return this.dest; }
        }
        private string cont;
        public string Cont
        {
            set { this.cont = value; }
            get { return this.cont; }
        }
    }
}
