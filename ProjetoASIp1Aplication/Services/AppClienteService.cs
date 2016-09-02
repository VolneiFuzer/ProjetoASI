
using ProjetoASIp1.Domain.Entities;
using ProjetoASIp1.Domain.Interfaces;
using ProjetoASIp1Aplication.Interfaces;
using System.Collections.Generic;
using System;

namespace ProjetoASIp1Aplication.Services
{
    public class AppClienteService : IAppClienteService
    {
        private IClienteService service;

        public AppClienteService(IClienteService service)
        {
            this.service = service;
        }

        public void Adiciona(Cliente cliente)
        {
            service.Adiciona(cliente);
        }

        public void AtualizaCliente(Cliente cliente) // Não implementado
        {
            throw new System.NotImplementedException();
        }

        public void DefinirClienteVip()
        {
            service.DefinirClienteVip();
        }

        public List<Cliente> ObtemTodos()
        {
            return service.ObtemTodos();
        }

        public Cliente ObterCliente(int id)
        {
            return service.ObterCliente(id);
        }

        public void RemoveCliente(int id) // Não implementado
        {
            throw new System.NotImplementedException();
        }
    }
}
