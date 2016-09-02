
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;

namespace ProjetoASIp1.Domain.Interfaces.Repository // Revisado, não possui no "ProjetoDDD".
{
    public interface IPratoRepository
	{
		void Adiciona(Prato prato);
		Prato ObterPrato(int id);
		List<Prato> ObtemTodos();
		void AtualizaPrato(Prato prato);
		void RemovePrato(int id);
	}
}
