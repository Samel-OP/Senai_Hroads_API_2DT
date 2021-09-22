﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using senai.hroads.webApi_.Contexts;

namespace senai.hroads.webApi_.Migrations
{
    [DbContext(typeof(HroadsContext))]
    [Migration("20210921195143_senai-hroads-tarde")]
    partial class senaihroadstarde
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Classe", b =>
                {
                    b.Property<int>("idClasse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nomeClasse")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.HasKey("idClasse");

                    b.ToTable("Classe");

                    b.HasData(
                        new
                        {
                            idClasse = 1,
                            nomeClasse = "Bárbaro"
                        },
                        new
                        {
                            idClasse = 2,
                            nomeClasse = "Cruzado"
                        },
                        new
                        {
                            idClasse = 3,
                            nomeClasse = "Caçadora de demônios"
                        },
                        new
                        {
                            idClasse = 4,
                            nomeClasse = "Monge"
                        },
                        new
                        {
                            idClasse = 5,
                            nomeClasse = "Necromante"
                        },
                        new
                        {
                            idClasse = 6,
                            nomeClasse = "Feiticeiro"
                        },
                        new
                        {
                            idClasse = 7,
                            nomeClasse = "Arcanista"
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.ClasseHabilidade", b =>
                {
                    b.Property<int>("idClasseHabilidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idClasse")
                        .HasColumnType("int");

                    b.Property<int>("idHabilidade")
                        .HasColumnType("int");

                    b.HasKey("idClasseHabilidade");

                    b.HasIndex("idClasse");

                    b.HasIndex("idHabilidade");

                    b.ToTable("ClasseHabilidade");

                    b.HasData(
                        new
                        {
                            idClasseHabilidade = 1,
                            idClasse = 1,
                            idHabilidade = 1
                        },
                        new
                        {
                            idClasseHabilidade = 2,
                            idClasse = 1,
                            idHabilidade = 2
                        },
                        new
                        {
                            idClasseHabilidade = 3,
                            idClasse = 2,
                            idHabilidade = 1
                        },
                        new
                        {
                            idClasseHabilidade = 4,
                            idClasse = 3,
                            idHabilidade = 1
                        },
                        new
                        {
                            idClasseHabilidade = 5,
                            idClasse = 4,
                            idHabilidade = 3
                        },
                        new
                        {
                            idClasseHabilidade = 6,
                            idClasse = 4,
                            idHabilidade = 2
                        },
                        new
                        {
                            idClasseHabilidade = 7,
                            idClasse = 6,
                            idHabilidade = 3
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Habilidade", b =>
                {
                    b.Property<int>("idHabilidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idTipoHabilidade")
                        .HasColumnType("int");

                    b.Property<string>("nomeHabilidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("idHabilidade");

                    b.HasIndex("idTipoHabilidade");

                    b.ToTable("Habilidade");

                    b.HasData(
                        new
                        {
                            idHabilidade = 1,
                            idTipoHabilidade = 1,
                            nomeHabilidade = "Lança Mortal"
                        },
                        new
                        {
                            idHabilidade = 2,
                            idTipoHabilidade = 2,
                            nomeHabilidade = "Escudo Supremo"
                        },
                        new
                        {
                            idHabilidade = 3,
                            idTipoHabilidade = 3,
                            nomeHabilidade = "Recuperar Vida"
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Personagem", b =>
                {
                    b.Property<int>("idPersonagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomePersongaem")
                        .IsRequired()
                        .HasColumnType("VARCHAR(70)");

                    b.Property<byte>("capacidadeDeManaMax")
                        .HasColumnType("TINYINT");

                    b.Property<short>("capacidadeDeVidaMax")
                        .HasColumnType("SMALLINT");

                    b.Property<DateTime>("dataCriacao")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("dataUtilizacao")
                        .HasColumnType("DATE");

                    b.Property<int>("idClasse")
                        .HasColumnType("int");

                    b.HasKey("idPersonagem");

                    b.HasIndex("idClasse");

                    b.ToTable("Personagem");

                    b.HasData(
                        new
                        {
                            idPersonagem = 1,
                            NomePersongaem = "DeuBug",
                            capacidadeDeManaMax = (byte)80,
                            capacidadeDeVidaMax = (short)100,
                            dataCriacao = new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataUtilizacao = new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idClasse = 1
                        },
                        new
                        {
                            idPersonagem = 2,
                            NomePersongaem = "BitBug",
                            capacidadeDeManaMax = (byte)100,
                            capacidadeDeVidaMax = (short)70,
                            dataCriacao = new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataUtilizacao = new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idClasse = 4
                        },
                        new
                        {
                            idPersonagem = 3,
                            NomePersongaem = "Fer8",
                            capacidadeDeManaMax = (byte)60,
                            capacidadeDeVidaMax = (short)75,
                            dataCriacao = new DateTime(2018, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataUtilizacao = new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idClasse = 7
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.TiposHabilidade", b =>
                {
                    b.Property<int>("idTipoHabilidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tituloTipoHabilidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("idTipoHabilidade");

                    b.ToTable("TiposHabilidade");

                    b.HasData(
                        new
                        {
                            idTipoHabilidade = 1,
                            tituloTipoHabilidade = "Ataque"
                        },
                        new
                        {
                            idTipoHabilidade = 2,
                            tituloTipoHabilidade = "Defesa"
                        },
                        new
                        {
                            idTipoHabilidade = 3,
                            tituloTipoHabilidade = "Cura"
                        },
                        new
                        {
                            idTipoHabilidade = 4,
                            tituloTipoHabilidade = "Magia"
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.TiposUsuario", b =>
                {
                    b.Property<int>("idTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tituloTipoUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("idTipoUsuario");

                    b.ToTable("TiposUsuario");

                    b.HasData(
                        new
                        {
                            idTipoUsuario = 1,
                            tituloTipoUsuario = "Administrador"
                        },
                        new
                        {
                            idTipoUsuario = 2,
                            tituloTipoUsuario = "Jogador"
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("varchar(256)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("varchar(12)");

                    b.Property<int>("idTipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("nomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("varchar(100)");

                    b.HasKey("idUsuario");

                    b.HasIndex("idTipoUsuario");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            idUsuario = 1,
                            Email = "adm@gmail.com",
                            Senha = "adm123",
                            idTipoUsuario = 1,
                            nomeUsuario = "Administrador"
                        },
                        new
                        {
                            idUsuario = 2,
                            Email = "robson@gmail.com",
                            Senha = "robson123",
                            idTipoUsuario = 2,
                            nomeUsuario = "Robson"
                        },
                        new
                        {
                            idUsuario = 3,
                            Email = "clebinho@gmail.com",
                            Senha = "clebinho123",
                            idTipoUsuario = 2,
                            nomeUsuario = "Clebinho"
                        });
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.ClasseHabilidade", b =>
                {
                    b.HasOne("senai.hroads.webApi_.Domains.Classe", "classe")
                        .WithMany()
                        .HasForeignKey("idClasse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("senai.hroads.webApi_.Domains.Habilidade", "habilidade")
                        .WithMany()
                        .HasForeignKey("idHabilidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classe");

                    b.Navigation("habilidade");
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Habilidade", b =>
                {
                    b.HasOne("senai.hroads.webApi_.Domains.TiposHabilidade", "tiposHabilidade")
                        .WithMany()
                        .HasForeignKey("idTipoHabilidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tiposHabilidade");
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Personagem", b =>
                {
                    b.HasOne("senai.hroads.webApi_.Domains.Classe", "classe")
                        .WithMany()
                        .HasForeignKey("idClasse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classe");
                });

            modelBuilder.Entity("senai.hroads.webApi_.Domains.Usuario", b =>
                {
                    b.HasOne("senai.hroads.webApi_.Domains.TiposUsuario", "tipoUsuario")
                        .WithMany()
                        .HasForeignKey("idTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}