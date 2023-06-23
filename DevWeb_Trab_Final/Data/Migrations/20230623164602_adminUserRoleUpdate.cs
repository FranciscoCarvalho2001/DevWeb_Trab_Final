using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevWeb_Trab_Final.Migrations
{
    /// <inheritdoc />
    public partial class adminUserRoleUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a", null, "Administrador", "ADMINISTRADOR" },
                    { "c", null, "Cliente", "CLIENTE" },
                    { "f", null, "Funcionario", "FUNCIONARIO" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e2ffa0b-8580-4c97-9822-3a9e3b14cf56", new DateTime(2023, 6, 23, 17, 46, 2, 555, DateTimeKind.Local).AddTicks(3362), "AQAAAAIAAYagAAAAELnwrxN2YFHREKdQ3obwoMWWmIWcg8UnrEEwnVn2y5gpRaikDg7ovYDm3E1t37pMpg==", "45deb812-6db3-41b5-a8b5-7d1c8108472b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrador", "ADMINISTRADOR" },
                    { "2", null, "Funcionario", "FUNCIONARIO" },
                    { "3", null, "Cliente", "CLIENTE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DataRegisto", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c29f5be-94b9-44e9-b7af-58b898c228ca", new DateTime(2023, 6, 23, 17, 43, 18, 774, DateTimeKind.Local).AddTicks(5762), "AQAAAAIAAYagAAAAENmzK17okiA/e00jJvHhJh6Mu2aQC+OEQkFiIqjE36xAKkBTbP/lYf1RRoSuTa8jLA==", "a049671a-7780-48e2-b97a-47445f004057" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }
    }
}
