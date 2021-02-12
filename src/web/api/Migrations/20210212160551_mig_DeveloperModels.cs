using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class mig_DeveloperModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Follower = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Age", "CreatedAt", "Follower", "Name", "UpdatedAt" },
                values: new object[] { 1, 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "460", "Armin", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Age", "CreatedAt", "Follower", "Name", "UpdatedAt" },
                values: new object[] { 2, 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "60", "Amir", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Age", "CreatedAt", "Follower", "Name", "UpdatedAt" },
                values: new object[] { 3, 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "261", "Parsa", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Age", "CreatedAt", "Follower", "Name", "UpdatedAt" },
                values: new object[] { 4, 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "700", "Alireza", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 12, 19, 35, 50, 77, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 12, 19, 36, 50, 81, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 12, 19, 37, 50, 81, DateTimeKind.Unspecified).AddTicks(5942), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 12, 19, 38, 50, 81, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 12, 19, 39, 50, 81, DateTimeKind.Unspecified).AddTicks(5961), new TimeSpan(0, 3, 30, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 11, 11, 39, 26, 629, DateTimeKind.Unspecified).AddTicks(4593), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 11, 11, 40, 26, 634, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 11, 11, 41, 26, 634, DateTimeKind.Unspecified).AddTicks(7354), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 11, 11, 42, 26, 634, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 2, 11, 11, 43, 26, 634, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 3, 30, 0, 0)));
        }
    }
}
