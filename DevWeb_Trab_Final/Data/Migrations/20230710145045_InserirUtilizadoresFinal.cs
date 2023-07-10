using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class InserirUtilizadoresFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "defaa072-55ae-4469-abd6-a3edc1449072", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "b78d352d-7344-4826-b37e-d7516096e553" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6599ef3-172c-41c7-abb0-98072a154fc7", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "c41c3ea7-3de1-475d-8e08-a766e813b837" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "72c4ef58-65f2-41f0-970d-b549564447ca", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "969777666", "e8314899-0afc-4289-8677-ca3798c30543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2c7e0ff0-3fa6-4fff-988c-0339c69d9412", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "933751916", "01fa1f1a-c62e-4ffb-8d79-0df481c16b96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "12fb0a08-b963-40f8-a74c-33ca8d535f36", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "919744531", "785aacae-a247-4bd6-a87d-4a605eac16c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "e9433725-7316-430d-bff8-304a6a53d519", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "923321348", "4f9187d2-36af-43b6-9d86-5412b33bf26c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4be2b8b8-5007-4b21-a0bb-14e10ce98099", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "912123123", "3f358514-896a-4544-9da5-afd44f501cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "7648c2b1-304c-4baa-8c99-8e084bc2cc0c", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "915789789", "5d3a3bb8-ee17-4b77-b060-8b8a4ecb8444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "c032d3f3-4b09-4bc6-9d31-7d2bfc3979e4", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "962231123", "b682ffc1-1b00-4170-98c6-c8c72ec55807" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "42f5964a-446d-49cd-b402-03664b4081d5", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "932553923", "569cf23b-ce85-41f9-ac1e-79a26d23cff8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "39be2b4a-685f-42e9-95e5-c8bf1e048ce7", "AQAAAAIAAYagAAAAEGDOPtP55I+lMq1ehxtZ/Rpmf9hZyZcdhNz6ZpUYOlbiXbGMZyjmx73VNO3dIUE6UQ==", "922456123", "c1d32542-5de4-4d6b-b622-c46479ad03da" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataReg",
                value: new DateTime(2023, 7, 10, 15, 50, 45, 32, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 4,
                column: "NomeFoto",
                value: "ipad.png");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 5,
                column: "NomeFoto",
                value: "relogio.png");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 7,
                column: "NomeFoto",
                value: "ventoinha.png");

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataInicio",
                value: new DateTime(2023, 7, 10, 15, 50, 45, 32, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataInicio",
                value: new DateTime(2023, 7, 10, 15, 50, 45, 33, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Reparacao",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataFim",
                value: new DateTime(2023, 7, 10, 15, 50, 45, 33, DateTimeKind.Local).AddTicks(24));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73fb5ff9-98ad-4e2c-ac03-dde010ca7960", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", "5338480d-7100-479b-9a43-b985d5607f27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ea16e5-f4b1-4624-a271-4c24f909bf5f", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", "47ad0da2-65c2-45c6-828a-0d44f259c3d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "68a1f2be-4459-4ef3-bf7b-03c2456d8ce6", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "4910fbb9-9c0d-4283-90c4-70243b5d5628" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "22343c87-6f9a-464d-a61d-fa17bcf580c6", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "7eb6a2ee-30f5-4fa9-8f27-296d9cc799cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "3ddb906a-0146-407c-ab20-fbe62c07be24", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "71220dd4-1692-453e-9f27-b98488b79bc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "45db5786-8815-412a-94f5-42cd05a7b851", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "c2010eea-80c6-4f6f-95aa-c1600a0566e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "27f4ca81-822e-440d-b7a8-4e8e2757b981", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "74ecf326-a044-4099-b6d6-ae52cc3d64d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "8fe002cf-28a9-4fc9-9b4a-72e2fdce7ecd", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "00c8fdc8-eb46-4ba7-a98c-8d5ec8c33a7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "caa30bbf-6f4b-4019-9a37-67527cca2925", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "6338c94e-2e09-467f-a015-e4e38c2648d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "0fb44d03-d84b-4282-8e7f-ea7e520d2aaa", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "963635cd-9889-4f7e-8c20-5b41b97edc12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "0f8734c7-5fa4-42a8-8373-51e3a6945925", "AQAAAAIAAYagAAAAELNkMdIrt7kMwhD7j07xYCyWPKlgaLBmuKVAPhMoirTkdtlHghML183wzI5u6NWEJQ==", null, "d5df9c2e-e2c7-4986-91f5-c38a7cc242e4" });

            migrationBuilder.UpdateData(
                table: "Dispositivos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataReg",
                value: new DateTime(2023, 7, 9, 20, 17, 13, 785, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 4,
                column: "NomeFoto",
                value: "noDispositivo.png");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 5,
                column: "NomeFoto",
                value: "noDispositivo.png");

            migrationBuilder.UpdateData(
                table: "Fotografias",
                keyColumn: "Id",
                keyValue: 7,
                column: "NomeFoto",
                value: "noDispositivo.png");

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
        }
    }
}
