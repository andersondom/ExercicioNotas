using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppDB.Models;

namespace AppDB.Controllers;

public class AlunosController : Controller
{
    private readonly ILogger<AlunosController> _logger;

    private readonly AlunosDbContext _context;

    public AlunosController(ILogger<AlunosController> logger, AlunosDbContext context)
    {
        _logger = logger;
        _context = context;
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