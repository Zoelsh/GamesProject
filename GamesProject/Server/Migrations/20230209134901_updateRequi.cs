using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesProject.Server.Migrations
{
    public partial class updateRequi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AgeRatings_AgeRatingId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_GamePublishers_GamePublisherId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GamePublisherId",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgeRatingId",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GamePublishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AgeRatings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AgeRatings_AgeRatingId",
                table: "Games",
                column: "AgeRatingId",
                principalTable: "AgeRatings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GamePublishers_GamePublisherId",
                table: "Games",
                column: "GamePublisherId",
                principalTable: "GamePublishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AgeRatings_AgeRatingId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_GamePublishers_GamePublisherId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GamePublisherId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgeRatingId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GamePublishers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AgeRatings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 420, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "AgeRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 2, 3, 12, 0, 39, 422, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "da178469-b3f8-41f8-baa9-923dfe9ca94f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "50ae26b7-542d-4f99-88b3-10b4ae2b1099");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "190b6eb6-a3dc-4bd8-a5b9-19e1fe5d3085", "AQAAAAEAACcQAAAAEFInLTZpZ/9lReXW7qFsCnN0Q0Hsm8wo8Co3PlPaiV9i3vf9bzWXOKggG/DZ10A2sQ==", "d407ec3a-129d-4bfe-bea1-9539f9c1db98" });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "GamePublishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 2, 3, 12, 0, 39, 423, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2586), new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2597), new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2603), new DateTime(2023, 2, 3, 12, 0, 39, 424, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AgeRatings_AgeRatingId",
                table: "Games",
                column: "AgeRatingId",
                principalTable: "AgeRatings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GamePublishers_GamePublisherId",
                table: "Games",
                column: "GamePublisherId",
                principalTable: "GamePublishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
