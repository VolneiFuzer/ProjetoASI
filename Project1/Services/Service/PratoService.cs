using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoASIp1.Domain.Entities;
using ProjetoASIp1.Domain.Interfaces;

namespace ProjetoASIp1.Domain.Services.Service
{
	class PratoService : IPratoService
	{
		private IPratoService _pratoSerivice;

		public PratoService(IPratoService pratoService)
		{
			_pratoSerivice = pratoService;
		}

		public void liberaDescotoPratroPromocao(Prato prato)
		{
			// Implementação de acordo com o metodo eHpromocional para retornar o percentual de desconto
			throw new NotImplementedException();
		}
	}
}
