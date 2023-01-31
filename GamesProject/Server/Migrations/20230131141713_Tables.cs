using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesProject.Server.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 899, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9119), new DateTime(2023, 1, 31, 22, 17, 12, 900, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2d041519-128c-4d17-931e-ef78f42f5f22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "4e682482-ef3b-4a0f-9c19-1b8f5e0822c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b83762b-6cef-4e52-b5e7-dafba0f3b557", "AQAAAAEAACcQAAAAEMyS+14Xq2ctpjRCDbCRxtFWjluhe64yycPiD8ZJ24NoCGDDti1dRSzbfr764LziDw==", "2cf72640-6c40-4b48-bd12-708701388715" });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2554), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7055), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7066), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7069), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7076), new DateTime(2023, 1, 31, 22, 17, 12, 902, DateTimeKind.Local).AddTicks(7076) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 800, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6483), new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6486), new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6489), new DateTime(2023, 1, 31, 22, 15, 27, 803, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "4d0dd401-7093-4b5a-aeb5-cd6c91250a25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "e8ef7f10-8652-4e1d-b350-8579341c7765");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26cbad80-8a84-405e-91bb-b46924a37240", "AQAAAAEAACcQAAAAEJJLOLWjffrODqGcqMEPs7zPPUY61ODZPF+OTIh8SceG8sO/AdT4MfjBONKzjGFZIw==", "444aae09-a1ea-43f4-ac50-99c0460dd3e0" });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8163), new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8171), new DateTime(2023, 1, 31, 22, 15, 27, 805, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5216), new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 1, 31, 22, 15, 27, 806, DateTimeKind.Local).AddTicks(5220) });
        }
    }
}
