using System;
using InterfacesExample01.Interfaces;

namespace InterfacesExample01;

public class Despedida : IMensaje
{
    public void MostrarMensaje()
    {
        Console.WriteLine("Hasta Luego!, Que tengas un buen dia!");
    }
}

