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
            migrationBuilder.DropForeignKey(
                name: "FK_AppEvents_AspNetUsers_UserId",
                table: "AppEvents");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AppEvents",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_AppEvents_UserId",
                table: "AppEvents",
                newName: "IX_AppEvents_PatientId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dec81ab-0190-496b-954f-681b495b7d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ede6cae-13a7-4c73-9aa0-52a298a38039", "AQAAAAIAAYagAAAAECLwqeO9HeIJqf05+kNxTw4ONVouNDkJ5W2XmsXSKFyEpdrOGsrImFTrJRF/yT3qHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3b2f7fb-ebd8-49f2-a0e8-4d5342f23ad7", "AQAAAAIAAYagAAAAEInbhVt6SRVHhF9Ak2tipjGay+dklNc2U86zW7IUMQkdYBO7Lm80lDNd+A8aO7DQjQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 17, 47, 16, 356, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 17, 47, 16, 356, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 17, 47, 16, 356, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("86cf2b31-c56e-49f7-98ba-6dc0c4d21d18"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 17, 47, 16, 356, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8b74b23c-ec9b-4375-9c5e-acc3431c4f6b"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 17, 47, 16, 356, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.AddForeignKey(
                name: "FK_AppEvents_AspNetUsers_PatientId",
                table: "AppEvents",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppEvents_AspNetUsers_PatientId",
                table: "AppEvents");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "AppEvents",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AppEvents_PatientId",
                table: "AppEvents",
                newName: "IX_AppEvents_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dec81ab-0190-496b-954f-681b495b7d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33c95698-8c9f-4c9a-bacb-a84da24deab7", "AQAAAAIAAYagAAAAEJgxbAKv0vKFEIVqNJFVe7/CHWeB/NeqotqflNsKv6R2jWYW4jUPVS2q7j8l0YIKYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8de60efc-0803-45eb-aaf7-2525033f1881", "AQAAAAIAAYagAAAAENDpsrr7516PrrFrS+Zl0neR1JySLRcp0bSDKqUCXotQv2tM4I91H0UWb/2/Mu2N2g==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 11, 9, 55, 832, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 11, 9, 55, 832, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 11, 9, 55, 832, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("86cf2b31-c56e-49f7-98ba-6dc0c4d21d18"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 11, 9, 55, 832, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8b74b23c-ec9b-4375-9c5e-acc3431c4f6b"),
                column: "DateAdded",
                value: new DateTime(2024, 5, 5, 11, 9, 55, 832, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.AddForeignKey(
                name: "FK_AppEvents_AspNetUsers_UserId",
                table: "AppEvents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
