using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovinhaNoGrau.NoFluxo.API.Models
{
	public class FIlme : Titulo
	{
		public string Sinopse { get; set; }
		public string Elenco { get; set; }

	}
}