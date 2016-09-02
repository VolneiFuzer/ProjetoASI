
using System.ComponentModel.DataAnnotations;

namespace ProjetoASIp1.Domain.Entities
{
    public class Cliente //OK, revisado.
    {
        [Key]
        public int cpf { get; set; }
        public int rg { get; set; }
        public string Nome { get; set; }
        public string sobrenome { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string Email { get; set; }   
    }
}
