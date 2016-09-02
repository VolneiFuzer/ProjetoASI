
using ProjetoASIp1.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoASIp1.Domain.Interfaces.Service
{
    public interface IFornecedorService //Rervisado, diferente do "ProjetoDDD".
    {
        void Adiciona(Fornecedor fornecedor);
        Fornecedor Obterfornecedor(int cnpj);
        List<Fornecedor> ObtemTodos();
        void AtualizaFornecedor(Fornecedor fornecedor);
        void RemoveFornecedor(int cnpj);
        void EnviaEmailConfirmacaoDeParceria();
    }
}
