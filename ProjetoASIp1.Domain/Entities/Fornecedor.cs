
using System.ComponentModel.DataAnnotations;

namespace ProjetoASIp1.Domain.Entities
{
    public class Fornecedor // OK, revisado
	{
        [Key]
        public int cnpj { get; set; }
		public string Nome { get; set; }
		public double Preco { get; set; }
		public string tipoDeServico { get; set; }

	}
}
