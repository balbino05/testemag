using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public class Nota
    {
        public int NotaId { get; set; }

        [Required]
        public int AlunoId { get; set; }

        [Required]
        public int DisciplinaId { get; set; }

        [Range(0, 10)]
        public decimal Valor { get; set; }

        public Aluno Aluno { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
