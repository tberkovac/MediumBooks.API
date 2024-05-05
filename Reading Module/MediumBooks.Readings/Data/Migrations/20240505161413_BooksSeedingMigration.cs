using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediumBooks.Readings.Data.Migrations
{
    /// <inheritdoc />
    public partial class BooksSeedingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "reading",
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "AuthorName", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Name 2", "Interesting book 1" },
                    { 2, 3, "Name 3", "Interesting book 2" },
                    { 3, 4, "Name 4", "Interesting book 3" },
                    { 4, 5, "Name 5", "Interesting book 4" },
                    { 5, 6, "Name 6", "Interesting book 5" },
                    { 6, 7, "Name 7", "Interesting book 6" },
                    { 7, 8, "Name 8", "Interesting book 7" },
                    { 8, 9, "Name 9", "Interesting book 8" },
                    { 9, 10, "Name 10", "Interesting book 9" },
                    { 10, 1, "Name 1", "Interesting book 10" },
                    { 11, 2, "Name 2", "Interesting book 11" },
                    { 12, 3, "Name 3", "Interesting book 12" },
                    { 13, 4, "Name 4", "Interesting book 13" },
                    { 14, 5, "Name 5", "Interesting book 14" },
                    { 15, 6, "Name 6", "Interesting book 15" },
                    { 16, 7, "Name 7", "Interesting book 16" },
                    { 17, 8, "Name 8", "Interesting book 17" },
                    { 18, 9, "Name 9", "Interesting book 18" },
                    { 19, 10, "Name 10", "Interesting book 19" },
                    { 20, 1, "Name 1", "Interesting book 20" },
                    { 21, 2, "Name 2", "Interesting book 21" },
                    { 22, 3, "Name 3", "Interesting book 22" },
                    { 23, 4, "Name 4", "Interesting book 23" },
                    { 24, 5, "Name 5", "Interesting book 24" },
                    { 25, 6, "Name 6", "Interesting book 25" },
                    { 26, 7, "Name 7", "Interesting book 26" },
                    { 27, 8, "Name 8", "Interesting book 27" },
                    { 28, 9, "Name 9", "Interesting book 28" },
                    { 29, 10, "Name 10", "Interesting book 29" },
                    { 30, 1, "Name 1", "Interesting book 30" },
                    { 31, 2, "Name 2", "Interesting book 31" },
                    { 32, 3, "Name 3", "Interesting book 32" },
                    { 33, 4, "Name 4", "Interesting book 33" },
                    { 34, 5, "Name 5", "Interesting book 34" },
                    { 35, 6, "Name 6", "Interesting book 35" },
                    { 36, 7, "Name 7", "Interesting book 36" },
                    { 37, 8, "Name 8", "Interesting book 37" },
                    { 38, 9, "Name 9", "Interesting book 38" },
                    { 39, 10, "Name 10", "Interesting book 39" },
                    { 40, 1, "Name 1", "Interesting book 40" },
                    { 41, 2, "Name 2", "Interesting book 41" },
                    { 42, 3, "Name 3", "Interesting book 42" },
                    { 43, 4, "Name 4", "Interesting book 43" },
                    { 44, 5, "Name 5", "Interesting book 44" },
                    { 45, 6, "Name 6", "Interesting book 45" },
                    { 46, 7, "Name 7", "Interesting book 46" },
                    { 47, 8, "Name 8", "Interesting book 47" },
                    { 48, 9, "Name 9", "Interesting book 48" },
                    { 49, 10, "Name 10", "Interesting book 49" },
                    { 50, 1, "Name 1", "Interesting book 50" },
                    { 51, 2, "Name 2", "Interesting book 51" },
                    { 52, 3, "Name 3", "Interesting book 52" },
                    { 53, 4, "Name 4", "Interesting book 53" },
                    { 54, 5, "Name 5", "Interesting book 54" },
                    { 55, 6, "Name 6", "Interesting book 55" },
                    { 56, 7, "Name 7", "Interesting book 56" },
                    { 57, 8, "Name 8", "Interesting book 57" },
                    { 58, 9, "Name 9", "Interesting book 58" },
                    { 59, 10, "Name 10", "Interesting book 59" },
                    { 60, 1, "Name 1", "Interesting book 60" },
                    { 61, 2, "Name 2", "Interesting book 61" },
                    { 62, 3, "Name 3", "Interesting book 62" },
                    { 63, 4, "Name 4", "Interesting book 63" },
                    { 64, 5, "Name 5", "Interesting book 64" },
                    { 65, 6, "Name 6", "Interesting book 65" },
                    { 66, 7, "Name 7", "Interesting book 66" },
                    { 67, 8, "Name 8", "Interesting book 67" },
                    { 68, 9, "Name 9", "Interesting book 68" },
                    { 69, 10, "Name 10", "Interesting book 69" },
                    { 70, 1, "Name 1", "Interesting book 70" },
                    { 71, 2, "Name 2", "Interesting book 71" },
                    { 72, 3, "Name 3", "Interesting book 72" },
                    { 73, 4, "Name 4", "Interesting book 73" },
                    { 74, 5, "Name 5", "Interesting book 74" },
                    { 75, 6, "Name 6", "Interesting book 75" },
                    { 76, 7, "Name 7", "Interesting book 76" },
                    { 77, 8, "Name 8", "Interesting book 77" },
                    { 78, 9, "Name 9", "Interesting book 78" },
                    { 79, 10, "Name 10", "Interesting book 79" },
                    { 80, 1, "Name 1", "Interesting book 80" },
                    { 81, 2, "Name 2", "Interesting book 81" },
                    { 82, 3, "Name 3", "Interesting book 82" },
                    { 83, 4, "Name 4", "Interesting book 83" },
                    { 84, 5, "Name 5", "Interesting book 84" },
                    { 85, 6, "Name 6", "Interesting book 85" },
                    { 86, 7, "Name 7", "Interesting book 86" },
                    { 87, 8, "Name 8", "Interesting book 87" },
                    { 88, 9, "Name 9", "Interesting book 88" },
                    { 89, 10, "Name 10", "Interesting book 89" },
                    { 90, 1, "Name 1", "Interesting book 90" },
                    { 91, 2, "Name 2", "Interesting book 91" },
                    { 92, 3, "Name 3", "Interesting book 92" },
                    { 93, 4, "Name 4", "Interesting book 93" },
                    { 94, 5, "Name 5", "Interesting book 94" },
                    { 95, 6, "Name 6", "Interesting book 95" },
                    { 96, 7, "Name 7", "Interesting book 96" },
                    { 97, 8, "Name 8", "Interesting book 97" },
                    { 98, 9, "Name 9", "Interesting book 98" },
                    { 99, 10, "Name 10", "Interesting book 99" },
                    { 100, 1, "Name 1", "Interesting book 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "reading",
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100);
        }
    }
}
