using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDB.Models;

public class Alunos
{
    public int Id { get; set; }

    [MaxLength(20)]
    [Description("Nome do aluno")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Nome { get; set; }

    [Description("Turma do aluno")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Turma { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public decimal Nota1 { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public decimal Nota2 { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public decimal Nota3 { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public int Faltas { get; set; }
}
