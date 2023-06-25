using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class adminUserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47aa0a9-0401-4f2c-aa22-eb2cc326d985", new DateTime(2023, 6, 23, 17, 30, 31, 382, DateTimeKind.Local).AddTicks(9454), "asdfghjkl", "a37e16b3-d9bf-49bd-a953-ed0ff7749825" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80680e5e-3962-4570-9ff1-b42a98accb45", new DateTime(2023, 6, 23, 17, 28, 16, 398, DateTimeKind.Local).AddTicks(4368), "asdfghjklç", "c2032af1-46f1-4cbc-8344-0aef32672167" });
        }
    }
}
