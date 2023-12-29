using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beltek.HelloMVC.Migrations
{
    public partial class OgretmenInitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOgretmenler",
                columns: table => new
                {
                    Ogretmenid = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Ad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Alan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgretmenler");
        }
    }
}
