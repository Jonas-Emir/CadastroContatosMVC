using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NovoCadastro()
        {
            return View("IndexCadastro");
        }
    }
}
