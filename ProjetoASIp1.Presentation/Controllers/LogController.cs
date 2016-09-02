
using ProjetoASIp1Aplication.Interfaces;
using System.Web.Mvc;

namespace ProjetoASIp1.Presentation.Controllers
{
    public class LogController : Controller
    {
        private IServiceLog _serviceLog;

        public LogController(IServiceLog serviceLog)
        {
            _serviceLog = serviceLog;
        }

        public ActionResult Index()
        {
            _serviceLog.RegistrarAtividade();
            return View();
        }
    }
}