using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWorkshop.Entities
{
    public class Notificador
    {
        public string EnviarNotificacion(string mensaje, string tipoNotificacion, string valor)
        {
            if (tipoNotificacion.ToLower() == "email")
            {
                return "Enviado a " + valor + " por correo electrónico";
            }
            if (tipoNotificacion.ToLower() == "sms")
            {
                return "Enviado a " + valor + " por mensaje de texto";
            }
            else
            {
                throw new ArgumentException("Tipo de notificación no válido");
            }
        }
    }
}
