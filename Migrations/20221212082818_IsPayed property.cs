using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class IsPayedproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPayed",
                table: "Assignments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "8bc50d3f-f21b-4494-aa24-ec5f04a2f89f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "14f5f6f4-1b78-4fad-bec3-9ef1cad2724c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "d1af217a-c6ac-4337-8160-c40408466d4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "8ed34d3a-f218-49ce-b534-a79d530de6b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "4f9d68f1-b04b-4c2f-85db-d47b840d2bc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b13745-d50b-457a-af11-37ff7bcc711b", "AQAAAAEAACcQAAAAEOraKiMZBfkVmKLCJzSQ/Hoc7yhKDynY8HGq0F1zqYT8i71kHayJBXg6az1x5NPwUg==", "3f506fbb-d247-4877-a2b1-e44fb170b89e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2250527-26be-46df-a960-f9007f709550", "AQAAAAEAACcQAAAAEIPHfpmHHYP4UrGfELPyfrCReCerQYcOZmSyoUffWJEg7CRp/ptd599u+eGOiPgrcg==", "76965a24-46d0-4aca-9a24-dce0d93304ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fe63d50-7624-45e8-8a01-ef0abcf0a363", "AQAAAAEAACcQAAAAEEJ77ciYVoT4ZriXn5zV3SIsJYAnVTbCyksedJ2wrL6k3SZ32l77W0I83bO8D4LW5g==", "74b6a671-d1ff-4310-9fc6-af8d19727a6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cfd7f1a-21fb-4edd-b7e6-287c4f7daa91", "AQAAAAEAACcQAAAAEN37bPblntC9vbyqykGyNOqB92Nbk1vYR+Amx3V2rvkTZMQyjFO880V3HoulSIKS5Q==", "4420ac7d-4e3a-4ec4-8471-8d4dbd0b4d05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00e252b3-2191-4a1d-b576-4eea5dccb44a", "AQAAAAEAACcQAAAAEAPtD9QhFvgqD2mxEjf87EuQBFsPIHSZPydgHDKYKEq2xlDksAYSepQ8PfNQx6BJrQ==", "78c9c5e8-3737-4fed-a95d-284a3b272713" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d322b29-b30d-4133-9f5c-422aa9613fd5", "AQAAAAEAACcQAAAAEH7YezNr+XnBwScm0cyu0cP/CoMikbN1HP+KwOX1w1+b6h+7Res7WXVaHXKycK5wLg==", "21c92e75-f002-4ea0-8d2e-959158e76f76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "035570b3-d340-4c11-9e3c-9e8ef309ce0e", "AQAAAAEAACcQAAAAEJfORoVjL00MADYrrkJWMf0RnnCUeC/60zq8YuEQ991HUdfylI+2zEDoObICkXB0og==", "fe3b1262-b859-4a14-bcaf-e7b664e50d4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0a937ef-62a0-48a1-bef4-113154e7ef3d", "AQAAAAEAACcQAAAAEOh/YYv1fEbLxvuuJ3qRY9Q3p9GeFSZZT5+ybESisbFHqhaA51Kf18HO1za66bnX/Q==", "3b059a1e-3f43-4a06-a8db-e2096191e819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e8f1143-d395-4b04-97d8-4030d13b69c0", "AQAAAAEAACcQAAAAEM2i/OuwVZnIoxWZyJM2UsboR0ODmg2Jd/HfnKlrXEW9bhC95roMRgQBiWrxCEKxuA==", "108660fc-f35a-46cf-a13d-fb5d3adbe5ba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPayed",
                table: "Assignments");

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
        }
    }
}
