using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Matricula { get; set; }

        public ICollection<Nota> Notas { get; set; }
    }
}