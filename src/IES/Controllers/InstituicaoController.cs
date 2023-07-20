using Microsoft.AspNetCore.Mvc;

namespace IES.Controllers;

public class InstituicaoController : Controller
{
    // Definição de uma action chamada Index
    public IActionResult Index()
    {
        return View();
    }
}