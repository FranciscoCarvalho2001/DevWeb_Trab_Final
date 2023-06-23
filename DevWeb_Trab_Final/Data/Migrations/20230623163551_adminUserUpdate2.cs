using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class adminUserUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6bacc6-89d6-4d90-9063-109487416871", new DateTime(2023, 6, 23, 17, 35, 51, 159, DateTimeKind.Local).AddTicks(3677), "AQAAAAIAAYagAAAAEBpVt/UYF0hkQcQrNUL4MVhaMi+VhMBsXe9iMLwjXSTLu9E6j1nGAZ5GLD8xQ5CaYQ==", "414e626c-6716-4e3a-85c8-9dbfd31a710a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47aa0a9-0401-4f2c-aa22-eb2cc326d985", new DateTime(2023, 6, 23, 17, 30, 31, 382, DateTimeKind.Local).AddTicks(9454), "asdfghjkl", "a37e16b3-d9bf-49bd-a953-ed0ff7749825" });
        }
    }
}
