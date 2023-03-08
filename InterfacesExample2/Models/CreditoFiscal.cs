using System;
using InterfacesExample2.Interfaces;

namespace InterfacesExample2.Models
{
	public class CreditoFiscal : IFacturable
    {
        private List<Libro> _libros;

        public CreditoFiscal(List<Libro> libros)
        {
            _libros = libros;
        }

        public decimal CalcularPrecioTotal()
        {
            decimal total = 0;

            foreach (Libro libro in _libros)
            {
                total += (libro.Precio * 0.13m) + libro.Precio;
            }

            return total;
        }

        public void ImprimirCreditoFiscal()
        {
            Console.WriteLine("Credito Fiscal");
            Console.WriteLine("--------");

            foreach (Libro libro in _libros)
            {
                Console.WriteLine("{0} - {1} - ${2}", libro.Titulo, libro.Autor, libro.Precio);
            }

            Console.WriteLine("Total: ${0}", CalcularPrecioTotal());
        }
    }
}

