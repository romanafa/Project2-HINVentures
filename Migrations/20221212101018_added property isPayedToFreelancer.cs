using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedpropertyisPayedToFreelancer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPayedToFreelancer",
                table: "Assignments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "aa216f64-0d4b-4681-93ab-443e94e14eb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "6b106464-070b-43db-89b9-bc6a34193586");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "b34372e3-4562-4c95-bc44-a10cc004158c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "7dfca945-28f9-4fd0-b710-82eb8328a826");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "8bd9a5a2-ff9f-40a0-8089-c04cc19f0711");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7759de8-b979-4688-aa12-21d0bd70c7f9", "AQAAAAEAACcQAAAAEHPPeG3DefVwnwNQJizxruV31olEdH1bcdDSGEJi0Ui1lXGu3p08jvj0eCjquYeRDg==", "47784004-8f4a-46fd-a10a-a42d5f68caf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a42c599a-ecdf-460f-9a0f-2ebdce9cd7c7", "AQAAAAEAACcQAAAAEGK0jbKcjSBFVRRVPmxWppNU4kmVA26/jfRTB0dh7/V5nCAs9JWq1zOl195ltF6JTA==", "3b035cbb-df29-478b-8955-f6982bd0aea8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6400115-793a-4bf6-8a08-3c1a15ff530d", "AQAAAAEAACcQAAAAELJL8mZvsLHsOsIEzNla6oKglYLtQrciUHj7+oUfAPsPUAs1RFvhWtg+GQ/k2JjcqQ==", "8ad5ff8e-9a5c-4d67-b731-8291a4df7049" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cb5df9b-0811-4c44-bcec-ef9f593e5637", "AQAAAAEAACcQAAAAEPksVHC0Kg7ch+tImHCKrCibAt+G3wNn68tRfWSG6IFhG0GD9K2p9voO2uDQbW4hTg==", "97b0d1aa-cf46-4a15-94ab-653438c5a67a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61332e8-4b8c-4121-854f-bb762011874e", "AQAAAAEAACcQAAAAEAK5bMobgV3hrc/lSGRKunWWpXUI0b1WCu9br5EdBMK7VCPlBbKizoQ+8NzOO7ylPw==", "bb325ca4-9300-4fbc-98d1-01422fba3ca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "611a1d53-4b3f-4f5e-a652-61605934416c", "AQAAAAEAACcQAAAAEMZeyJyRqbrGDGIn1+tLx2gAW6HxQOLbeRBPzhshRJZA+oJxLc/P7flXpGVRWe42lg==", "cf3b5d6e-7f78-4056-b74c-a1ad1214d688" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7947165-6749-4fe4-bec3-66ad5fb3d059", "AQAAAAEAACcQAAAAEHE/aH+xZhMDv2PMehCg/34LiF7d3Ab5tb/ZBIpCsyk28dj5UQXVWufZ6GeqkWq1tw==", "a2674051-7859-41e9-9193-b837980d5632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b6e73a1-b475-426e-af1c-12e4ff6455f4", "AQAAAAEAACcQAAAAEKtb9IhYL5/L1Xod2pIdpMBsLJdzNjpSgcGrW59P3E7Ks8SQfU0v6GGg+yp/iN5G1A==", "54b03c6f-2580-4223-8bbb-b36022591ce8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "911580be-b68b-43dd-a449-b0ce54b6a583", "AQAAAAEAACcQAAAAEHJENLdqSTCbAXq2BBzyObUf5+t/U+Ec2X6kxrB5GXSpgZ8tpisQ0J4mGTg63AOmQg==", "f9990a93-7a47-44b7-a0c5-ce5ab403d7dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPayedToFreelancer",
                table: "Assignments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "6f42f40a-44f7-4004-ba4f-44935b549ec8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "9140d3b9-2571-466f-b301-71a3c64ae6bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "f10fb435-ebe8-4acd-a4b9-b9d40e933d65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "d8728600-dfca-4879-ac19-54a62bcc7cf0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "bfcdbe60-3fc2-4788-8355-4640e2e19784");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1daa7526-981d-426e-9442-006d5b4713da", "AQAAAAEAACcQAAAAEHhEyMe0Bs8zwEBoDG8SUx63XOo1mI/GPzIfkzJfpuD05TZkhc0A81mnlyrpzC8DKw==", "99d23c93-08fa-4777-ac4a-8aaadeb8b6eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ffbac9c-6574-4ed8-ad07-da8c1b57616d", "AQAAAAEAACcQAAAAELySKGmYZMqqnKmvk00BSWKy7+IRTV1sLUYAdG4K+StVicFVjB+WvPKUX2rOAcxV/w==", "2d4f6d4c-26e7-46f3-a34e-d1b0b799d5a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a982355-71ff-4031-8a66-03ebfe845db9", "AQAAAAEAACcQAAAAEDLLZ++uByAv5L2CCH6iyu0RRxvjHQR1Ll9F9nREu2ZqkusIbtGN6kcl+KgiShR39g==", "b528fa78-2e15-4a8b-a65e-66012b807f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95753225-3a46-4dff-b7ed-e01d53873e17", "AQAAAAEAACcQAAAAEFtZiZ7wDe21k8PMt3GU5XqNO3VGiAZjCqDRWfJd+XgULsvYPpWKo46fs344FmCZ0w==", "e8efbbfa-85ed-48f1-9892-edd707783827" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3aec35b-7b49-4613-900c-127fceffca02", "AQAAAAEAACcQAAAAEL07UYF55TrsTolsAGVrnqJy0XXPPZ5Z3sHp1Jv+bdQJOcPlbKD4C/GwTv/hVtBlVw==", "47ef42ad-c3cb-44b2-ac95-7fe589bd1991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6c945f9-7a73-4bad-9321-e416c34e1a77", "AQAAAAEAACcQAAAAEFne9FVsi6lhucOGO0P8nPKnidvkTaeGEsUWLqwC3QlbH3ZOORr445QY5a6GGmanzg==", "4938d247-4439-4ada-be09-bc518f0b6838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5cecdf3-cedb-4480-aa01-b5ef418f2d91", "AQAAAAEAACcQAAAAEM8AD3UfRq76l/3R4Vw0je9QQn0X+42zbrT/vVJdKKiIbRkzY6VHaaHCZoOvEt0opA==", "b59df9cf-64b9-4084-bcbb-b89039aacf9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53a27c81-aea5-4d72-89c9-d71267a3d634", "AQAAAAEAACcQAAAAEAZSE2469r90LX0FAQr1PwtjKQ+T95Ps5htz0i7KDpjgf0DAsom55gm6aR27Kkut6A==", "7c1b9d53-d3b3-48cd-8e4a-2c4fe3f56a55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47cef569-2633-4adf-9703-5b724d4cb363", "AQAAAAEAACcQAAAAEJmf34M6QyrTl9UQS/jKGj8427fGNdzwGGcSJbFVKLNJ0PUkSYuvZCvCWu3SrehwwA==", "3b845be2-3bb7-43f7-ab76-ac7476ce3dd1" });
        }
    }
}
