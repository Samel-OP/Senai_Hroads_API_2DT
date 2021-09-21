using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace senai.hroads.webApi_.Migrations
{
    public partial class HROADSTARDE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    idClasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeClasse = table.Column<string>(type: "varchar(75)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.idClasse);
                });

            migrationBuilder.CreateTable(
                name: "ClasseHabilidade",
                columns: table => new
                {
                    idClasseHabilidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idClasse = table.Column<int>(type: "int", nullable: false),
                    idHabilidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasseHabilidade", x => x.idClasseHabilidade);
                });

            migrationBuilder.CreateTable(
                name: "TiposHabilidade",
                columns: table => new
                {
                    idTipoHabilidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloTipoHabilidade = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposHabilidade", x => x.idTipoHabilidade);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    idTipoUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloTipoUsuario = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.idTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    idPersonagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idClasse = table.Column<int>(type: "int", nullable: false),
                    NomePersongaem = table.Column<string>(type: "VARCHAR(70)", nullable: false),
                    capacidadeDeVidaMax = table.Column<short>(type: "SMALLINT", nullable: false),
                    capacidadeDeManaMax = table.Column<byte>(type: "TINYINT", nullable: false),
                    dataUtilizacao = table.Column<DateTime>(type: "DATE", nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.idPersonagem);
                    table.ForeignKey(
                        name: "FK_Personagem_Classe_idClasse",
                        column: x => x.idClasse,
                        principalTable: "Classe",
                        principalColumn: "idClasse",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    idHabilidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTipoHabilidade = table.Column<int>(type: "int", nullable: false),
                    nomeHabilidade = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.idHabilidade);
                    table.ForeignKey(
                        name: "FK_Habilidade_TiposHabilidade_idTipoHabilidade",
                        column: x => x.idTipoHabilidade,
                        principalTable: "TiposHabilidade",
                        principalColumn: "idTipoHabilidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTpoUsuario = table.Column<int>(type: "int", nullable: false),
                    varchar100 = table.Column<string>(name: "varchar(100)", type: "nvarchar(max)", nullable: false),
                    varchar256 = table.Column<string>(name: "varchar(256)", type: "nvarchar(max)", nullable: false),
                    varchar12 = table.Column<string>(name: "varchar(12)", type: "nvarchar(12)", maxLength: 12, nullable: false),
                    idTipoUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_TiposUsuario_idTipoUsuario",
                        column: x => x.idTipoUsuario,
                        principalTable: "TiposUsuario",
                        principalColumn: "idTipoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classe",
                columns: new[] { "idClasse", "nomeClasse" },
                values: new object[,]
                {
                    { 1, "Bárbaro" },
                    { 2, "Cruzado" },
                    { 3, "Caçadora de demônios" },
                    { 4, "Monge" },
                    { 5, "Necromante" },
                    { 6, "Feiticeiro" },
                    { 7, "Arcanista" }
                });

            migrationBuilder.InsertData(
                table: "ClasseHabilidade",
                columns: new[] { "idClasseHabilidade", "idClasse", "idHabilidade" },
                values: new object[,]
                {
                    { 7, 6, 3 },
                    { 6, 4, 2 },
                    { 4, 3, 1 },
                    { 5, 4, 3 },
                    { 2, 1, 2 },
                    { 1, 1, 1 },
                    { 3, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "TiposHabilidade",
                columns: new[] { "idTipoHabilidade", "tituloTipoHabilidade" },
                values: new object[,]
                {
                    { 1, "Ataque" },
                    { 2, "Defesa" },
                    { 3, "Cura" },
                    { 4, "Magia" }
                });

            migrationBuilder.InsertData(
                table: "TiposUsuario",
                columns: new[] { "idTipoUsuario", "tituloTipoUsuario" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Jogador" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "idUsuario", "varchar(256)", "idTipoUsuario", "idTpoUsuario", "varchar(100)", "varchar(12)" },
                values: new object[,]
                {
                    { 2, "robson@gmail.com", null, 2, "Robson", "robson123" },
                    { 1, "adm@gmail.com", null, 1, "Administrador", "adm123" },
                    { 3, "clebinho@gmail.com", null, 2, "Clebinho", "clebinho123" }
                });

            migrationBuilder.InsertData(
                table: "Habilidade",
                columns: new[] { "idHabilidade", "idTipoHabilidade", "nomeHabilidade" },
                values: new object[,]
                {
                    { 1, 1, "Lança Mortal" },
                    { 2, 2, "Escudo Supremo" },
                    { 3, 3, "Recuperar Vida" }
                });

            migrationBuilder.InsertData(
                table: "Personagem",
                columns: new[] { "idPersonagem", "NomePersongaem", "capacidadeDeManaMax", "capacidadeDeVidaMax", "dataCriacao", "dataUtilizacao", "idClasse" },
                values: new object[,]
                {
                    { 1, "DeuBug", (byte)80, (short)100, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "BitBug", (byte)100, (short)70, new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 3, "Fer8", (byte)60, (short)75, new DateTime(2018, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidade_idTipoHabilidade",
                table: "Habilidade",
                column: "idTipoHabilidade");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_idClasse",
                table: "Personagem",
                column: "idClasse");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_idTipoUsuario",
                table: "Usuario",
                column: "idTipoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClasseHabilidade");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Personagem");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "TiposHabilidade");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
