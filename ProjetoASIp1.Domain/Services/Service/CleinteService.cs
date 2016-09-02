
using ProjetoASIp1.Domain.Interfaces;
using ProjetoASIp1.Domain.Entities;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using ProjetoASIp1.Domain.Interfaces.Repository;

namespace ProjetoASIp1.Domain.Services.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository cleinteRepository)
        {
            this.clienteRepository = cleinteRepository;
        }
        
        public void Adiciona(Cliente cliente)
        {
            clienteRepository.Adiciona(cliente);
        }

        public void AtualizaCliente(Cliente cliente) // Não implementado
        {
            throw new NotImplementedException();
        }

        public void DefinirClienteVip()
        {
            Debug.WriteLine("Cliente vip OK!");
        }

        public void EnviarEmailPromocao() //Não implementado
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObtemTodos()
        {
            return this.clienteRepository.ObtemTodos();
        }

        public Cliente ObterCliente(int id)
        {
            return clienteRepository.ObterCliente(id);
        }

        public void RemoveCliente(int id)
        {
            throw new NotImplementedException(); //Não implementado
        }
    }
}
