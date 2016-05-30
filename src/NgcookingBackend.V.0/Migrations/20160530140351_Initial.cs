using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace NgcookingBackend.V._0.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NgcookingBackend.Models.Communautes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bio = table.Column<string>(nullable: true),
                    Birth = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communaute", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "NgcookingBackend.Models.Recettes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<int>(nullable: false),
                    CommunauteId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recette", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recette_Communaute_CommunauteId",
                        column: x => x.CommunauteId,
                        principalTable: "NgcookingBackend.Models.Communautes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("NgcookingBackend.Models.Recettes");
            migrationBuilder.DropTable("NgcookingBackend.Models.Communautes");
        }
    }
}
