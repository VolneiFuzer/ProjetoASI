
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;

namespace ProjetoASIp1.Domain.Interfaces.Repository
{
    public interface IClienteRepository
	{
		void Adiciona(Cliente cliente);
		Cliente ObterCliente(int id);
		List<Cliente> ObtemTodos();
		void AtualizaCliente(Cliente cliente);
		void RemoveCliente(int id);
        void DefinirClienteVip();
    }
}
