using Microsoft.AspNetCore.Mvc;

namespace IES.Controllers;

public class InstituicaoController : Controller
{
    // Definindo a rota para a página inicial da Instituição
    public IActionResult Index()
    {
        return View();
    }
}