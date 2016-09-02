
using ProjetoASIp1.Domain.Entities;

namespace ProjetoASIp1.Domain.Interfaces
{
    public interface IPratoService //Rervisado, diferente do "ProjetoDDD".
    {
        double VerificarEAplicarPromocao(Prato prato);
        double PratoComSucoGratis(Prato prato);
    }
}
