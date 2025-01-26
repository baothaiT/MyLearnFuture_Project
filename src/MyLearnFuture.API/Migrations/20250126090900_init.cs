using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    CreateBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopicsTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpacedRepetitionConfigTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DurationHours = table.Column<int>(type: "int", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    ImagesEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpacedRepetitionConfigEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TopicsEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpacedRepetitionConfigTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpacedRepetitionConfigTable_ImagesTable_ImagesEntityId",
                        column: x => x.ImagesEntityId,
                        principalTable: "ImagesTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpacedRepetitionConfigTable_SpacedRepetitionConfigTable_SpacedRepetitionConfigEntityId",
                        column: x => x.SpacedRepetitionConfigEntityId,
                        principalTable: "SpacedRepetitionConfigTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpacedRepetitionConfigTable_TopicsTable_TopicsEntityId",
                        column: x => x.TopicsEntityId,
                        principalTable: "TopicsTable",
                        principalColumn: "Id");
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
                    SpacedRepetitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Image_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Topic_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TopicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabulariesTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VocabulariesTable_ImagesTable_ImageId",
                        column: x => x.ImageId,
                        principalTable: "ImagesTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VocabulariesTable_SpacedRepetitionConfigTable_SpacedRepetitionId",
                        column: x => x.SpacedRepetitionId,
                        principalTable: "SpacedRepetitionConfigTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VocabulariesTable_TopicsTable_TopicId",
                        column: x => x.TopicId,
                        principalTable: "TopicsTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpacedRepetitionConfigTable_ImagesEntityId",
                table: "SpacedRepetitionConfigTable",
                column: "ImagesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SpacedRepetitionConfigTable_SpacedRepetitionConfigEntityId",
                table: "SpacedRepetitionConfigTable",
                column: "SpacedRepetitionConfigEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SpacedRepetitionConfigTable_TopicsEntityId",
                table: "SpacedRepetitionConfigTable",
                column: "TopicsEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabulariesTable_ImageId",
                table: "VocabulariesTable",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabulariesTable_SpacedRepetitionId",
                table: "VocabulariesTable",
                column: "SpacedRepetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabulariesTable_TopicId",
                table: "VocabulariesTable",
                column: "TopicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VocabulariesTable");

            migrationBuilder.DropTable(
                name: "SpacedRepetitionConfigTable");

            migrationBuilder.DropTable(
                name: "ImagesTable");

            migrationBuilder.DropTable(
                name: "TopicsTable");
        }
    }
}
