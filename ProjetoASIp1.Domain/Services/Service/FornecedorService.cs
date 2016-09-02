
using ProjetoASIp1.Domain.Interfaces.Repository;
using ProjetoASIp1.Domain.Interfaces.Service;
using ProjetoASIp1.Domain.Entities;
using System.Collections.Generic;
using System;

namespace ProjetoASIp1.Domain.Services.Service
{
    public class FornecedorService : IFornecedorService
	{
        private IFornecedorRepository fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }

        public void Adiciona(Fornecedor fornecedor)
        {
            fornecedorRepository.Adiciona(fornecedor);
        }

        public void AtualizaFornecedor(Fornecedor fornecedor) //Não implementado.
        {
            throw new NotImplementedException();
        }

        public void EnviaEmailConfirmacaoDeParceria() // Não Implementado.
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ObtemTodos()
        {
            return fornecedorRepository.ObtemTodos();
        }

        public Fornecedor Obterfornecedor(int cnpj)
        {
            return fornecedorRepository.Obterfornecedor(cnpj);
        }

        public void RemoveFornecedor(int cnpj) // Não implementado.
        {
            throw new NotImplementedException();
        }
    }
}
