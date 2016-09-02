
using System.Collections.Generic;
using ProjetoASIp1.Domain.Entities;

namespace ProjetoASIp1.Domain.Interfaces.Repository // Revisado, não possui no "ProjetoDDD".
{
    public interface IFornecedorRepository
	{
		void Adiciona(Fornecedor fornecedor);
		Fornecedor Obterfornecedor(int cnpj);
		List<Fornecedor> ObtemTodos();
		void AtualizaFornecedor(Fornecedor fornecedor);
		void RemoveFornecedor(int cnpj);
	}
}
