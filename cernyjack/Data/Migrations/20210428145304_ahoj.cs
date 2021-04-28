using Microsoft.EntityFrameworkCore.Migrations;

namespace cernyjack.Data.Migrations
{
    public partial class ahoj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserCards_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 29, 4 },
                    { 30, 5 },
                    { 31, 6 },
                    { 32, 7 },
                    { 33, 8 },
                    { 34, 9 },
                    { 35, 10 },
                    { 36, 10 },
                    { 37, 10 },
                    { 38, 10 },
                    { 28, 3 },
                    { 39, 10 },
                    { 41, 3 },
                    { 42, 4 },
                    { 43, 5 },
                    { 44, 6 },
                    { 45, 7 },
                    { 46, 8 },
                    { 47, 9 },
                    { 48, 10 },
                    { 49, 10 },
                    { 50, 10 },
                    { 40, 2 },
                    { 27, 2 },
                    { 26, 10 },
                    { 25, 10 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 7 },
                    { 7, 8 },
                    { 8, 9 },
                    { 9, 10 },
                    { 10, 10 },
                    { 11, 10 },
                    { 12, 10 },
                    { 13, 10 },
                    { 14, 2 },
                    { 15, 3 },
                    { 16, 4 }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 17, 5 },
                    { 18, 6 },
                    { 19, 7 },
                    { 20, 8 },
                    { 21, 9 },
                    { 22, 10 },
                    { 23, 10 },
                    { 24, 10 },
                    { 51, 10 },
                    { 52, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_CardId",
                table: "UserCards",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCards");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "AspNetUsers");
        }
    }
}
