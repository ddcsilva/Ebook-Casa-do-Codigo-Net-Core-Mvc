using IES.Models;
using Microsoft.AspNetCore.Mvc;

namespace IES.Controllers;

public class InstituicaoController : Controller
{
    private static IList<Instituicao> instituicoes = new List<Instituicao>()
    {
        new Instituicao()
        {
            InstituicaoID = 1,
            Nome = "UniParaná",
            Endereco = "Paraná"
        },
        new Instituicao()
        {
            InstituicaoID = 2,
            Nome = "UniSanta",
            Endereco = "Santa Catarina"
        },
        new Instituicao()
        {
            InstituicaoID = 3,
            Nome = "UniSãoPaulo",
            Endereco = "São Paulo"
        },
        new Instituicao()
        {
            InstituicaoID = 4,
            Nome = "UniSulgrandense",
            Endereco = "Rio Grande do Sul"
        },
        new Instituicao()
        {
            InstituicaoID = 5,
            Nome = "UniCarioca",
            Endereco = "Rio de Janeiro"
        }
    };

    [HttpGet]
    public IActionResult Index()
    {
        return View(instituicoes);
    }

    [HttpGet]
    public ActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] // Validação do token de segurança
    public ActionResult Criar(Instituicao instituicao)
    {
        instituicoes.Add(instituicao);
        // Atribui o novo ID - Assumindo que o valor máximo é sempre o último da lista, utilizando o LINQ
        instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
        return RedirectToAction(nameof(Index));
    }
}