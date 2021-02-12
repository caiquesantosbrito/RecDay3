using Microsoft.AspNetCore.Mvc;

namespace RecDay3_InstaDev.Controllers
{
    public class CadastroController : Controller
    {   
        [Route("Cadastro")]
        public IActionResult Index()
        {
            return View();
        }
    }
}