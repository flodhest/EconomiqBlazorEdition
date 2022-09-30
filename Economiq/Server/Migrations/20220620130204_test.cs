using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economiq.Server.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Recipients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Recipients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ExpenseDate" },
                values: new object[] { new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(8142), new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Street", "Zipcode" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Street", "Zipcode" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Street", "Zipcode" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Street", "Zipcode" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Street", "Zipcode" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Street", "Zipcode" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 6, 20, 15, 2, 4, 339, DateTimeKind.Local).AddTicks(7780));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Street",
                table: "Recipients");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Recipients");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ExpenseDate" },
                values: new object[] { new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4857), new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "ExpensesCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4482));
        }
    }
}
