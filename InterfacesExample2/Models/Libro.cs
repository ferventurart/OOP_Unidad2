using System;
namespace InterfacesExample2.Models;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public decimal Precio { get; set; }

    public Libro(string titulo, string autor, decimal precio)
    {
        Titulo = titulo;
        Autor = autor;
        Precio = precio;
    }
}

