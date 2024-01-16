using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerceApi.Migrations
{
    /// <inheritdoc />
    public partial class Carga01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartamentoUsuario");

            migrationBuilder.CreateTable(
                name: "DepartamentosUsuario",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentosUsuario", x => new { x.DepartamentoId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_DepartamentosUsuario_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartamentosUsuario_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Informatica" },
                    { 2, "Moda" },
                    { 3, "Eletros" },
                    { 4, "Beleza" },
                    { 5, "Moveis" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartamentosUsuario_UsuariosId",
                table: "DepartamentosUsuario",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartamentosUsuario");

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.CreateTable(
                name: "DepartamentoUsuario",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentoUsuario", x => new { x.DepartamentoId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_DepartamentoUsuario_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartamentoUsuario_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartamentoUsuario_UsuariosId",
                table: "DepartamentoUsuario",
                column: "UsuariosId");
        }
    }
}
