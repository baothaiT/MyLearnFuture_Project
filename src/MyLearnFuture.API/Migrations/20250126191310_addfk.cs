using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLearnFuture.API.Migrations
{
    /// <inheritdoc />
    public partial class addfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VocabulariesTable_Image_Id",
                table: "VocabulariesTable",
                column: "Image_Id");

            migrationBuilder.CreateIndex(
                name: "IX_VocabulariesTable_SpacedRepetition_Id",
                table: "VocabulariesTable",
                column: "SpacedRepetition_Id");

            migrationBuilder.CreateIndex(
                name: "IX_VocabulariesTable_Topic_Id",
                table: "VocabulariesTable",
                column: "Topic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VocabulariesTable_ImagesTable_Image_Id",
                table: "VocabulariesTable",
                column: "Image_Id",
                principalTable: "ImagesTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VocabulariesTable_SpacedRepetitionConfigTable_SpacedRepetition_Id",
                table: "VocabulariesTable",
                column: "SpacedRepetition_Id",
                principalTable: "SpacedRepetitionConfigTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VocabulariesTable_TopicsTable_Topic_Id",
                table: "VocabulariesTable",
                column: "Topic_Id",
                principalTable: "TopicsTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VocabulariesTable_ImagesTable_Image_Id",
                table: "VocabulariesTable");

            migrationBuilder.DropForeignKey(
                name: "FK_VocabulariesTable_SpacedRepetitionConfigTable_SpacedRepetition_Id",
                table: "VocabulariesTable");

            migrationBuilder.DropForeignKey(
                name: "FK_VocabulariesTable_TopicsTable_Topic_Id",
                table: "VocabulariesTable");

            migrationBuilder.DropIndex(
                name: "IX_VocabulariesTable_Image_Id",
                table: "VocabulariesTable");

            migrationBuilder.DropIndex(
                name: "IX_VocabulariesTable_SpacedRepetition_Id",
                table: "VocabulariesTable");

            migrationBuilder.DropIndex(
                name: "IX_VocabulariesTable_Topic_Id",
                table: "VocabulariesTable");
        }
    }
}
