
using ProjetoASIp1.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoASIp1Aplication.Interfaces
{
    public interface IAppFornecedorService
    {
        void Adiciona(Fornecedor fornecedor);
        Fornecedor Obterfornecedor(int cnpj);
        List<Fornecedor> ObtemTodos();
        void AtualizaFornecedor(Fornecedor fornecedor);
        void RemoveFornecedor(int cnpj);
    }
}
