using InterfacesExample01;

Saludo saludo = new();
Despedida despedida = new Despedida();

while (true)
{
    Console.WriteLine("¿Qué deseas hacer?");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Despedir");
    Console.WriteLine("3. Salir");

    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            saludo.MostrarMensaje();
            break;
        case "2":
            despedida.MostrarMensaje();
            break;
        case "3":
            Console.WriteLine("Hasta luego!");
            break;
        default:
            Console.WriteLine("Opcion Invalida. Intenta nuevamente");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar o 'S' para salir: ");
    string respuesta = Console.ReadLine().ToUpper();
    if (respuesta == "S")
    {
        Console.WriteLine("Adios!");
        return;
    }

    Console.WriteLine();
}
