using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedpropertiesfreelancernameandcustomername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreelancerName",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "0a855e54-8f61-4235-bcfb-6d5ba05d8ca0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "b15c6751-4144-4379-9587-4c62569bd72d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "5e89e855-42c1-4276-808b-fa0d70a6b2ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "9820685a-9dae-46f5-a86e-c75c977c4d73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "12641ef2-c547-4f39-8755-0a0a7dd2c4d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb50c64-37d5-49ac-85f8-3c4263664cd7", "AQAAAAEAACcQAAAAEMVtltarA5I4xioE7knql+VzvhZfCvWDj68u9nlQlnoPKP8ydHf3Ue4wQSPs5hf5lg==", "4667e5eb-3b19-4e1e-9a8f-83509b7f0dd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "785312d7-e55f-4520-a6cb-e4fcce8d3e10", "AQAAAAEAACcQAAAAEHd1+RrNizn0Mr9xnSX7Mp8dgeVi5edpdS+4pryoUuagWoJlS+JoBdek8Jus56G8QA==", "ef3e8964-bf02-4377-b735-0c08a4a04d76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2832e17a-200f-47dd-9d65-c0edfdce456b", "AQAAAAEAACcQAAAAEHndCtKhxepNY7ZUaRtiCpZSWEtVD/Ihp5MgZZtBx6Zo/EdZwkMuMBYdcQ30oyMVdw==", "f5970d5b-121a-47fd-b8b4-1df7ddf54ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e6a656f-0d37-42ca-ad77-9eca9e4ed812", "AQAAAAEAACcQAAAAEDBjHMKvt3I4I3oXl38auiR6fi3JrlTaG+sGm+nMI2i4wFglKpQGuppiRO5MTIjUuQ==", "82fb983f-1b6b-478a-b0e5-7229ef365648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18d67b94-5f48-4770-a705-dd8cea6b448a", "AQAAAAEAACcQAAAAEMS16GLkDOuFtoiefZvYXFUJ6ajO65w3j61AiZUajkZj/obTB1XiDjU4btezjA7dyA==", "4da3c00f-9274-4c2e-8b6b-08ccf68850f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dce0a89-42fe-49d8-9ac2-0b365c8ce8ed", "AQAAAAEAACcQAAAAEGUG7rNCEA1cgmDNxuplBLF25Aw3dM0YeP1sFJALsP3WZ5xDsq5JxZ4ctxfjA0aUQg==", "da0a7ccb-a8f4-43f4-aa04-6a0c0bbefad7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324a3925-af3c-4104-a349-ae4bf32944eb", "AQAAAAEAACcQAAAAEAhpqwNAd/KX7heU77elS5zaUhT5VqRvn7hMZFKv72xxCysMICYiutW95kwRJkA7JA==", "ca9b4247-8276-4056-b609-a2e93246e99b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e7f039-01b5-43ee-bc5e-53c85818aa82", "AQAAAAEAACcQAAAAEKcGhdTdW6C8RNYrv3r2N7lv+HZQS4PcE6GbDAFqE5KtpTUOd+pMrtU1etYeg9l+wA==", "c680f441-ffa0-48c7-bb0d-1ae463434972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a21dd6-69bb-4f9f-bdeb-044a6e1c574c", "AQAAAAEAACcQAAAAEBGoyKrGCwRIBgJcoqxOtPKDbYsmZH63N18NKve8CBIvZI3Rfqe1wnOBM0lKPPhiww==", "8e36f119-9bf0-4d09-b6e8-40fdd94be3e9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "FreelancerName",
                table: "Assignments");

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
    }
}
