using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIF = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telemovel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telemovel = table.Column<int>(type: "int", nullable: false),
                    Especializacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuncionariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Funcionarios_FuncionariosId",
                        column: x => x.FuncionariosId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dispositivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataReg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dispositivos_Clientes_ClienteFK",
                        column: x => x.ClienteFK,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reparacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Custo = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispositivoFK = table.Column<int>(type: "int", nullable: false),
                    FuncionariosFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reparacao_Dispositivos_DispositivoFK",
                        column: x => x.DispositivoFK,
                        principalTable: "Dispositivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reparacao_Funcionarios_FuncionariosFK",
                        column: x => x.FuncionariosFK,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_ClienteFK",
                table: "Dispositivos",
                column: "ClienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_FuncionariosId",
                table: "Funcionarios",
                column: "FuncionariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reparacao_DispositivoFK",
                table: "Reparacao",
                column: "DispositivoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Reparacao_FuncionariosFK",
                table: "Reparacao",
                column: "FuncionariosFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reparacao");

            migrationBuilder.DropTable(
                name: "Dispositivos");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
