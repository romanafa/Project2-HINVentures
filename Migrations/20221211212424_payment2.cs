using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class payment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreelancerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "47ba54ea-00cb-4160-ab5e-83b896cbc6a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "fb4fb9c8-8ac5-4e8d-9de1-e4d28f6bab13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "01262518-f44b-4722-a7e7-1312f994192a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "7932842f-10ed-4c63-a486-7f849a8809b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "c5c8276c-5259-486e-ac7d-c7064bdc1850");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1074f785-d454-4af6-9984-f5bf43173d79", "AQAAAAEAACcQAAAAEFDzu3FRdLWhZWUycWPsPME/5V+I8h7ORtQidDJB0F2zw2Fy6CXrgzNlcbTd5P32Ag==", "5c7de0a1-5af5-4be9-851b-9b371156aaff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896f4d25-e54b-49e7-be32-82520cd21e2e", "AQAAAAEAACcQAAAAEIMlxx703xA+jt2mJr30rNcF8WKdC6rVBsCc2pFYVf4qzGj+mncQtsj9xAyZDRWFWQ==", "efa19610-28b5-4a2c-8564-c675befe7a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c52944-d11d-4b5b-9ab1-4ac60bb1b3b9", "AQAAAAEAACcQAAAAECOffhfXqUpJRm+Z8oucQHLYtX7gbFrNj84wxLB9PqpABEm07SdAfVfrpxdxb5X6+w==", "a54e2f88-9388-44bc-838f-625a379245f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d3d8c8f-3f4a-47ed-b1b6-ce18ea08ede4", "AQAAAAEAACcQAAAAEF/ZsywB2fbjyR7X19tZaE+Q9+2U4MiO7K6gjQNe4GqWkLcCUiiFh+OfJOz5F5D+Sg==", "f0bb130c-386b-4435-8260-52841a39ddf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed0e0b90-2e5c-4247-a6a2-95015ce660e2", "AQAAAAEAACcQAAAAEE/FLSZHvEFk/u7ikLle6OQNBCUCz632wxlJ/vxNP1WYca3Q6ywrkF9GOm5k3hRY9A==", "9f8519e5-edbd-4c43-9979-bb504650c8d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc0d4c44-a93c-4877-bd35-191c8b7626d3", "AQAAAAEAACcQAAAAEKO3kSINbePJZ/HNMQAJ0uj0s9enaGlZ25CcgfdZZLoeYnz2sJWrPgn+YETRyH1ePA==", "74977f50-412e-42de-8361-44ea6dc29a9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d17deb-9bb4-480f-91c8-1a9b56e718c4", "AQAAAAEAACcQAAAAEHvfvjw0ffyeBZ8UWPKnLjHBeX+0NRSszbIW53NoNdA9epLAFDSSQv/f4MrhgxZnJQ==", "5d36aed0-4b48-406c-a9e3-16f0095e6a93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1116506c-b4e4-4ee3-a5fe-df8e675e5f57", "AQAAAAEAACcQAAAAELNsfYT6U5RrgkGFDQKn+NgpiIDc6Fl3DYX2O/gXjJszVs3AIAMq725lh52Ffp99Nw==", "89fd8cad-e17d-459c-abb7-fffb3e0bb8c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d24edca3-a19c-4c3f-9af3-130b739e2cc8", "AQAAAAEAACcQAAAAEMeXN+Yx/6N7pqRg9BSLFFkAtZLm/X+Quc/bC9RbTrJhX1Of2mnLzmxX7eaGUgrN4w==", "35abea3b-cd61-437f-9de8-0eb52c1394bb" });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AssignmentId",
                table: "Payments",
                column: "AssignmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "b24a35d1-7a35-4466-a7b4-fd5cbc70b1fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "ca865acd-fe46-46d7-a714-4d6d8c6898a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "9b320ca6-7075-494f-aadd-28ccdfff6a4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "2733847f-1f86-443b-96db-cf1fa3a5c9c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "a3d50bd8-f34c-4c05-a18a-88ecafed7d41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f08181b-ac2f-4766-8ef7-ca20258e6999", "AQAAAAEAACcQAAAAEOQF/mVGL3Jlxl8P9GRYt6wuCnwJ13MkKYVEVjESFm5eeRaMHo9Rfo4e13URm8eNLw==", "c66bc518-8447-451b-840b-ee6291b54ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db7dc889-e24b-4cc9-8032-d0125607ca09", "AQAAAAEAACcQAAAAEBmbqo0cvjV90zLjOJ5Etzky1cxEtOxaBXBSm8J07joXJA1AJAOdaC3ihS2FXbPLqg==", "83fb2ff3-0cce-4e0e-9e17-5f07a673b8be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "412af365-52d9-49b1-bbcd-b4655d2ab78b", "AQAAAAEAACcQAAAAEKnbl023PzCE+9PoEwU/kQ3fz9Rt96/iMFrFfOyWatsO9zElB65bCziliN1mqEX+jg==", "92ab9c6c-62cf-4a18-9564-2b91770a51e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b0bc80-5ee8-4f22-9df3-03e449397cdb", "AQAAAAEAACcQAAAAEPMV/6TBHsjZTmNXQve7Bl3rEENgpdb26oPku3wP/1wMBnuL1S5QSwY6Hw5HU5depQ==", "3ebed0cf-b214-4a48-b1c4-41e32eb4b349" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0178fca9-2b54-42a4-9602-57af53307031", "AQAAAAEAACcQAAAAEGD8n5DOn786Nwh9VeNTaG1oltCC8HqdgFSvlD7++SUpKbOWJMmmLn5K6py84Pbsaw==", "13ce88fd-98d3-4a16-bd7d-b5f546bda14f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f027f740-9d69-4a7f-8a94-f31d9a2d05e5", "AQAAAAEAACcQAAAAEBYo8ySwdFmJ/dM0FxKIbiaZ4NnfdNND99WfWwJjYkpWqdeMbeJsdPp0yCNgDaKbag==", "1a06dc35-ca68-4581-86eb-6cbed464c26b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f6c6ae4-a463-4331-baf2-e1dcece27c15", "AQAAAAEAACcQAAAAEBHU6mgBhd/EzSM0047/1nLsZu9fqXGesAkFOJCGR1JnMWSHgGPXeJ+syVdHGGaopw==", "61219245-630b-4138-be3f-23ede955ff9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3232030-e9f3-47c4-8596-444ffcad787d", "AQAAAAEAACcQAAAAEPBVsXbYVyDloI3qnCOUqkRyfnGIwkzhsIC1rAQiAkqaMIJUbtLSqnIrEXmcMBpI7Q==", "f63817f4-4b06-4139-8d8f-ac10427ba511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f147e271-4274-4106-a9c8-e5f692c28cbf", "AQAAAAEAACcQAAAAEIinaGykiYsJaZj3wj34djivu1wsz15vy94GOv1SqP8Yk6oRN3mtYN9S/nm9FlTTwg==", "8b5b0d4e-aea9-4b45-ad37-6cf787002b50" });
        }
    }
}
