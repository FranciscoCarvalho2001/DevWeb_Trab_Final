using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class TesteInserirTabelasFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b04f78f6-e679-4a65-bb9d-32ba115a0468", new DateTime(2023, 7, 9, 19, 40, 52, 114, DateTimeKind.Local).AddTicks(6948), "AQAAAAIAAYagAAAAEFgsQim7Bdb+j5EW7pSGvz5tehCd7KEDXoHV+5E9F7pt5hKKVlvhK++ZkOQp1fKKIg==", "a2f594f7-d738-48a3-8de1-8b9a6fd743ef" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataReg",
                value: new DateTime(2023, 2, 13, 14, 10, 48, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataReg",
                value: new DateTime(2023, 5, 9, 18, 10, 14, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataReg",
                value: new DateTime(2023, 6, 23, 12, 50, 22, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataReg",
                value: new DateTime(2023, 3, 30, 9, 35, 34, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 14, 55, 44, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.InsertData(
                table: "Dispositivos",
                columns: new[] { "Id", "ClienteFK", "DataReg", "Estado", "Modelo", "Tipo" },
                values: new object[] { 7, 1, new DateTime(2023, 4, 4, 10, 20, 33, 435, DateTimeKind.Local).AddTicks(8516), "Não vira", "Wahson", "Ventoinha-Alberto" });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { null, new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { null, new DateTime(2023, 5, 9, 18, 15, 44, 435, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio", "FuncionariosFK" },
                values: new object[] { null, new DateTime(2023, 5, 10, 19, 55, 59, 435, DateTimeKind.Local).AddTicks(8516), 4 });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { null, new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio", "FuncionariosFK" },
                values: new object[] { null, new DateTime(2023, 6, 24, 11, 28, 23, 435, DateTimeKind.Local).AddTicks(8516), 3 });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { null, new DateTime(2023, 6, 25, 18, 48, 24, 435, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataFim", "DataInicio", "FuncionariosFK" },
                values: new object[] { null, new DateTime(2023, 7, 11, 16, 30, 33, 435, DateTimeKind.Local).AddTicks(8516), 4 });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { null, new DateTime(2023, 7, 9, 15, 0, 12, 435, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataFim", "DataInicio", "Observacao" },
                values: new object[] { new DateTime(2023, 2, 17, 14, 30, 11, 435, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 2, 15, 13, 45, 51, 435, DateTimeKind.Local).AddTicks(8516), "Arranjado" });

            migrationBuilder.InsertData(
                table: "Reparacao",
                columns: new[] { "Id", "Custo", "DataFim", "DataInicio", "DispositivoFK", "FuncionariosFK", "Observacao" },
                values: new object[,]
                {
                    { 10, 20.30m, new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 7, 12, 14, 25, 20, 435, DateTimeKind.Local).AddTicks(8516), 3, 5, "Arranjado" },
                    { 11, 60.78m, new DateTime(2023, 4, 1, 11, 33, 17, 435, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 3, 30, 9, 50, 50, 435, DateTimeKind.Local).AddTicks(8516), 5, 2, "Arranjado" }
                });

            migrationBuilder.InsertData(
                table: "Fotografias",
                columns: new[] { "Id", "DispositivoFK", "NomeFoto" },
                values: new object[] { 7, 7, "noDispositivo.png" });

            migrationBuilder.InsertData(
                table: "Reparacao",
                columns: new[] { "Id", "Custo", "DataFim", "DataInicio", "DispositivoFK", "FuncionariosFK", "Observacao" },
                values: new object[] { 12, 60.78m, new DateTime(2023, 4, 5, 17, 50, 25, 435, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 4, 4, 10, 30, 34, 435, DateTimeKind.Local).AddTicks(8516), 7, 4, "Arranjado" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b86a9e-f5d0-4c5e-a966-c8609cdfadb3", new DateTime(2023, 7, 9, 18, 55, 44, 623, DateTimeKind.Local).AddTicks(4508), "AQAAAAIAAYagAAAAEBDQWJIUdw/dvuE7QOyL45M435cUzVcu7lDvQ3XRA8UvS/DSZUlij97MOltB8Z+NUQ==", "1d21f162-6ba3-481a-8454-b63076d5791d" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio", "FuncionariosFK" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8807), 3 });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio", "FuncionariosFK" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8824), 4 });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataFim", "DataInicio", "FuncionariosFK" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8835), 2 });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataFim", "DataInicio", "Observacao" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 18, 55, 44, 435, DateTimeKind.Local).AddTicks(8882), "Parte de dentro tem ferrugem" });
        }
    }
}
