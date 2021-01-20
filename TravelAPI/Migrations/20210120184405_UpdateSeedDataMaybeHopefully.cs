using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class UpdateSeedDataMaybeHopefully : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "Body", "DestinationId", "Rating", "Title", "WouldRecommend" },
                values: new object[] { "Pretty good.", 1, 4, "Review #01", true });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "Body", "DestinationId", "Rating", "Title", "WouldRecommend" },
                values: new object[] { "Pretty bad.", 2, 2, "Review #02", false });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "Body", "Rating", "Title", "WouldRecommend" },
                values: new object[] { "Amaaaaaaaazing", 5, "Review #03", true });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Body", "DestinationId", "Rating", "Title", "WouldRecommend" },
                values: new object[] { 5, "Middle of the Road", 3, 3, "Review #04", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "Body", "DestinationId", "Rating", "Title", "WouldRecommend" },
                values: new object[] { "Pretty bad.", 2, 2, "Review #02", false });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "Body", "DestinationId", "Rating", "Title", "WouldRecommend" },
                values: new object[] { "Amaaaaaaaazing", 3, 5, "Review #03", true });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "Body", "Rating", "Title", "WouldRecommend" },
                values: new object[] { "Middle of the Road", 3, "Review #04", false });
        }
    }
}
