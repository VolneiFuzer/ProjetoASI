
using System;
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;
using ProjetoASIp1.Domain.Interfaces.Repository;
using ProjetoASIp1.Infra.Data.Entity;
using System.Linq;

namespace ProjetoASIp1.Infra.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {

        private BacoDeDadosComunication bd = new BacoDeDadosComunication();

        public void Adiciona(Fornecedor fornecedor)
        {
            bd.Fornecedores.Add(fornecedor);
            bd.SaveChanges();
        }

        public void AtualizaFornecedor(Fornecedor fornecedor) //Não implementado.
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ObtemTodos()
        {
            return bd.Fornecedores.ToList();
        }

        public Fornecedor Obterfornecedor(int cnpj)
        {
            return bd.Fornecedores.Find(cnpj);
        }

        public void RemoveFornecedor(int cnpj) //Não implementado.
        {
            throw new NotImplementedException();
        }
    }
}
