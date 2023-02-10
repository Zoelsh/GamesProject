using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesProject.Server.Migrations
{
    public partial class Databases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 437, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8325), new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8330), new DateTime(2023, 2, 10, 8, 57, 50, 438, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "fa7f37a9-07b7-4aa3-8ffd-9f10a552913c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "16eb85d1-27f4-4b80-9244-1919d23baaef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcf6a38b-9c17-4559-9939-ecc0e4aa4b15", "AQAAAAEAACcQAAAAEJr5mW7lFnFCp75VYrYTKdl38cTlkgdPNYMz79FeUIcx9lHQqhgKcwRqfVddJMl5Lw==", "cd1bb181-c8b9-458f-8b3e-28af4b5ca334" });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(178), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(180), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4086), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4103), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 2, 10, 8, 57, 50, 440, DateTimeKind.Local).AddTicks(4106) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 370, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2082), new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2094), new DateTime(2023, 2, 9, 21, 49, 0, 373, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "16eb1545-55f6-4b3f-bcad-3d5ed61162d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d6085c5f-6324-4e45-88ee-d63beaccb1e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc6f736a-7ed0-432e-80d7-d4f8d78d2291", "AQAAAAEAACcQAAAAEE9HtxgTDS6tY1W6XHLZhC7Br4Iw6w1bgfAVxm8Bei5xhLd0YUW5YOB5+ok/97FiYw==", "c0f0a198-a34c-486d-b310-b109ac35265a" });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3909), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3925), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3927), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 2, 9, 21, 49, 0, 374, DateTimeKind.Local).AddTicks(7985) });
        }
    }
}
