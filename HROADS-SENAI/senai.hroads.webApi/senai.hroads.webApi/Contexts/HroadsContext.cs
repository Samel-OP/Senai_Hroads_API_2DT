using Microsoft.EntityFrameworkCore;
using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Contexts
{
    public class HroadsContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<TiposHabilidade> TipoHabilidade { get; set; }

        public DbSet<Habilidade> Habilidade { get; set; }

        public DbSet<Classe> Classe { get; set; }

        public DbSet<ClasseHabilidade> ClasseHabilidade { get; set; }

        public DbSet<Personagem> Personagem { get; set; }

        public DbSet<Login> Login { get; set; }
    }
}
