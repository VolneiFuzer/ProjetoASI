
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;

namespace ProjetoASIp1.Domain.Interfaces.Repository // Revisado, não possui no "ProjetoDDD".
{
    public interface IClubeDeFidelidadeRepository
	{
		void AdicionaClienteFidelidade(Cliente cliente);
		Cliente ObterClienteFidelidade(int id);
		List<Cliente> ObtemTodosClientesFidelidade();
		void AtualizaClienteFidelidade(Cliente cliente);
		void RemoveClienteFidelidade(int id);
	}
}
