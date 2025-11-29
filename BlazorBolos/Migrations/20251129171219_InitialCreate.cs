using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorBolos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bolos",
                columns: new[] { "Id", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, "Delicioso bolo de banana", "https://marcoratti.net/Imagens/bolos/bolo_banana.jpg", "Bolo de Banana", 23.00m },
                    { 2, "Delicioso bolo de Brigadeiro", "https://marcoratti.net/Imagens/bolos/bolo_brigadeiro.jpg", "Bolo de Brigadeiro", 31.50m },
                    { 3, "Delicioso bolo de Chocolate", "https://marcoratti.net/Imagens/bolos/bolo_chocolate.jpg", "Bolo de Chocolate", 41.00m },
                    { 4, "Delicioso bolo de Laranja", "https://marcoratti.net/Imagens/bolos/bolo_laranja.jpg", "Bolo de Laranja", 35.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolos");
        }
    }
}
