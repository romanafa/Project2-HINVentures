using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class MessageUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerRating_AspNetUsers_FreelancerId",
                table: "FreelancerRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreelancerRating",
                table: "FreelancerRating");

            migrationBuilder.RenameTable(
                name: "FreelancerRating",
                newName: "Ratings");

            migrationBuilder.RenameIndex(
                name: "IX_FreelancerRating_FreelancerId",
                table: "Ratings",
                newName: "IX_Ratings_FreelancerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "RatingId");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "8da8722a-2927-4943-bc6f-d325b3c41228");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "8004139b-ec88-47c2-9f31-f33112ecd57a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "94cb0641-6da6-4620-8c5a-e4529a7ee8e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "363a9142-22b5-4b28-ab97-1741d2ca72b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "f3886d1f-159b-47ea-8f0e-eacc44b7fac0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6c7358-6dea-434c-8c16-f762a5db6289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19d5df3d-f619-4477-9925-33140e39ae3f", "AQAAAAEAACcQAAAAEHYTd3gbfvvK+aDJ5hwDnqAISmZzlEscDayeGgY3I71oL0Gf43I74Q5ttqzDwp3E7w==", "81624e59-a9a3-4906-80c2-7ca3c4c07cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab8fe302-f74f-4bde-b473-722474d6f738", "AQAAAAEAACcQAAAAEFksFij6sGmcsEOFl2BALnKjBcT0VAjc9WsuNZfrKP26bkUCU7FQExGR5GKmwdscoQ==", "eb194787-245e-404d-b7e0-68b3ed50e009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8752ab-6f9c-444a-94fd-91c39d874373", "AQAAAAEAACcQAAAAELu0JDCT4QybHPDLPihbNl1qHL4fVremQ3r+qkFNs9Q+m+JgolIuwp1h8K+Y83eong==", "1df6579c-0958-44fc-b08b-f84fe73ea2b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb373c53-6ed8-4d92-b049-4311c719c52a", "AQAAAAEAACcQAAAAEAdMTaxGLOMivAeW0KNE+ojJmegsTrh1XJVXRMdREeZvrPrS07q8zIRP3CwYhq7iyA==", "44fbccaa-60b5-4489-9f28-89381e0a90ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb945ebf-b866-4268-9455-f5bb1bf04c19", "AQAAAAEAACcQAAAAEJVJPuq3/RBi8jPycnm2vPJwc0jUMS8Ik/9LBaBKseHiLZpf+68CmyIi88wYLwhPdg==", "2018388d-a2ff-4eaf-b04d-d171c4368a0c" });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ApplicationUserId",
                table: "Messages",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_FreelancerId",
                table: "Ratings",
                column: "FreelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_FreelancerId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "FreelancerRating");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_FreelancerId",
                table: "FreelancerRating",
                newName: "IX_FreelancerRating_FreelancerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreelancerRating",
                table: "FreelancerRating",
                column: "RatingId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "8e8b3844-cf58-4a63-8399-99a8703a94d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "19f10650-5cda-43f2-ac70-f33683409184");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "d39defcd-34a7-4e12-8f6e-b0fb7d8531e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "4985ff39-e566-4976-bc67-1021ba8892d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "0cb8da30-cc87-46be-9652-0f6db910a709");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6c7358-6dea-434c-8c16-f762a5db6289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80673048-281b-473f-9faf-519a2d2039c7", "AQAAAAEAACcQAAAAELVD41QgGFwmWLsEZvspukg8JcxGf2PDBKZ0ODrseHk0D+d3f9nuk9+Nu3Jp/mW7sA==", "1378a7b9-f1c2-4175-9dc3-9efbfaf49346" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9fb1431-7434-4373-b467-3bc921b30b50", "AQAAAAEAACcQAAAAEBIjMdkA6o7ZHtLeqkVRlZYbx9HpkCFfOwHLiwN2a3q9XsKP3kcHftmvNHYKh4AdaA==", "cdd422e3-bcdc-468e-962e-fbe49d8c9388" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5cab823-ed29-436b-bb5e-4a211b15a1f5", "AQAAAAEAACcQAAAAEP4ulu34VKRDmoYUV3wQ+KM6Bb+YGbGMMX6CfMSYZemVFftYEXUEoNZjT0cFidOZGQ==", "bff3645f-ddd9-4bcd-b06c-2662f1d6c36e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a5dea1a-0fd4-442c-85dc-514cf0919339", "AQAAAAEAACcQAAAAEPz9LiRGr7JbYZxRhlb+YfGSC2bzwO1fejgIPVJaCunpMGK6vIOQwElhiOW0cyypQQ==", "b5895971-cc95-4a59-817b-b7b03d4dbce2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f9af132-bafc-4a7d-b219-60b15f576fcc", "AQAAAAEAACcQAAAAEEnwKgyvAgHltg251SfJ/sSncXkD58aNCtLwYdKzJAY1LxyVUN0PW/tjmQ4qLm38Jg==", "e4920835-78c2-4f1f-bc5a-7690b8cb9d3b" });

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerRating_AspNetUsers_FreelancerId",
                table: "FreelancerRating",
                column: "FreelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
