using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyLearnFuture.API.Migrations
{
    /// <inheritdoc />
    public partial class addDataVocabulary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VocabulariesTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Image_Id", "IsDelete", "Key", "SpacedRepetition_Id", "SpacedRepetition_LastLearn", "Topic_Id", "Transcription", "Value" },
                values: new object[,]
                {
                    { new Guid("2d7ec305-76b2-4938-a43a-0a777645b910"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df26b731-e9eb-455c-bc35-b2086f22b87d"), false, "Key1", new Guid("2ec77b9f-3a76-4954-98fb-71639f3ea63e"), new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("699a0a8c-63d2-4a3c-84fc-5179c19102e3"), "Transcription", "Value1" },
                    { new Guid("dc5c06d2-3359-4807-b0d4-aad40ee7c5af"), null, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("170870f1-deff-44ad-a64e-6d82baca96a8"), false, "Key1", new Guid("0f8f9715-4b2d-4825-a7c8-f455f829b50e"), new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9ecdd00-f934-42bc-9d9f-a286cfec8db1"), "Transcription", "Value1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VocabulariesTable",
                keyColumn: "Id",
                keyValue: new Guid("2d7ec305-76b2-4938-a43a-0a777645b910"));

            migrationBuilder.DeleteData(
                table: "VocabulariesTable",
                keyColumn: "Id",
                keyValue: new Guid("dc5c06d2-3359-4807-b0d4-aad40ee7c5af"));
        }
    }
}
