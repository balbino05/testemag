using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class WebApplication6Context : DbContext
    {
        public WebApplication6Context (DbContextOptions<WebApplication6Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication6.Models.Aluno> Aluno { get; set; } = default!;

        public DbSet<WebApplication6.Models.Curso>? Curso { get; set; }

        public DbSet<WebApplication6.Models.Disciplina>? Disciplina { get; set; }

        public DbSet<WebApplication6.Models.Nota>? Nota { get; set; }

        public DbSet<WebApplication6.Models.Professor>? Professor { get; set; }
        public object Cursos { get; internal set; }
    }
}
