using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class TesteInserir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b86a9e-f5d0-4c5e-a966-c8609cdfadb3", new DateTime(2023, 7, 9, 18, 55, 44, 623, DateTimeKind.Local).AddTicks(4508), "AQAAAAIAAYagAAAAEBDQWJIUdw/dvuE7QOyL45M435cUzVcu7lDvQ3XRA8UvS/DSZUlij97MOltB8Z+NUQ==", "1d21f162-6ba3-481a-8454-b63076d5791d" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CodPostal", "Email", "Morada", "NIF", "Nome", "Telemovel", "UserId" },
                values: new object[,]
                {
                    { 1, "2500-654 PORTIMÃO", "alberto@hotmail.com", "Bairo Rui Lopes", 249249249, "Alberto Santos", "969777666", "" },
                    { 2, "2678-283 LISBOA", "maria.joao@hotmail.com", "Canto da Cerejeiras", 256249999, "Maria João", "933751916", "" },
                    { 3, "1672-123 AVEIRO", "catarina@hotmail.com", "Rua Salvador Sobral", 189234831, "Catarina Moedas", "919744531", "" },
                    { 4, "3111-879 CASAIS", "gustavo_pal@hotmail.com", "Placeta dos Santos Simões", 222738901, "Gustavo Palhinha", "923321348", "" }
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "CodPostal", "Email", "Especializacao", "Morada", "Nome", "Telemovel", "UserId" },
                values: new object[,]
                {
                    { 1, "2300-450 TRAMAGAL", "daniel@gmail.com", "Computadores", "Rua da Pedrada", "Daniel Filipe", "912123123", "" },
                    { 2, "2305-670 ALBUFEIRA", "rodrigo@gmail.com", "Computadores", "Rua do Pinheiro", "Rodrigo Antunes", "915789789", "" },
                    { 3, "2200-301 BRAGA", "leia.marques@gmail.com", "Telemóveis", "Avenida 31 de Outubro", "Leia Marques", "962231123", "" },
                    { 4, "2731-659 BEJA", "carlos@gmail.com", "Eletrodomésticos", "Praça da Nogueira", "Carlos Tomaz", "932553923", "" },
                    { 5, "3030-155 SAGRES", "tiago_varandas@gmail.com", "Tablets", "Praia de Lagos", "Tiago Roberto Varandas", "922456123", "" }
                });

            migrationBuilder.InsertData(
                table: "Dispositivos",
                columns: new[] { "Id", "ClienteFK", "DataReg", "Estado", "Modelo", "Tipo" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8516), "Ecrã Partido", "Asus", "PC-Alberto" },
                    { 2, 2, new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8594), "Não liga", "Samsung", "MicroOndas-Maria" },
                    { 3, 2, new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8600), "Não faz chamadas", "Xiaomi", "Telemovel-Maria" },
                    { 4, 3, new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8631), "Tem virus", "Apple", "Tablet-Catarina" },
                    { 5, 4, new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8659), "Não deixa mudar as horas", "Sony", "Relogio-Gustavo" },
                    { 6, 4, new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8673), "Bateria quase a rebentar", "HP", "Portatil-Gustavo" }
                });

            migrationBuilder.InsertData(
                table: "Fotografias",
                columns: new[] { "Id", "DispositivoFK", "NomeFoto" },
                values: new object[,]
                {
                    { 1, 1, "noDispositivo.png" },
                    { 2, 2, "noDispositivo.png" },
                    { 3, 3, "noDispositivo.png" },
                    { 4, 4, "noDispositivo.png" },
                    { 5, 5, "noDispositivo.png" },
                    { 6, 6, "noDispositivo.png" }
                });

            migrationBuilder.InsertData(
                table: "Reparacao",
                columns: new[] { "Id", "Custo", "DataFim", "DataInicio", "DispositivoFK", "FuncionariosFK", "Observacao" },
                values: new object[,]
                {
                    { 1, 80.35m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8782), 1, 1, "É preciso comprar um ecrã novo" },
                    { 2, 50.43m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8801), 2, 2, "É preciso trocar a fonte de alimentação" },
                    { 3, 7.52m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8807), 2, 3, "É tambem preciso arranjar o cabo de alimentação" },
                    { 4, 10.67m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8818), 3, 4, "É preciso mudar a antena" },
                    { 5, 20.20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8824), 4, 4, "Tentar meter um antivírus" },
                    { 6, 40.00m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8830), 4, 5, "É preciso formatar o tablet" },
                    { 7, 8.90m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8835), 5, 2, "É preciso mudar os botões" },
                    { 8, 50.77m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8840), 6, 3, "É preciso encomendar uma bateria nova" },
                    { 9, 10.00m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8882), 1, 5, "Parte de dentro tem ferrugem" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e2ffa0b-8580-4c97-9822-3a9e3b14cf56", new DateTime(2023, 6, 23, 17, 46, 2, 555, DateTimeKind.Local).AddTicks(3362), "AQAAAAIAAYagAAAAELnwrxN2YFHREKdQ3obwoMWWmIWcg8UnrEEwnVn2y5gpRaikDg7ovYDm3E1t37pMpg==", "45deb812-6db3-41b5-a8b5-7d1c8108472b" });
        }
    }
}
