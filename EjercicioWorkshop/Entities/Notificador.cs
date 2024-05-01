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
            switch (tipoNotificacion.ToLower())
            {
                case "email":
                    return EnviarMensajePorCorreoElectronico(mensaje, valor);
                case "sms":
                    return EnviarMensajePorTelefono(mensaje, valor);
                default:
                    throw new ArgumentException("Tipo de notificación no válido");
            }
        }

        public string EnviarMensajePorCorreoElectronico(string mensaje, string email)
        {
            return "Enviado a " + email + " por correo electrónico";
        }

        public string EnviarMensajePorTelefono(string mensaje, string numeroTelefono)
        {
            return "Enviado a " + numeroTelefono + " por mensaje de texto";
        }
    }
}
