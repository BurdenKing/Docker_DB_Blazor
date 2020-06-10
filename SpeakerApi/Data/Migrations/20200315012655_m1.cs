using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerApi.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    AreaSpecification = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    Employer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "AreaSpecification", "City", "Email", "Employer", "FirstName", "LastName", "Phone", "Province" },
                values: new object[] { "32dd1f92-9c7e-4084-a16b-420649507c51", "Idol", "Seoul", "c@c.c", "Off The Record", "Choi", "Yena", "6045555555", "Gyeonggi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");
        }
    }
}
