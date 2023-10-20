namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication6.Data;
    using WebApplication6.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication6Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication6Context context)
        {
            // Inserir dados de teste para a entidade Curso
            context.Cursos.AddOrUpdate(
                new Curso { Nome = "Engenharia de Software", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddYears(4) },
                new Curso { Nome = "Ciência da Computação", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddYears(4) }
            );
        }
    }
