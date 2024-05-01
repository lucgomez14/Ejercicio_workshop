using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWorkshop.Entities
{
    public class Notificador
    {
        public string EnviarNotificacion(string mensaje2, string unanotificacion, string manzana)
        {
            if (unanotificacion.ToLower() == "email") { return "Enviado a " + manzana + " por correo electrónico"; }
            if (unanotificacion.ToLower() == "sms") 
            { 
                return "Enviado a " + manzana + " por mensaje de texto"; 
            }
            else 
            { throw new ArgumentException("Tipo de notificación no válido"); }
        }
    }
}
