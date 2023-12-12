using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDB.Models
{
    public class Alunos
    {
        [MaxLength(20)]
        public string Nome { get; set; }
        public string Turma { get; set; }
        [Range(0, 999.99)]
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public int Faltas { get; set; }
    }
}