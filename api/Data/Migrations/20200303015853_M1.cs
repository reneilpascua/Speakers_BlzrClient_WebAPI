using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Data.Migrations
{
    public partial class M1 : Migration
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
                    MobileNumber = table.Column<string>(nullable: false),
                    Specialization = table.Column<string>(nullable: false),
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
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[] { "f7fe91db-40ad-433f-9bdf-aa4a193823b0", "Vancouver", "aaa@aaa.com", "Javazon Prime", "Tom", "Day", "1231231234", "BC", "Java" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[] { "b7f204e0-9aae-4fbf-a99c-ea8c95cd9157", "Surrey", "bbb@aaa.com", "Denny's", "John", "Ham", "1231231234", "BC", "Breakfast" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[] { "5b97c8fd-31aa-407a-9e54-36776efd0511", "Richmond", "ccc@aaa.com", "AUDL", "Reneil", "Pascua", "1231231234", "BC", "Ultimate Frisbee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");
        }
    }
}
