using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediumBooks.Users.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsersSeedingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "user",
                table: "Users",
                columns: new[] { "UserId", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Name 1", "password1" },
                    { 2, "Name 2", "password2" },
                    { 3, "Name 3", "password3" },
                    { 4, "Name 4", "password4" },
                    { 5, "Name 5", "password5" },
                    { 6, "Name 6", "password6" },
                    { 7, "Name 7", "password7" },
                    { 8, "Name 8", "password8" },
                    { 9, "Name 9", "password9" },
                    { 10, "Name 10", "password10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "user",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);
        }
    }
}
