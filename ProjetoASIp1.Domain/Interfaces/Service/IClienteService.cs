
using ProjetoASIp1.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoASIp1.Domain.Interfaces
{
    public interface IClienteService //OK, Revisado.
    {
        void Adiciona(Cliente cliente);
        Cliente ObterCliente(int id);
        List<Cliente> ObtemTodos();
        void AtualizaCliente(Cliente cliente);
        void RemoveCliente(int id);
        void DefinirClienteVip();
        void EnviarEmailPromocao();
    }
}
