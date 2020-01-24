using BlazorAppProyecto.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppProyecto.DataAccess
{
	public class LibroDataAccess
	{
		public List<LibroModel> Libros { get; set; } = new List<LibroModel>();

		public LibroDataAccess()
		{
			Libros.Add(new LibroModel {
				Id = 1,
				Titulo = "Cien años de soledad",
				Precio = 20,
				Cantidad = 15
			});

			Libros.Add(new LibroModel
			{
				Id = 2,
				Titulo = "El Quijote",
				Precio = 23,
				Cantidad = 25
			});

			Libros.Add(new LibroModel
			{
				Id = 3,
				Titulo = "La Rayuela",
				Precio = 30,
				Cantidad = 10
			});

			Libros.Add(new LibroModel
			{
				Id = 4,
				Titulo = "Crimen y Castigo",
				Precio = 60,
				Cantidad = 10
			});
		}

		public List<LibroModel> ObtenerLibros()
		{
			return Libros;
		}

		public void GuardarLibro(LibroModel libro)
		{
			Libros.Add(libro);
		}
	}
}
