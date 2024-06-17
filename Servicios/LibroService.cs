using NicolasCasamenMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicolasCasamenMVVM.Servicios
{
    public class LibroService : ILibroService
    {
        public List<Libro> ObtenerLibro()
        {
            return new List<Libro> {
            new Libro { Titulo = "Tormenta de Espadas", Autor = "George R.R Martin" },
            new Libro { Titulo = "Crimen y castigo", Autor = "Fiodor Dostoyevsky" },
            new Libro { Titulo = "Harry Potter", Autor = "J.K Rowling" }
        };
    }
    }
}
