
using ProjetoASIp1Aplication.Interfaces;
using System.Web.Mvc;

namespace ProjetoASIp1.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        private IAppClienteService appClienteService;

        public ClienteController(IAppClienteService iAppCliente)
        {
            appClienteService = iAppCliente;
        }

        public ActionResult Index()
        {
            appClienteService.DefinirClienteVip();
            return View();
        }

        public ActionResult ObtemTodos()
        {
            return View(appClienteService.ObtemTodos());
        }

        public ActionResult ObtemCliente(int id)
        {
            return View(appClienteService.ObterCliente(id));
        }
    }
}