using InterfacesExample2.Interfaces;

namespace InterfacesExample2.Models;

public class Factura : IFacturable
{
	private List<Libro> _libros;

	public Factura(List<Libro> libros)
	{
		_libros = libros;
	}

    public decimal CalcularPrecioTotal()
    {
		decimal total = 0;

        foreach (Libro libro in _libros)
        {
            total += libro.Precio;
        }

		return total;
    }

    public void ImprimirFactura()
	{
		Console.WriteLine("Factura");
		Console.WriteLine("--------");

		foreach (Libro libro in _libros)
		{
			Console.WriteLine("{0} - {1} - {2}", libro.Titulo, libro.Autor, libro.Precio);
		}

		Console.WriteLine("Total: {0}", CalcularPrecioTotal());
	}
}

