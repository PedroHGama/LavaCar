using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WashCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class BDWashCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "FotoMimeType",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "FotoMimeType",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "IDFuncionario",
                table: "Recibo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDFuncionario",
                table: "Recibo");

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Funcionario",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "FotoMimeType",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Cliente",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "FotoMimeType",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
