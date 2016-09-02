
using ProjetoASIp1.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoASIp1Aplication.Interfaces
{
    public interface IAppClienteService // Diferente, avaliar.
	{
        void Adiciona(Cliente cliente);
        Cliente ObterCliente(int id);
        List<Cliente> ObtemTodos();
        void AtualizaCliente(Cliente cliente);
        void RemoveCliente(int id);
        void DefinirClienteVip();
    }
}
