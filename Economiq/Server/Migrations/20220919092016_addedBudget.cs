using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economiq.Server.Migrations
{
    public partial class addedBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BudgetNav",
                table: "Expenses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserNav = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budgets_Users_UserNav",
                        column: x => x.UserNav,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_BudgetNav",
                table: "Expenses",
                column: "BudgetNav");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_UserNav",
                table: "Budgets",
                column: "UserNav");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Budgets_BudgetNav",
                table: "Expenses",
                column: "BudgetNav",
                principalTable: "Budgets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Budgets_BudgetNav",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_BudgetNav",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "BudgetNav",
                table: "Expenses");

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
    }
}
