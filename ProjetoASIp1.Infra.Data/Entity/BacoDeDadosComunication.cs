
using System.Data.Entity;
using ProjetoASIp1.Domain.Entities;


namespace ProjetoASIp1.Infra.Data.Entity
{
    public class BacoDeDadosComunication : DbContext
    {
        public BacoDeDadosComunication() : base("ProjetoASIp1_BancoDeDados")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
