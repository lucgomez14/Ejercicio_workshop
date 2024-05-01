// See https://aka.ms/new-console-template for more information
using EjercicioWorkshop.Entities;
bool salir = false;

while (!salir)
{
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("1. Enviar paquete");
    Console.WriteLine("2. Salir");
    Console.Write("ingrese la opción opción:");
    string opc = Console.ReadLine();
    switch (opc)
    {
        case "1":
            Console.Write("Ingrese el origen del paquete:");
            string ori = Console.ReadLine();
            Console.Write("Ingrese el destino del paquete:");
            string dest = Console.ReadLine();
            Console.Write("Ingrese el contenido del paquete:");
            string cont = Console.ReadLine();
            Envio env = new Envio();
            string resul = env.Enviar(ori, dest, cont);
            Console.Write("Ingrese el tipo de notificación (Email o SMS):");
            string tnoti = Console.ReadLine();
            Console.Write("Ingrese el mail o número: ");
            string v = Console.ReadLine();
            Console.Write("Ingrese el mensaje:");
            string mensajito = Console.ReadLine();
            Notificador notifica = new Notificador();
            string resul2 = notifica.EnviarNotificacion(mensajito, tnoti, v);
            Console.WriteLine(resul2);
            Console.WriteLine(resul);
            break;
        case "2":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
            break;
    }
}