using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppProyecto.Modelos
{
	public class LibroModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "Titulo muy largo.")]
		public string Titulo { get; set; }

		[Required]
		public decimal Precio { get; set; }

		[Required]
		public int Cantidad { get; set; }
	}
}
