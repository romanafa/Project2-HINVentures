using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class SeedFreelancersWithScores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimesRated",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalRating",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "cd247746-17e6-4809-8e98-ee328359a2a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "5f206b3f-17a2-43f5-ac8f-976248488e83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "25a80989-b11c-4955-a87d-bbe7d03a8efc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "d935fb44-bd7c-4b79-86ef-c4541cc95d70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "51f38451-c0c2-4393-b44b-0b4b10410085");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "009ae9fd-6bf5-4387-8144-7dc78ac3b446", "AQAAAAEAACcQAAAAEKI63YkjWvFUkm2wGF/aJh4BsSorVxgULGwJuFCakihM6Qfl/IWjN5f1FIVP9Bw1lQ==", "98a63af7-77d0-4af5-a0f8-ab1995bd2324" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2e960d3-aa86-4885-98fa-738996e66bb3", "AQAAAAEAACcQAAAAENn4KAPp1xlP3w7zEQxVdBiAbtFqu2Vp7gGzO+QZ0dWmZszpLnrjUak5btXEIDRHOA==", "b803f242-97d5-4e56-8ffa-ab8b5dc9964c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8130aaf-708a-4dd8-96cd-bd1b21c3102a", "AQAAAAEAACcQAAAAEEQJ5HiLSIvkG7lV4ARvMjXKaZY0F1hOXo9j9NEId6ZdomT1q0hm3ESG8qRAJtFthQ==", "6ac93bcc-e850-43e0-885c-6ca6a41649f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9725caa4-3d66-4ad2-8f4b-570fe71bcfb9", "AQAAAAEAACcQAAAAEIZAkOSHnjQOqW8x6bTbjP5LxRUPxLyBb278Mpx4fXvfrDp8+Pouh0pPvWVzHHTxVg==", "f834a4bb-5e2c-4279-9396-e0f43003fc36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "686d5961-5ad0-43d0-aa8d-91c43f26fad1", "AQAAAAEAACcQAAAAEDVOUDjqKlZ0bl9y5MV/hVMdUDplqan2r4nGST4dOk85HZ2SWX4eo8SP4/+ZhSL5zw==", "5cd8791c-a08c-492c-8595-75f48314bf10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d7236a-cfd7-4b03-85d7-bee774611d48", "AQAAAAEAACcQAAAAEAjs1z3xYFE4GOxtiyib4sJvW7xDA94v8WuVmp1weE76gb7VcyD9q8UudzZVod3bmg==", "1dac1c2e-b7ea-48b5-a3c5-941954c69216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b0f4eb-f906-4778-8e57-4f472a50bc6b", "AQAAAAEAACcQAAAAEASnDKC19dl1AC/CR/4xQmb17aYcKSMBsIQ3GQKzqL7VFKOjzuSmaSubb4hZl/7aAw==", "ced5f8a3-b057-49ac-834d-58b3f22c612e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "053fc996-048e-495f-a55f-76b5796ac43f", "AQAAAAEAACcQAAAAEMAuRGDQ9UcIPd0z+Eh7zwgvM96hjnyAuOdCtWokGCAl/fRDmH2zOCKWWaSBzITVqw==", "258838e1-f3cf-4127-bbc4-f9513121b331" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1cd7bfa-ebe5-48da-bc32-d7102544a60f", "AQAAAAEAACcQAAAAEFdzZYQl4dD4Eq1mb/OGbOVE6jRNBBmzNB2jQD7j7M3EOqch5daSJo7zP0cRA6uqWw==", "3d50304b-2ce4-4f8d-91ef-125b5198a237" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimesRated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalRating",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "40b5e71d-d410-489a-9d19-17c1d47d2a39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "eb1152e5-e0e0-4461-8e27-b7fad79882b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "0c3c3924-acb7-4ce5-8320-b992db240bb0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "86292841-17db-4cf5-a5a4-bcfd61cca933");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "9470051b-1ccc-4dfc-b6db-eb69ff2978c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70dd04cb-1a79-4626-9341-7a6b9509d0ea", "AQAAAAEAACcQAAAAEOhkeoZFIJPzlNseDpXu84yvrYs3KL7PB4BG1VU5K0sP9MLYhZhzgMCSxkDMd740Cw==", "10e80817-edc5-4f9b-a1ba-545534f532f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "090de9f8-54a8-4b13-b057-0e88b5ebd58c", "AQAAAAEAACcQAAAAECnWWooApEr1sypZTfciiZExhCiGkcGPbvWOPrNqrHLxsX2mOELgAJ/eLbFgUCs4vw==", "4f2d6f23-9b7a-4590-9842-7fa793769f37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a09d7f6-1e05-4004-9bd0-0cae71acaf6c", "AQAAAAEAACcQAAAAEG/XSpwDBvdC7wpvuDq4y3eUl4nNw8L5I6IZrfOQuZvLzfQGUsQwsmarJ9q1tnmhXA==", "b066d45d-634d-4dc3-b0d0-4672cb51bdf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e50b22-598f-4366-bda6-0ee2dd22f04c", "AQAAAAEAACcQAAAAEH1Re40+u+VkJeZqC7fgDazyiXv2WmRJVGbULaZAUNSvmdoimcBhpN2JTxrnyAMAiQ==", "ed818513-c1d9-4de5-a092-524e4e596cd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "211f2acd-00e5-4b28-b09f-a4b6e0cbe8ce", "AQAAAAEAACcQAAAAEDt/c6eFRTiFi9Xt976o/rRGKJCPk0g7s0UpejfPymAIfmfHpDrk1spolMM3WufJUA==", "99c08842-79f3-4b25-bf1c-893e77f92827" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5db6a5a-c083-4ab4-930f-c6fc2f2d68d4", "AQAAAAEAACcQAAAAEOAxamUN8VBKaLCHMSTHXONL+J9Ro1KP+24E38JhgQniObSy51YWlU8HFXDtUfzLyw==", "a53e96c6-fda7-4f22-a9b8-efebb91ffaf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "446eb911-2975-4bb6-937d-1082bd3ee173", "AQAAAAEAACcQAAAAEJpQIe5tYB0bgU/SUlBPkEHZMdyD1SYss4/jTVKpnfjE81d36OpLL0/Gk2D4hOoH/g==", "e5731e9b-2419-4be6-9156-90e8d1470ee2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bf168ee-eb4d-4c5c-9cc1-2a0e9a6afaee", "AQAAAAEAACcQAAAAELx2k/ydl6DgMfh1owEoRXMTLSf3Rpijt0JU+BHofZVQIKa6yAYr0ooNtqmcGmb8/Q==", "3998f56a-91d7-4454-a21b-5b7d5cb0a5ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61537223-73d0-4569-bac8-8a7c282aa30c", "AQAAAAEAACcQAAAAEKEXuhtIpcH3dQv3RQ/kGx49H0ddz8veKOR/xJLGdkmvnTQp+yUyb2Sm7M775rxfow==", "1e264d83-a277-45cb-8067-28f4047b2fd5" });
        }
    }
}
