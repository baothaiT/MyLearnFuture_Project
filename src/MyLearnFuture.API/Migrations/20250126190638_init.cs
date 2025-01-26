using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyLearnFuture.API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagesTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpacedRepetitionConfigTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DurationHours = table.Column<int>(type: "int", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpacedRepetitionConfigTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopicsTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VocabulariesTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpacedRepetition_LastLearn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Transcription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpacedRepetition_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Image_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Topic_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabulariesTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ImagesTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("170870f1-deff-44ad-a64e-6d82baca96a8"), null, null, false, "Name", "URL" },
                    { new Guid("6e79f4e1-bee7-427e-9a6a-00f7a4eb8bfb"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Name", "URL" },
                    { new Guid("df26b731-e9eb-455c-bc35-b2086f22b87d"), null, null, false, "Name", "URL" }
                });

            migrationBuilder.InsertData(
                table: "SpacedRepetitionConfigTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DurationDays", "DurationHours", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("0f8f9715-4b2d-4825-a7c8-f455f829b50e"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, false },
                    { new Guid("2ec77b9f-3a76-4954-98fb-71639f3ea63e"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, false }
                });

            migrationBuilder.InsertData(
                table: "TopicsTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("699a0a8c-63d2-4a3c-84fc-5179c19102e3"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic2" },
                    { new Guid("d9ecdd00-f934-42bc-9d9f-a286cfec8db1"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagesTable");

            migrationBuilder.DropTable(
                name: "SpacedRepetitionConfigTable");

            migrationBuilder.DropTable(
                name: "TopicsTable");

            migrationBuilder.DropTable(
                name: "VocabulariesTable");
        }
    }
}
