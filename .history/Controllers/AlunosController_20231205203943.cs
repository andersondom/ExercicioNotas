using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppDB.Models;

namespace AppDB.Controllers;

public class AlunosController : Controller
{
    private readonly ILogger<AlunosController> _logger;

    public AlunosController(ILogger<AlunosController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult InserirAluno()
    {
        return View();
    }

    public IActionResult AlterarAluno()
    {
        return View();
    }

    public IActionResult ListarAlunos()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}