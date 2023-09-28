using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TknkService.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cihazs",
                columns: table => new
                {
                    cihazID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cihazAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cihazDurum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cihazs", x => x.cihazID);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    perId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    perAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.perId);
                });

            migrationBuilder.CreateTable(
                name: "musteris",
                columns: table => new
                {
                    Musteriid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chzcihazID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteris", x => x.Musteriid);
                    table.ForeignKey(
                        name: "FK_musteris_cihazs_chzcihazID",
                        column: x => x.chzcihazID,
                        principalTable: "cihazs",
                        principalColumn: "cihazID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_musteris_chzcihazID",
                table: "musteris",
                column: "chzcihazID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "musteris");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "cihazs");
        }
    }
}
