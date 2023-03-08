using InterfacesExample2.Models;

Libro libro1 = new Libro("El Quijote", "Miguel de Cervantes", 25);
Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez", 20);
Libro libro3 = new Libro("La insoportable levedad del ser", "Milan Kundera", 30);

List<Libro> libros = new();
libros.Add(libro1);
libros.Add(libro2);
libros.Add(libro3);


Factura factura = new(libros);

factura.ImprimirFactura();

CreditoFiscal creditoFiscal = new(libros);

creditoFiscal.ImprimirCreditoFiscal();