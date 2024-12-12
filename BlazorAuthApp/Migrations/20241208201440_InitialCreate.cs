using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorAuthApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_account_policy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    UserPolicy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account_policy", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "user_account",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "user1", "user1" },
                    { 2, "user2", "user2" },
                    { 3, "user3", "user3" },
                    { 4, "user4", "user4" },
                    { 5, "user5", "user5" }
                });

            migrationBuilder.InsertData(
                table: "user_account_policy",
                columns: new[] { "Id", "IsEnabled", "UserAccountId", "UserPolicy" },
                values: new object[,]
                {
                    { 1, true, 1, "VIEW_PRODUCT" },
                    { 2, true, 1, "ADD_PRODUCT" },
                    { 3, true, 1, "EDIT_PRODUCT" },
                    { 4, true, 1, "DELETE_PRODUCT" },
                    { 5, true, 2, "VIEW_PRODUCT" },
                    { 6, false, 2, "ADD_PRODUCT" },
                    { 7, false, 2, "EDIT_PRODUCT" },
                    { 8, false, 2, "DELETE_PRODUCT" },
                    { 9, true, 3, "VIEW_PRODUCT" },
                    { 10, true, 3, "ADD_PRODUCT" },
                    { 11, false, 3, "EDIT_PRODUCT" },
                    { 12, false, 3, "DELETE_PRODUCT" },
                    { 13, true, 4, "VIEW_PRODUCT" },
                    { 14, true, 4, "ADD_PRODUCT" },
                    { 15, true, 4, "EDIT_PRODUCT" },
                    { 16, false, 4, "DELETE_PRODUCT" },
                    { 17, false, 5, "VIEW_PRODUCT" },
                    { 18, false, 5, "ADD_PRODUCT" },
                    { 19, false, 5, "EDIT_PRODUCT" },
                    { 20, false, 5, "DELETE_PRODUCT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_account");

            migrationBuilder.DropTable(
                name: "user_account_policy");
        }
    }
}
