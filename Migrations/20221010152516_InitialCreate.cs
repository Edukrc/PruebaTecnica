using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroLogin.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PASS = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SALT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APELLIDOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIPO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.ID_USUARIO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
