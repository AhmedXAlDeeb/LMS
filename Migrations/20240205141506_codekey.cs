using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class codekey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "id",
                table: "classes");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "classes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "code",
                table: "classes");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "classes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "id");
        }
    }
}
