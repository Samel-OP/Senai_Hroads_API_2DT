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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-20INV7D\\SQLEXPRESS; DataBase=SENAI_HROADS_API_TARDE; user ID=sa; pwd=SenaiSamuel1;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposUsuario>().HasData(

                new TiposUsuario
                {
                    idTipoUsuario = 1,
                    tituloTipoUsuario = "Administrador"
                },
                new TiposUsuario
                {
                    idTipoUsuario = 2,
                    tituloTipoUsuario = "Jogador"
                }

               );

            modelBuilder.Entity<Usuario>().HasData(

                new Usuario
                {
                    idUsuario = 1,
                    idTpoUsuario = 1,
                    nomeUsuario = "Administrador",
                    email = "adm@gmail.com",
                    senha = "adm123"
                },

                new Usuario
                {
                    idUsuario = 2,
                    idTpoUsuario = 2,
                    nomeUsuario = "Robson",
                    email = "robson@gmail.com",
                    senha = "robson123"
                },

                new Usuario
                {
                    idUsuario = 3,
                    idTpoUsuario = 2,
                    nomeUsuario = "Clebinho",
                    email = "clebinho@gmail.com",
                    senha = "clebinho123"
                } 
                
               );

            modelBuilder.Entity<TiposHabilidade>().HasData(
                
                new TiposHabilidade
                {
                    idTipoHabilidade = 1,
                    tituloTipoHabilidade = "Ataque"
                },

                new TiposHabilidade
                {
                    idTipoHabilidade = 2,
                    tituloTipoHabilidade = "Defesa"
                },

                new TiposHabilidade
                {
                    idTipoHabilidade = 3,
                    tituloTipoHabilidade = "Cura"
                },

                new TiposHabilidade
                {
                    idTipoHabilidade = 4,
                    tituloTipoHabilidade = "Magia"
                }

               );

            modelBuilder.Entity<Habilidade>().HasData(
                
                new Habilidade
                {
                    idHabilidade = 1,
                    idTipoHabilidade = 1,
                    nomeHabilidade = "Lança Mortal",
                },

                new Habilidade
                {
                    idHabilidade = 2,
                    idTipoHabilidade = 2,
                    nomeHabilidade = "Escudo Supremo"
                },

                new Habilidade
                {
                    idHabilidade = 3,
                    idTipoHabilidade = 3,
                    nomeHabilidade = "Recuperar Vida"
                }
               );
        }
    }
}
