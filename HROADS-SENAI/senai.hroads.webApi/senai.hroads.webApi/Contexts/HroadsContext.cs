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

        // Vinicius

        public DbSet<Classe> Classe { get; set; }

        public DbSet<ClasseHabilidade> ClasseHabilidade { get; set; }

        public DbSet<Personagem> Personagem { get; set; }

        public DbSet<Login> Login { get; set; }


        /// <summary>
        /// método que define a construção do banco de dados;
        /// </summary>
        /// <param name="optionsBuilder">string para a construção do banco de dados.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //method that we do a override to configure the database and other options.
        {
            //connection string.
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-DHSRSVI\SQLEXPRESS; Database = SENAI_HROADS_TARDE; user ID= sa; pwd = senai@132");

            base.OnConfiguring(optionsBuilder); //It need to be in a override.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //método que define as models(entidades)
        {
            // Classe
            modelBuilder.Entity<Classe>().HasData(

                new Classe { idClasse = 1, nomeClasse = "Bárbaro" },
                new Classe { idClasse = 2, nomeClasse = "Cruzado" },
                new Classe { idClasse = 3, nomeClasse = "Caçadora de demônios" },
                new Classe { idClasse = 4, nomeClasse = "Monge" },
                new Classe { idClasse = 5, nomeClasse = "Necromante" },
                new Classe { idClasse = 6, nomeClasse = "Feiticeiro" },
                new Classe { idClasse = 7, nomeClasse = "Arcanista" }
                );



            //ClasseHabilidade
            modelBuilder.Entity<ClasseHabilidade>().HasData(

                new ClasseHabilidade
                {
                    idClasseHabilidade = 1,
                    idClasse = 1,
                    idHabilidade = 1
                },

                new ClasseHabilidade
                {
                    idClasseHabilidade = 2,
                    idClasse = 1,
                    idHabilidade = 2
                },

                new ClasseHabilidade
                {
                    idClasseHabilidade = 3,
                    idClasse = 2,
                    idHabilidade = 1
                },

                new ClasseHabilidade
                {
                    idClasseHabilidade = 4,
                    idClasse = 3,
                    idHabilidade = 1
                },

                new ClasseHabilidade
                {
                    idClasseHabilidade = 5,
                    idClasse = 4,
                    idHabilidade = 3
                },

                new ClasseHabilidade
                {
                    idClasseHabilidade = 6,
                    idClasse = 4,
                    idHabilidade = 2
                },

                new ClasseHabilidade
                {
                    idClasseHabilidade = 7,
                    idClasse = 6,
                    idHabilidade = 3
                }

              );

            modelBuilder.Entity<Personagem>().HasData(

                new Personagem
                {
                    idPersonagem = 1,
                    idClasse = 1,
                    NomePersongaem = "DeuBug",
                    capacidadeDeVidaMax = 100,
                    capacidadeDeManaMax = 80,
                    dataUtilizacao = Convert.ToDateTime("09/08/2021"),
                    dataCriacao = Convert.ToDateTime("18/01/2019")
                },

                new Personagem
                {
                    idPersonagem = 1,
                    idClasse = 4,
                    NomePersongaem = "BitBug",
                    capacidadeDeVidaMax = 70,
                    capacidadeDeManaMax = 100,
                    dataUtilizacao = Convert.ToDateTime("09/08/2021"),
                    dataCriacao = Convert.ToDateTime("17/03/2016")
                },

                new Personagem
                {
                    idPersonagem = 1,
                    idClasse = 7,
                    NomePersongaem = "Fer8",
                    capacidadeDeVidaMax = 75,
                    capacidadeDeManaMax = 60,
                    dataUtilizacao = Convert.ToDateTime("09/08/2021"),
                    dataCriacao = Convert.ToDateTime("18/03/2018")
                }


                );
        }





    }
}
