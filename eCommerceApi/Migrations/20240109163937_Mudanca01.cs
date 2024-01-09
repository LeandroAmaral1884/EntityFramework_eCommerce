using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceApi.Migrations
{
    /// <inheritdoc />
    public partial class Mudanca01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeMae",
                table: "Usuarios",
                newName: "Mae");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mae",
                table: "Usuarios",
                newName: "NomeMae");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
