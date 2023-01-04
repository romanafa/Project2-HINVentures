using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class DatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscriber",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FreelancerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FreelancerRating",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingValue = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreelancerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerRating", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_FreelancerRating_AspNetUsers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.SpecialityId);
                });

            migrationBuilder.CreateTable(
                name: "SubmittedCodes",
                columns: table => new
                {
                    CodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmittedCodes", x => x.CodeId);
                    table.ForeignKey(
                        name: "FK_SubmittedCodes_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerSpeciality",
                columns: table => new
                {
                    FreelancersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecialitiesSpecialityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerSpeciality", x => new { x.FreelancersId, x.SpecialitiesSpecialityId });
                    table.ForeignKey(
                        name: "FK_FreelancerSpeciality_AspNetUsers_FreelancersId",
                        column: x => x.FreelancersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerSpeciality_Specialities_SpecialitiesSpecialityId",
                        column: x => x.SpecialitiesSpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "SpecialityId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_CustomerId",
                table: "Assignments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_FreelancerId",
                table: "Assignments",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerRating_FreelancerId",
                table: "FreelancerRating",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerSpeciality_SpecialitiesSpecialityId",
                table: "FreelancerSpeciality",
                column: "SpecialitiesSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmittedCodes_AssignmentId",
                table: "SubmittedCodes",
                column: "AssignmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreelancerRating");

            migrationBuilder.DropTable(
                name: "FreelancerSpeciality");

            migrationBuilder.DropTable(
                name: "SubmittedCodes");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropColumn(
                name: "IsSubscriber",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "9790ccb0-ec21-49a3-86fe-4deeebdbdade");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "1cdf9ad9-793b-4e82-9b84-656cfbaeb1fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "41ea2b72-a4d7-4691-b537-6f518b0977bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "abd9734c-c78c-4cc7-8b3b-59bb4e32323f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "48d00cba-ea21-4794-b4e5-9eaeb61a0ed7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6c7358-6dea-434c-8c16-f762a5db6289",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c772448c-0623-4197-bf38-3bc169d97fae", "AQAAAAEAACcQAAAAEAiUblYok4jdhIcsqtLz0p1Y3+CO4piVZCXgsKmbl60ROop0UJDdUohSXXJR6dbRXw==", "c199c0ae-08dd-452a-bef5-60ae10b5a9a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fb2ad1b-2c0e-48fb-9512-8bb30b40c749", "AQAAAAEAACcQAAAAEDRMwkhRb7GH7L2j9hYU9+v4uhBB3NtmFfIsSc4jc9SgMdhdi5On58Ty0wmgBP9LRw==", "59442825-6ada-41ee-ad06-6e6fd94643b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c06dca6-62f4-457d-a242-93fc2dcda786", "AQAAAAEAACcQAAAAEPOXjPyp/AXD68UXMOf1OvB12/7aBlPdfFwlU6Ai5vpMSU3pi68x4W9HTR0XzeosqQ==", "21469fcd-eb4b-4128-a433-2c9a970fc72e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c99f9f98-1016-434a-912f-6f6bbaa08403", "AQAAAAEAACcQAAAAEHRKT7dGthAH788lP30isvaIj9U+D07KeWt5hGBmi4GdW93Ec5bG4Ez4IqCSSi/yww==", "6b5bec2d-b313-4865-8cde-1f0825c063ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bd4db92-b32e-4d82-8bdf-11e233e70bac", "AQAAAAEAACcQAAAAECP7VfeVPjd1rszygPcBCU6imn/EjW9Z869W1LW5V+1yG1zMvaGq+ZSf11KuH0uokQ==", "d1bbf439-8e4d-4bed-92c6-e64eee6e43a1" });
        }
    }
}
