using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class InserirUtilizadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataRegisto", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeUtilizador", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a1", 0, "73fb5ff9-98ad-4e2c-ac03-dde010ca7960", new DateTime(2023, 1, 1, 9, 0, 0, 435, DateTimeKind.Local).AddTicks(8516), "administrador_1@gmail.com", true, false, null, "Administrador UM", "ADMINISTRADOR_1@GMAIL.COM", "ADMINISTRADOR_1@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "5338480d-7100-479b-9a43-b985d5607f27", false, "administrador_1@gmail.com" },
                    { "a2", 0, "e4ea16e5-f4b1-4624-a271-4c24f909bf5f", new DateTime(2023, 1, 1, 9, 0, 0, 435, DateTimeKind.Local).AddTicks(8516), "administrador_2@gmail.com", true, false, null, "Administrador DOIS", "ADMINISTRADOR_2@GMAIL.COM", "ADMINISTRADOR_2@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "47ad0da2-65c2-45c6-828a-0d44f259c3d9", false, "administrador_2@gmail.com" },
                    { "c1", 0, "68a1f2be-4459-4ef3-bf7b-03c2456d8ce6", new DateTime(2023, 2, 13, 14, 10, 0, 435, DateTimeKind.Local).AddTicks(8516), "alberto@hotmail.com", true, false, null, "Alberto Santos", "ALBERTO@HOTMAIL.COM", "ALBERTO@HOTMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "4910fbb9-9c0d-4283-90c4-70243b5d5628", false, "alberto@hotmail.com" },
                    { "c2", 0, "22343c87-6f9a-464d-a61d-fa17bcf580c6", new DateTime(2023, 5, 9, 17, 59, 0, 435, DateTimeKind.Local).AddTicks(8516), "maria.joao@hotmail.com", true, false, null, "Maria João", "MARIA.JOAO@HOTMAIL.COM", "MARIA.JOAO@HOTMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "7eb6a2ee-30f5-4fa9-8f27-296d9cc799cb", false, "maria.joao@hotmail.com" },
                    { "c3", 0, "3ddb906a-0146-407c-ab20-fbe62c07be24", new DateTime(2023, 6, 23, 12, 40, 0, 435, DateTimeKind.Local).AddTicks(8516), "catarina@hotmail.com", true, false, null, "Catarina Moedas", "CATARINA@HOTMAIL.COM", "CATARINA@HOTMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "71220dd4-1692-453e-9f27-b98488b79bc8", false, "catarina@hotmail.com" },
                    { "c4", 0, "45db5786-8815-412a-94f5-42cd05a7b851", new DateTime(2023, 3, 30, 9, 30, 0, 435, DateTimeKind.Local).AddTicks(8516), "gustavo_pal@hotmail.com", true, false, null, "Gustavo Palhinha", "GUSTAVO_PAL@HOTMAIL.COM", "GUSTAVO_PAL@HOTMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "c2010eea-80c6-4f6f-95aa-c1600a0566e1", false, "gustavo_pal@hotmail.com" },
                    { "f1", 0, "27f4ca81-822e-440d-b7a8-4e8e2757b981", new DateTime(2023, 1, 20, 11, 0, 0, 435, DateTimeKind.Local).AddTicks(8516), "daniel@gmail.com", true, false, null, "Daniel Filipe", "DANIEL@GMAIL.COM", "DANIEL@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "74ecf326-a044-4099-b6d6-ae52cc3d64d0", false, "daniel@gmail.com" },
                    { "f2", 0, "8fe002cf-28a9-4fc9-9b4a-72e2fdce7ecd", new DateTime(2023, 1, 15, 14, 20, 0, 435, DateTimeKind.Local).AddTicks(8516), "rodrigo@gmail.com", true, false, null, "Rodrigo Antunes", "RODRIGO@GMAIL.COM", "RODRIGO@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "00c8fdc8-eb46-4ba7-a98c-8d5ec8c33a7b", false, "rodrigo@gmail.com" },
                    { "f3", 0, "caa30bbf-6f4b-4019-9a37-67527cca2925", new DateTime(2023, 1, 29, 16, 0, 0, 435, DateTimeKind.Local).AddTicks(8516), "leia.marques@gmail.com", true, false, null, "Leia Marques", "LEIA.MARQUES@GMAIL.COM", "LEIA.MARQUES@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "6338c94e-2e09-467f-a015-e4e38c2648d5", false, "leia.marques@gmail.com" },
                    { "f4", 0, "0fb44d03-d84b-4282-8e7f-ea7e520d2aaa", new DateTime(2023, 2, 2, 12, 15, 0, 435, DateTimeKind.Local).AddTicks(8516), "carlos@gmail.com", true, false, null, "Carlos Tomaz", "CARLOS@GMAIL.COM", "CARLOS@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "963635cd-9889-4f7e-8c20-5b41b97edc12", false, "carlos@gmail.com" },
                    { "f5", 0, "0f8734c7-5fa4-42a8-8373-51e3a6945925", new DateTime(2023, 2, 18, 11, 50, 0, 435, DateTimeKind.Local).AddTicks(8516), "tiago_varandas@gmail.com", true, false, null, "Tiago Roberto Varandas", "TIAGO_VARANDAS@GMAIL.COM", "TIAGO_VARANDAS@GMAIL.COM", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, false, "d5df9c2e-e2c7-4986-91f5-c38a7cc242e4", false, "tiago_varandas@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "c1");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "c2");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "c3");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "c4");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataReg",
                value: new DateTime(2023, 2, 13, 14, 20, 48, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 20, 17, 13, 785, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "f1");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "f2");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "f3");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "f4");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "f5");

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataInicio",
                value: new DateTime(2023, 7, 9, 20, 17, 13, 785, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataInicio",
                value: new DateTime(2023, 7, 9, 20, 17, 13, 785, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataFim",
                value: new DateTime(2023, 7, 9, 20, 17, 13, 785, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a", "a1" },
                    { "a", "a2" },
                    { "c", "c1" },
                    { "c", "c2" },
                    { "c", "c3" },
                    { "c", "c4" },
                    { "f", "f1" },
                    { "f", "f2" },
                    { "f", "f3" },
                    { "f", "f4" },
                    { "f", "f5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a", "a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a", "a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c", "c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c", "c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c", "c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c", "c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f", "f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f", "f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f", "f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f", "f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f", "f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataRegisto", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeUtilizador", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "b04f78f6-e679-4a65-bb9d-32ba115a0468", new DateTime(2023, 7, 9, 19, 40, 52, 114, DateTimeKind.Local).AddTicks(6948), "administrador@gmail.com", true, false, null, "Administrador", "ADMINISTRADOR@GMAIL.COM", "ADMINISTRADOR@GMAIL.COM", "AQAAAAIAAYagAAAAEFgsQim7Bdb+j5EW7pSGvz5tehCd7KEDXoHV+5E9F7pt5hKKVlvhK++ZkOQp1fKKIg==", null, false, "a2f594f7-d738-48a3-8de1-8b9a6fd743ef", false, "administrador@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataReg",
                value: new DateTime(2023, 2, 13, 14, 10, 48, 435, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataInicio",
                value: new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataInicio",
                value: new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataFim",
                value: new DateTime(2023, 7, 9, 19, 40, 51, 978, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a", "1" });
        }
    }
}
