using System;
using InterfacesExample01.Interfaces;

namespace InterfacesExample01;

public class Saludo : IMensaje
{
    public void MostrarMensaje()
    {
        Console.WriteLine("Hola!, Como estas?");
    }
}

