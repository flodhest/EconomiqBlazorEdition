using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economiq.Server.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ExpenseDate" },
                values: new object[] { new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 10, 5, 12, 2, 42, 323, DateTimeKind.Local).AddTicks(7698));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ExpenseDate" },
                values: new object[] { new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6232), new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 9, 19, 11, 20, 16, 149, DateTimeKind.Local).AddTicks(6069));
        }
    }
}
