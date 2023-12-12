using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDB.Models
{
    public class Alunos
    {
        [MaxLength(10)]
        public string Nome { get; set; }
        public string Turma { get; set; }
        [DataType(DataType.Currency)]
        public decimal Nota1 { get; set; }
        [DataType(DataType.Currency)]
        public decimal Nota2 { get; set; }
        [DataType(DataType.Currency)]
        public decimal Nota3 { get; set; }
        public int Faltas { get; set; }
    }
}