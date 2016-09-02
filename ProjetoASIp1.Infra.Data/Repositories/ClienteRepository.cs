using ProjetoASIp1.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;
using ProjetoASIp1.Infra.Data.Entity;
using System.Linq;

namespace ProjetoASIp1.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private BacoDeDadosComunication bd = new BacoDeDadosComunication();
   
        public void Adiciona(Cliente cliente)
        {
            bd.Clientes.Add(cliente);
            bd.SaveChanges();
        }

        public void AtualizaCliente(Cliente cliente) //Não implementado.
        {
            throw new NotImplementedException();
        }

        public void DefinirClienteVip() //Nãi implementado
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObtemTodos()
        {
            return bd.Clientes.ToList();
        }

        public Cliente ObterCliente(int id)
        {
            return bd.Clientes.Find(id);
        }

        public void RemoveCliente(int id) // Não implementado.
        {
            throw new NotImplementedException();
        }
    }
}
