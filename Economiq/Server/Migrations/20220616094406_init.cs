using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economiq.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpensesCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensesCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLoggedIn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Mail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserNavId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => new { x.UserNavId, x.Mail });
                    table.ForeignKey(
                        name: "FK_Email_Users_UserNavId",
                        column: x => x.UserNavId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseCategoryUser",
                columns: table => new
                {
                    ExpensesCategoryNavId = table.Column<int>(type: "int", nullable: false),
                    UserNavId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategoryUser", x => new { x.ExpensesCategoryNavId, x.UserNavId });
                    table.ForeignKey(
                        name: "FK_ExpenseCategoryUser_ExpensesCategory_ExpensesCategoryNavId",
                        column: x => x.ExpensesCategoryNavId,
                        principalTable: "ExpensesCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseCategoryUser_Users_UserNavId",
                        column: x => x.UserNavId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNavId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipients_Users_UserNavId",
                        column: x => x.UserNavId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNavId = table.Column<int>(type: "int", nullable: false),
                    CategoryNavId = table.Column<int>(type: "int", nullable: true),
                    RecipientNavId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpensesCategory_CategoryNavId",
                        column: x => x.CategoryNavId,
                        principalTable: "ExpensesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_Recipients_RecipientNavId",
                        column: x => x.RecipientNavId,
                        principalTable: "Recipients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expenses_Users_UserNavId",
                        column: x => x.UserNavId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExpensesCategory",
                columns: new[] { "Id", "CategoryName", "CreationDate" },
                values: new object[,]
                {
                    { 1, "Rent", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4678) },
                    { 2, "Food", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4682) },
                    { 3, "Transport", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4684) },
                    { 4, "Clothing", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4687) },
                    { 5, "Entertainment", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4689) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "CreationDate", "Fname", "Gender", "IsLoggedIn", "Lname", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4433), "Julia", "Female", false, "Hook", "Testing123", "JuliaH" },
                    { 2, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4467), "Alexander", "Male", false, "Volonen", "Testing234", "AlexV" },
                    { 3, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4470), "Stefan", "Male", false, "Krakowsky", "Testing345", "Peppo" },
                    { 4, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4472), "Winnie", "Female", false, "Huynh", "Testing456", "WinnieH" },
                    { 5, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4474), "Eric", "Male", false, "Flodin", "Testing567", "Ericx" },
                    { 6, "Fjugesta", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4477), "Anders", "Male", false, "Bergstrom", "Testing678", "AndersB" },
                    { 7, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4480), "Peter", "Male", false, "Hafid", "Testing789", "PeterH" },
                    { 8, "Orebro", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4482), "admin", "Male", false, "admin", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Email",
                columns: new[] { "Mail", "UserNavId" },
                values: new object[,]
                {
                    { "JuliaH@test.com", 1 },
                    { "AlexV@test.com", 2 },
                    { "Peppo@test.com", 3 },
                    { "WinnieH@test.com", 4 },
                    { "Ericx@test.com", 5 },
                    { "AndersB@test.com", 6 },
                    { "PeterH@test.com", 7 },
                    { "admin@admin.com", 8 }
                });

            migrationBuilder.InsertData(
                table: "ExpenseCategoryUser",
                columns: new[] { "ExpensesCategoryNavId", "UserNavId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 }
                });

            migrationBuilder.InsertData(
                table: "ExpenseCategoryUser",
                columns: new[] { "ExpensesCategoryNavId", "UserNavId" },
                values: new object[] { 5, 7 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CategoryNavId", "Comment", "CreationDate", "ExpenseDate", "RecipientNavId", "UserNavId" },
                values: new object[] { 1, 25m, 2, "Glass", new DateTime(2022, 6, 16, 11, 44, 5, 745, DateTimeKind.Local).AddTicks(4857), new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), null, 1 });

            migrationBuilder.InsertData(
                table: "Recipients",
                columns: new[] { "Id", "City", "Name", "UserNavId" },
                values: new object[,]
                {
                    { 1, "Örebro", "ICA", 1 },
                    { 2, "Stockholm", "H&M", 5 },
                    { 3, "Göteborg", "Alfred", 3 },
                    { 4, "Örebro", "Hanna", 4 },
                    { 5, "Nora", "ICA", 7 },
                    { 6, "Morgongåva", "Coop", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseCategoryUser_UserNavId",
                table: "ExpenseCategoryUser",
                column: "UserNavId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CategoryNavId",
                table: "Expenses",
                column: "CategoryNavId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_RecipientNavId",
                table: "Expenses",
                column: "RecipientNavId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserNavId",
                table: "Expenses",
                column: "UserNavId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipients_UserNavId",
                table: "Recipients",
                column: "UserNavId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "ExpenseCategoryUser");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "ExpensesCategory");

            migrationBuilder.DropTable(
                name: "Recipients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
