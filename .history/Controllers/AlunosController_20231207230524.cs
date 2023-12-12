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

    [HttpPost]
    public IActionResult InserirAluno(Alunos aluno)
    {
        if (ModelState.IsValid)
        {
            _context.alunos.Add(aluno);
            _context.SaveChanges();
            return RedirectToAction(nameof(ListarAlunos));
        }

        return View(aluno);
    }

    public IActionResult AlterarAluno(int id)
    {
        var alunos = _context.alunos.Find(id);

        if (alunos == null)
        {
            return RedirectToAction(nameof(ListarAlunos));
        }

        return View(alunos);
    }

    [HttpPost]
    public IActionResult AlterarAluno(Alunos aluno)
    {
        var alunoBanco = _context.alunos.Find(aluno.Id);
        alunoBanco.Nome = aluno.Nome;
        alunoBanco.Turma = aluno.Turma;
        alunoBanco.Nota1 = aluno.Nota1;
        alunoBanco.Nota2 = aluno.Nota2;
        alunoBanco.Nota3 = aluno.Nota3;
        alunoBanco.Faltas = aluno.Faltas;

        _context.alunos.Update(alunoBanco);
        _context.SaveChanges();

        return RedirectToAction(nameof(ListarAlunos));
    }

    public IActionResult ListarAlunos()
    {
        var alunos = _context.alunos.ToList();
        return View(alunos);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}