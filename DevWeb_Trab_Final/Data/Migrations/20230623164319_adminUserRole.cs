using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class adminUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c29f5be-94b9-44e9-b7af-58b898c228ca", new DateTime(2023, 6, 23, 17, 43, 18, 774, DateTimeKind.Local).AddTicks(5762), "AQAAAAIAAYagAAAAENmzK17okiA/e00jJvHhJh6Mu2aQC+OEQkFiIqjE36xAKkBTbP/lYf1RRoSuTa8jLA==", "a049671a-7780-48e2-b97a-47445f004057" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6bacc6-89d6-4d90-9063-109487416871", new DateTime(2023, 6, 23, 17, 35, 51, 159, DateTimeKind.Local).AddTicks(3677), "AQAAAAIAAYagAAAAEBpVt/UYF0hkQcQrNUL4MVhaMi+VhMBsXe9iMLwjXSTLu9E6j1nGAZ5GLD8xQ5CaYQ==", "414e626c-6716-4e3a-85c8-9dbfd31a710a" });
        }
    }
}
