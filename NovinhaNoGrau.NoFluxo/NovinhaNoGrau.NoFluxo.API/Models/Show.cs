using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovinhaNoGrau.NoFluxo.API.Models
{
	public class Show : Titulo
	{
		public List<Faixa> Faixas { get; set; }
		public string Convidados { get; set; }

	}
}