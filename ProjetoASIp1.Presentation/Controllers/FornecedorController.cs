
using ProjetoASIp1Aplication.Interfaces;
using System.Web.Mvc;

namespace ProjetoASIp1.Presentation.Controllers
{
    public class FornecedorController : Controller
    {
        // GET: Fornecedor
        private IAppFornecedorService appFornecedorService;

        public FornecedorController(IAppFornecedorService iAppFornecedor)
        {
            appFornecedorService = iAppFornecedor;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObtemTodos()
        {
            return View(appFornecedorService.ObtemTodos());
        }

        public ActionResult ObtemFornecedor(int cnpj)
        {
            return View(appFornecedorService.Obterfornecedor(cnpj));
        }

    }
}