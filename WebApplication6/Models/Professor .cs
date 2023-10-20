using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }

        [Required]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public decimal Salario { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}

