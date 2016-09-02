
using System;
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;
using ProjetoASIp1.Domain.Interfaces.Service;
using ProjetoASIp1Aplication.Interfaces;

namespace ProjetoASIp1Aplication.Services
{
    public class AppFornecedorService : IAppFornecedorService
    {
        private IFornecedorService service;

        public AppFornecedorService(IFornecedorService service)
        {
            this.service = service;
        }

        public void Adiciona(Fornecedor fornecedor)
        {
            service.Adiciona(fornecedor);
        }

        public void AtualizaFornecedor(Fornecedor fornecedor) //Não implementado
        {
            throw new NotImplementedException();
        }

        public void EnviaEmailConfirmacaoDeParceria() //Não implementado.
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ObtemTodos()
        {
            return service.ObtemTodos();
        }

        public Fornecedor Obterfornecedor(int cnpj)
        {
            return service.Obterfornecedor(cnpj);
        }

        public void RemoveFornecedor(int cnpj) //Não implementado.
        {
            throw new NotImplementedException();
        }
    }
}
