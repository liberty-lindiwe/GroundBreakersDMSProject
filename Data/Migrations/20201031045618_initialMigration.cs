using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBMS.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Line1 = table.Column<int>(nullable: false),
                    Line2 = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    Surburb = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Representative",
                columns: table => new
                {
                    RepresentativeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representative", x => x.RepresentativeID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Company_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TraddingName = table.Column<string>(nullable: true),
                    RegisteredName = table.Column<string>(nullable: true),
                    OfficeAddress = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Faculty_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incubator",
                columns: table => new
                {
                    IncubatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RepresentativeId = table.Column<int>(nullable: false),
                    ProgrammeId = table.Column<int>(nullable: false),
                    FacultyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incubator", x => x.IncubatorId);
                    table.ForeignKey(
                        name: "FK_Incubator_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incubator_Representative_RepresentativeId",
                        column: x => x.RepresentativeId,
                        principalTable: "Representative",
                        principalColumn: "RepresentativeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programme",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ProgrammeFunder = table.Column<string>(nullable: true),
                    NumberOfProgrammApplicants = table.Column<int>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    PartnerShipAgreeing = table.Column<string>(nullable: true),
                    IncubatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programme", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Programme_Incubator_IncubatorId",
                        column: x => x.IncubatorId,
                        principalTable: "Incubator",
                        principalColumn: "IncubatorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ProgrammeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Programme_ProgrammeID",
                        column: x => x.ProgrammeID,
                        principalTable: "Programme",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartUp",
                columns: table => new
                {
                    StartUpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<int>(nullable: false),
                    AlternativeNumber = table.Column<int>(nullable: false),
                    officeAddress = table.Column<string>(nullable: true),
                    RepresentativeID = table.Column<int>(nullable: true),
                    ProgrammeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartUp", x => x.StartUpID);
                    table.ForeignKey(
                        name: "FK_StartUp_Programme_ProgrammeID",
                        column: x => x.ProgrammeID,
                        principalTable: "Programme",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StartUp_Representative_RepresentativeID",
                        column: x => x.RepresentativeID,
                        principalTable: "Representative",
                        principalColumn: "RepresentativeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiary",
                columns: table => new
                {
                    BeneficiaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Said = table.Column<int>(nullable: false),
                    passport = table.Column<string>(nullable: true),
                    imigration = table.Column<string>(nullable: true),
                    CountryOfBirth = table.Column<string>(nullable: true),
                    HomeLanguage = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<int>(nullable: false),
                    AlternativeNumber = table.Column<int>(nullable: false),
                    LiveinTownShip = table.Column<bool>(nullable: false),
                    highestQaulification = table.Column<string>(nullable: true),
                    highestEducation = table.Column<string>(nullable: true),
                    Tertiary = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    TotalWorkExperiance = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: true),
                    ProgrammeID = table.Column<int>(nullable: true),
                    StartUpID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiary", x => x.BeneficiaryID);
                    table.ForeignKey(
                        name: "FK_Beneficiary_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiary_Programme_ProgrammeID",
                        column: x => x.ProgrammeID,
                        principalTable: "Programme",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiary_StartUp_StartUpID",
                        column: x => x.StartUpID,
                        principalTable: "StartUp",
                        principalColumn: "StartUpID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_AddressId",
                table: "Beneficiary",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_ProgrammeID",
                table: "Beneficiary",
                column: "ProgrammeID");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_StartUpID",
                table: "Beneficiary",
                column: "StartUpID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressId",
                table: "Company",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_CompanyId",
                table: "Faculty",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Incubator_FacultyID",
                table: "Incubator",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Incubator_RepresentativeId",
                table: "Incubator",
                column: "RepresentativeId");

            migrationBuilder.CreateIndex(
                name: "IX_Programme_IncubatorId",
                table: "Programme",
                column: "IncubatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ProgrammeID",
                table: "Report",
                column: "ProgrammeID");

            migrationBuilder.CreateIndex(
                name: "IX_StartUp_ProgrammeID",
                table: "StartUp",
                column: "ProgrammeID");

            migrationBuilder.CreateIndex(
                name: "IX_StartUp_RepresentativeID",
                table: "StartUp",
                column: "RepresentativeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "StartUp");

            migrationBuilder.DropTable(
                name: "Programme");

            migrationBuilder.DropTable(
                name: "Incubator");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Representative");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
