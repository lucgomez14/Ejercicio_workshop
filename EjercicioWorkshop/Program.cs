// See https://aka.ms/new-console-template for more information
using EjercicioWorkshop.Entities;
bool salir = false;

while (!salir)
{
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("1. Enviar paquete");
    Console.WriteLine("2. Salir");
    Console.Write("ingrese la opción opción:");

    string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                EnviarPaquete();
                break;
            case "2":
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                break;
        }
}


static void EnviarNotificacion()
{
    Console.Write("Ingrese el tipo de notificación (Email o SMS):");
    string tipoNotificacion = Console.ReadLine();

    Console.Write("Ingrese el número o el mail: ");
    string valor = Console.ReadLine();

    Console.Write("Ingrese el mensaje:");
    string mensaje = Console.ReadLine();



    Notificador notificador = new Notificador();
    try
    {
        string resultado = notificador.EnviarNotificacion(mensaje, tipoNotificacion, valor);
        Console.WriteLine(resultado);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void EnviarPaquete()
{
    Console.Write("Ingrese el origen del paquete:");
    string origen = Console.ReadLine();

    Console.Write("Ingrese el destino del paquete:");
    string destino = Console.ReadLine();

    Console.Write("Ingrese el contenido del paquete:");
    string contenido = Console.ReadLine();

    Envio envio = new Envio();
    string resultado = envio.Enviar(origen, destino, contenido);
    EnviarNotificacion();
    Console.WriteLine(resultado);
}