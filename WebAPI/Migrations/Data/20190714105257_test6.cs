using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations.Data
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrumexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrumexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeMusicLocals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeMusicLocals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationArtistPerformances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Village = table.Column<string>(maxLength: 50, nullable: true),
                    FullAddress = table.Column<string>(maxLength: 150, nullable: true),
                    LocationE = table.Column<string>(maxLength: 50, nullable: true),
                    LocationN = table.Column<string>(maxLength: 50, nullable: true),
                    TypeMusicLocal = table.Column<int>(nullable: false),
                    Instrumext = table.Column<int>(nullable: false),
                    SingleSinging = table.Column<bool>(nullable: false),
                    Commented = table.Column<string>(maxLength: 150, nullable: true),
                    TimeFree = table.Column<bool>(nullable: false),
                    TimeChange = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationArtistPerformances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationArtistPerformances_Instrumexts_Instrumext",
                        column: x => x.Instrumext,
                        principalTable: "Instrumexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationArtistPerformances_TypeMusicLocals_TypeMusicLocal",
                        column: x => x.TypeMusicLocal,
                        principalTable: "TypeMusicLocals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationArtistPerformances_Instrumext",
                table: "LocationArtistPerformances",
                column: "Instrumext");

            migrationBuilder.CreateIndex(
                name: "IX_LocationArtistPerformances_TypeMusicLocal",
                table: "LocationArtistPerformances",
                column: "TypeMusicLocal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationArtistPerformances");

            migrationBuilder.DropTable(
                name: "Instrumexts");

            migrationBuilder.DropTable(
                name: "TypeMusicLocals");
        }
    }
}
