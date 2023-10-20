using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }

        [Required]
        public string Nome { get; set; }

        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
