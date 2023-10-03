using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    aboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutHeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    aboutSubTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    aboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutSocialMedia = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.aboutId);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    mail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.contactId);
                });

            migrationBuilder.CreateTable(
                name: "educations",
                columns: table => new
                {
                    educationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educationSchool = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    educationAdress = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    educationDepartment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    educationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educations", x => x.educationId);
                });

            migrationBuilder.CreateTable(
                name: "experiences",
                columns: table => new
                {
                    experienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    experienceDates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    experiencePosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    experienceAdress = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    experienceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiences", x => x.experienceId);
                });

            migrationBuilder.CreateTable(
                name: "headers",
                columns: table => new
                {
                    headerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    headerDescription1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    headerDescription2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_headers", x => x.headerId);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    projectsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectsTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    projectsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectsImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.projectsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "educations");

            migrationBuilder.DropTable(
                name: "experiences");

            migrationBuilder.DropTable(
                name: "headers");

            migrationBuilder.DropTable(
                name: "projects");
        }
    }
}
