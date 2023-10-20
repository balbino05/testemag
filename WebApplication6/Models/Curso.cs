using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [Required]
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}

