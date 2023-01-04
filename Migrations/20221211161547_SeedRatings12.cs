using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class SeedRatings12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScoreValue",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "3479ac67-71d8-4309-bc44-f59a7764cddd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "3f4d5f14-1385-4b02-9edf-a31636bfd7f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "739f2987-a4d5-4d41-b330-e02767c3238b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "298217d7-fe55-461f-a0ef-a842a3c6db67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "f417c3c4-d74c-46cc-87e5-8c08ac74aff4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f8c90b5-dbf9-4a4f-a309-bb802a5a443b", "AQAAAAEAACcQAAAAEBPY7uCqCLTK1jwtU5uzx+d3jgNxWt8wXZhwNAQk76BpqcYAfZWjXzfA9cRDFvwobg==", "1cc8df24-b2c1-40ad-a054-71870dff9a3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dd256e2-8554-4714-89c3-30c4292205f1", "AQAAAAEAACcQAAAAEO0s5lGuWLYOcCWmNwGoum7T66rgKaKFpde21Lr0mqkG6PJ0dVbhgdTMg2ekN81h8g==", "251ebdbe-781e-4c33-99e7-0bb05213ffde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "404b9340-81f9-4d29-88c9-2b8de255b5eb", "AQAAAAEAACcQAAAAEMWM2axFowDKECb9+W0//xr44A3GEhHWOucFZX1b37n9X+fk+bapMHhJQVrUS/j1lA==", "e39faf21-ffdd-4cda-846f-0510a5a86e65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b855d824-cbc7-4f09-b1a7-629f311f570b", "AQAAAAEAACcQAAAAEAZJPuL/0RSClCC9/wvPmLNy6eT5ete9EgxVboaw/WAPbtbpjAzNl8mzeD0r+Lb/0A==", "3b3b2fe1-40f2-41b7-af2d-42239eb07ee0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "377173ca-ee88-490f-9b8f-b872295c6c95", "AQAAAAEAACcQAAAAEH1i7R0LZS8gUi8TGjfRvfQ2AXOm/CNZNmopgPpLfdSnmDTIhayQd1RaQ/Pk5EIGaQ==", "3b8cd4cc-a836-4473-a8d7-fbc112503c3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91efad26-6a66-449f-a2fa-18dbf5b757e9", "AQAAAAEAACcQAAAAEHgzmH65JmTx4gmKFQJaw9RdKaOGcv1WrI1e9Jazm2da1xgKgbumVNDYDpibdszKqA==", "fbf333a6-de18-449b-90a5-6c6f868311fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2498b5a0-ce78-4d16-99ff-4634248d28f4", "AQAAAAEAACcQAAAAEL/QB0W5KPcOfB5RSNA6BE4TFHhaAI4VTSp1/0/jvsPpKfW6tmXGUs4mRk5TGeDiOg==", "bc786d60-dcad-44bf-9d6d-8a336acd51ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb9c00c-ca56-49e5-b7f1-0e635e9af6fc", "AQAAAAEAACcQAAAAEA0NAmHMvRLW1/DosnkSJtcpKXLhuUDs7hRuxvs3eRYuMB799YsXzn4R27StrRgovw==", "953c404c-4d8d-40f3-be93-054b455921c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eab61fbc-53bf-406b-90e7-6873bb9a9a71", "AQAAAAEAACcQAAAAEMzFPm6skCr1bINGIVyjYBZPCjSaXo2c4iOs6anwEWJjt8gcSjkV8ltQFtIz8G1Hbg==", "675b7c1a-ef40-498d-9f64-dd49b8696d11" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScoreValue",
                table: "Scores");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "13522354-08df-4d9d-b5f3-6dc42e74f916");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "14de4b2d-237d-4a7c-80ce-ae8c7adda48b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "66af9928-a2cf-45d2-b3a0-c93b9b209689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "227b1c27-5a3b-4e8f-ad82-ad97ac3cc0af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "c9521482-2c57-447a-bb05-122e9d1573d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9b30f7-7b64-4279-b6e3-0194a8fd9927", "AQAAAAEAACcQAAAAEDISH14miAqz6GSyKZZil7dhHKi7bYHg1dhfuYqDgo1ka9+mSASOYIFW6ifUhtYPYQ==", "a49e0836-45e5-4d54-bd30-56ba3fd1ac08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9084d97-22c2-4188-9709-88775b401908", "AQAAAAEAACcQAAAAEDmiDGTUnxWjOorWRCXTmWM0pTmGj4H0HCcLkSfPkBfdWTIgKR7us4PSMjqdBzPe6A==", "d32874dd-544b-4e93-89dd-884b0544a43f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6472c3c3-34e8-4413-ae3d-45050b035f8f", "AQAAAAEAACcQAAAAELeku6E9Zca+e4ksS8v7XBQfMvM+59B5sFjjN2DEwigt4oLiPb0xm+zF+r2D4Og7/w==", "825112d2-0212-411c-a1eb-98f93044f57d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63be62f1-95b9-487d-ad53-a3b13be57f91", "AQAAAAEAACcQAAAAEJdY7RqJrjKh+8GmDuTqQRiz3Ajw7PB5gBMj81MuzHHnUyG8MoWb2x5IJ9f2bOFkRQ==", "84791fc1-9537-4b85-be06-b9a4ca18e9f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "113530ae-dbff-465e-85b1-805fc51d0ea0", "AQAAAAEAACcQAAAAEPVXW3XG41gqrPh80uXdJ1YslS4gn17G1Bn98+fD3KULyua8moWNd8X3QsDR0ZPiVw==", "e06626bf-502b-496c-91a3-48fa7049c00e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3798b8ba-e527-4501-8f41-7386796ef798", "AQAAAAEAACcQAAAAEKPhYhtZyLPUkaX0mHhMtXo2shms+VX1an5+zOYHHVLiWgdHrD3z5f2aTZyl0fpSFw==", "32bcdd5a-4c86-4067-b987-ebd5cfc70795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4b53c9-199c-4043-9407-68b952effef4", "AQAAAAEAACcQAAAAEETRlZDgrAlftWjb4pOSpNz02bv4KQNkYEoHPnyB/Wlx0X6B2oIKWMf25FV71hN1GA==", "cdaad540-c02b-41ec-9379-009e4b5a5836" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d4e2049-d901-4e0d-935b-6a3e195e4ff7", "AQAAAAEAACcQAAAAEC30woe9Mxh+QNfNWVFFYLbAd8FG8AR4zU28YMyOEEEmmvja91m8RrV+tzv3vXrQtA==", "d1f7a9aa-81e8-411f-a40a-aab7ee26f77d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61287f08-0d03-47cf-989a-2a6839a6e753", "AQAAAAEAACcQAAAAEAGgLmqSmZ6exidkcmqmip/kQqybxR4Pej5Gcz2qv2REr9P031Luf4Yb076OdZR96g==", "7fb9e2e2-0e47-454d-8cf0-e09fa10fe067" });
        }
    }
}
