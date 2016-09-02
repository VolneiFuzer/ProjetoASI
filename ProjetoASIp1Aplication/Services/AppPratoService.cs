
using ProjetoASIp1.Domain.Entities;
using ProjetoASIp1.Domain.Interfaces;

namespace ProjetoASIp1Aplication.Services // OK, Revisado
{
    public class AppPratoService : IPratoService
    {
        private IPratoService _pratoService;

        public AppPratoService(IPratoService pratoService)
        {
            _pratoService = pratoService;
        }

        public double PratoComSucoGratis(Prato prato)
        {
            return _pratoService.PratoComSucoGratis(prato);
        }

        public double VerificarEAplicarPromocao(Prato prato)
        {
            return _pratoService.VerificarEAplicarPromocao(prato);
        }
    }
}
