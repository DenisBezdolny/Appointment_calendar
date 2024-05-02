using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appointment_calendar.Migrations
{
    /// <inheritdoc />
    public partial class _2_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee560ba8-3277-4414-9a66-300fb2ffae38", null, "patient", "PATIENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dec81ab-0190-496b-954f-681b495b7d70",
                columns: new[] { "ConcurrencyStamp", "Description", "Email", "NormalizedEmail", "PasswordHash", "Place" },
                values: new object[] { "f1b5c46f-572c-459a-ac13-4e5af9e50c8c", null, "Cheidfoureyes@yandex.ru", "CHEIDFOUREYES@YANDEX.RU", "AQAAAAIAAYagAAAAENQF8XFD6BcW1g8ajuChnYRUGUkg9OyC080HBmrrC3sa1XnddJsT6iQTDyNLE9sMaw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Description", "PasswordHash", "Place" },
                values: new object[] { "a9063a18-bb8a-4fca-b1f3-4110b66a8dcf", null, "AQAAAAIAAYagAAAAEOYzIeJauude4IM8yHvz47epLkPBDX/vraGJC3reAKJzCfVUZvm+Ls5LU06zOmpC+w==", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 18, 55, 42, 594, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 18, 55, 42, 594, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 18, 55, 42, 594, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("86cf2b31-c56e-49f7-98ba-6dc0c4d21d18"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 18, 55, 42, 594, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8b74b23c-ec9b-4375-9c5e-acc3431c4f6b"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 18, 55, 42, 594, DateTimeKind.Utc).AddTicks(5356));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee560ba8-3277-4414-9a66-300fb2ffae38");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dec81ab-0190-496b-954f-681b495b7d70",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "79600cca-8ae3-4d3b-a9f4-4fb72808cfff", "my@email.com", "MY@EMAIL.COM", "AQAAAAIAAYagAAAAECo3CvqlYLR1z9NaZGpisCEYZ3vN9P1LTlybTuveW5GSBlvYu5EYxKyGwPqAusndmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "092674c8-d227-4062-9121-b6ab79cc39ed", "AQAAAAIAAYagAAAAEF+Og3RJMdgmridHeAJRxaNlYc8qD0FczCIRJ7hJwGJadEegk/68IFYA9Gg8eNVJhg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 11, 1, 42, 772, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 11, 1, 42, 772, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 11, 1, 42, 772, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("86cf2b31-c56e-49f7-98ba-6dc0c4d21d18"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 11, 1, 42, 772, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8b74b23c-ec9b-4375-9c5e-acc3431c4f6b"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 1, 11, 1, 42, 772, DateTimeKind.Utc).AddTicks(1920));
        }
    }
}
