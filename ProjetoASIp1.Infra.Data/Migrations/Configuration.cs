
using ProjetoASIp1.Domain.Entities;
using System.Data.Entity.Migrations;

namespace ProjetoASIp1.Infra.Data.Migrations
{  
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoASIp1.Infra.Data.Entity.BacoDeDadosComunication>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoASIp1.Infra.Data.Entity.BacoDeDadosComunication context)
        {

            context.Clientes.AddOrUpdate(
                p => p.Nome,
                new Cliente { Nome = "Cliente01" },
                new Cliente { Nome = "Cliente02" },
                new Cliente { Nome = "Cliente03" }
                );

            context.Fornecedores.AddOrUpdate(
                p => p.Nome,
                new Fornecedor { Nome = "Fornecedor01" },
                new Fornecedor { Nome = "Fornecedor02" },
                new Fornecedor { Nome = "Fornecedor03" }
                );       
        }
    }
}
