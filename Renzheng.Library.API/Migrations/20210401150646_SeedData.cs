using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Renzheng.Library.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthData",
                table: "Authors",
                newName: "BirthDate");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"), new DateTimeOffset(new DateTime(1998, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Gaoan", "renzheng.zhang@gmail.com", "Renzheng Zhang" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("2299cc36-b597-47af-a86d-88237471f575"), new DateTimeOffset(new DateTime(1968, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "New York", "halbert.wood@gmail.com", "Halbert Wood" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("25bca7b2-903a-48f0-817c-4b5d2df36be8"), new DateTimeOffset(new DateTime(1988, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "Sydeny", "bernice.edwin@gmail.com", "Bernice Edwin" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[,]
                {
                    { new Guid("28c2e75b-784b-4fdc-89fe-683f3551bf3a"), new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"), "Some words on the same segment are still similar distances apart, even if new words have been interspersed.", 120, "Bleak House" },
                    { new Guid("b564f709-a84b-4a98-9895-fc822fbd97b0"), new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"), "That way lies intellectually corrupt AI projects which I'll not taunt by naming here.", 120, "High-Rise" },
                    { new Guid("e18cccd6-7043-4389-a597-75c9034375b7"), new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"), "However, whether that really mattered.", 120, "Cranford" },
                    { new Guid("5745a101-5f8b-46c7-ba01-286d1917da52"), new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"), "The influence of these bands is felt in nearly all branches of modern pop music.", 120, "The White Queen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2299cc36-b597-47af-a86d-88237471f575"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("25bca7b2-903a-48f0-817c-4b5d2df36be8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("28c2e75b-784b-4fdc-89fe-683f3551bf3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5745a101-5f8b-46c7-ba01-286d1917da52"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b564f709-a84b-4a98-9895-fc822fbd97b0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e18cccd6-7043-4389-a597-75c9034375b7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c12e01e2-384e-4a80-a4e8-edf01378eb7d"));

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Authors",
                newName: "BirthData");
        }
    }
}
