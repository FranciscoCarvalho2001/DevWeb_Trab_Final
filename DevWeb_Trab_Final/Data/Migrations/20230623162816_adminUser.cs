using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class adminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataRegisto", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeUtilizador", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "80680e5e-3962-4570-9ff1-b42a98accb45", new DateTime(2023, 6, 23, 17, 28, 16, 398, DateTimeKind.Local).AddTicks(4368), "administrador@gmail.com", true, false, null, "Administrador", "ADMINISTRADOR@GMAIL.COM", "ADMINISTRADOR@GMAIL.COM", "asdfghjklç", null, false, "c2032af1-46f1-4cbc-8344-0aef32672167", false, "administrador@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
