using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDB.Models
{
    [Table("Alunos")]
    public class Teste
    {
        public int Index { get; set; }

        [Description("Nome do aluno")]
        [MaxLength(60)]
        [Required]
        public string Nome { get; set; }
    }
}