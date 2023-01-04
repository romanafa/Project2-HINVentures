using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedspecialitiestoassignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignmentSpeciality",
                columns: table => new
                {
                    AssignmentsAssignmentId = table.Column<int>(type: "int", nullable: false),
                    SpecialitiesSpecialityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentSpeciality", x => new { x.AssignmentsAssignmentId, x.SpecialitiesSpecialityId });
                    table.ForeignKey(
                        name: "FK_AssignmentSpeciality_Assignments_AssignmentsAssignmentId",
                        column: x => x.AssignmentsAssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentSpeciality_Specialities_SpecialitiesSpecialityId",
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
                value: "efe552b5-f5e9-498d-a250-0b24d19a5798");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "cf99db44-478c-400a-9b9e-ad682cbbd684");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "8d282000-628e-4585-9da7-dde12f43a3bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "eb6962f0-08b1-4a6a-8a52-0576f2c23bf1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "98f67c00-e1e7-42d0-b4b9-b90302051635");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56622564-29ec-413b-8f18-51dab4cbc840", "AQAAAAEAACcQAAAAEIegRxS1JuFwXCpKIf8hQzopSbbimsi0DPeMDVXRxNpQ5XiJeVINh/RX72gAxsFdNw==", "89e2136e-1ea6-4732-987c-e18c8b9fd81d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76efc948-b7f2-46e1-8325-41388bdcb1b3", "AQAAAAEAACcQAAAAEJ4sf2dtVF2Ut38sa2FPCMKSpqk2vpi8N4AeCMIk/YuHXUPPt9gybCgM4uF1OJLPxQ==", "00b26765-1790-4287-9706-20e770755bc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8934fbe9-5b71-4334-bd87-77275fce0243", "AQAAAAEAACcQAAAAEJLDrfHz+T4yqHZGrBRuK5SKPHYuz4no6tQq1C1MC77xXKB7Lj3jn0TOmcK2MpcyQg==", "8cb68578-4323-436b-a99f-4a91f1d28ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba90f283-283c-40be-ae3b-1965ac847b73", "AQAAAAEAACcQAAAAEBbFZvTDkoxcuj3Xt4XiGHt4AeRTn1e/JurC8nbzQYy8eVQNfo5aF6rWkhstW//unQ==", "b17655b5-02b9-40cb-bb26-3b6621560f31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92378dae-5f58-4924-bc67-c005b7736968", "AQAAAAEAACcQAAAAEA1FW5WUATxqnEkqWg5seVqQnDdQJUzYWNNLdnxM1svcOaUq1wcLRc7RUMbC+93hmQ==", "9131b848-3a40-4ad0-9d6c-2207b0f49e6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f26c31f7-076a-4fb1-953b-47af73dcfd28", "AQAAAAEAACcQAAAAEClTJ2TOYm6wwvPwHmJ/egwzzUSxBZIagXDVP0AQkbS1m7i535axmAUj3ARXVbCxMQ==", "a6abe28c-fb72-4197-b2c9-6efe2840310e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388f959b-87d0-42bb-9fa9-7da9354fbc5b", "AQAAAAEAACcQAAAAELHXpyDPkf/rIGHzCxJeqgFoc6Yf1bKXhhCLOcJiWnDp/7acpLm2/AZavklJWAGLSQ==", "1cd4fb20-5296-4374-9dce-76434e58fc1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd48294-1337-4557-b57a-93f15586e47e", "AQAAAAEAACcQAAAAEGUoT8baHYUL9W+zlQt/y2m1WgsTGH5Zz0DTZCOudTQh6pXl4ci+wrUJ1SbW/LtVfQ==", "8b2e2610-2337-4e05-b425-75cce26a5394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e4f8aee-b2c1-42d0-9adb-82ec47575a3c", "AQAAAAEAACcQAAAAECexJCHmmb/c6aV+K2fWifYQW7r/DZpaaWyTwFYrU0b7uGdPeH7/6Y3olRbkY3u4WA==", "a3c4d924-afdf-43e8-a31b-30d31b2e368d" });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentSpeciality_SpecialitiesSpecialityId",
                table: "AssignmentSpeciality",
                column: "SpecialitiesSpecialityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentSpeciality");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "d2ef8ff3-2543-402c-b3ad-f477c82f0505");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "7d62cd33-5fd4-4aff-a417-356c67e47e54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "2f47d0f3-2d94-458b-b0a0-d61f1c780c36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "cd02e9e0-ba96-4dd4-b294-2d6ffb7b9c71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "e2ba4756-819f-4a16-bc63-5c4032143318");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca561bf3-7a5e-4088-8ac4-23fc92fa0cd3", "AQAAAAEAACcQAAAAEGJcOO3B31KHyEsoBOfrJnEdnfJfoBoOhPl02IQHKAa7oy7N02xCFMgxovwJQHBmMA==", "16375b0d-27e5-4995-8f52-2215b17288d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89fd9879-8f65-484b-b2a4-34012ff588d4", "AQAAAAEAACcQAAAAEDUlyAlU4IK3ez9RMfNK7Daq/tywaS3zAVoDXUqixgRPQqit1wwRENcnco2v16A61w==", "21a70554-26fe-43f1-8dd3-b860d0ccd3cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfadce8e-2ff9-40e2-a2bc-a355ca3af908", "AQAAAAEAACcQAAAAEBMoH+moJnuOVM2EZSYHbHym4NwCqsV6TiQL8G4VM5Tt+4cmkxYB0w2gWRQdUepIEw==", "4d867a97-edb0-4924-b999-beba34bc152a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffceb5f5-e441-4648-8100-361ac5f27cc8", "AQAAAAEAACcQAAAAEIaAqavbtdTWSsIgiv7eHGNcIWV2bxrpx1EAv64++wbyJrdz2zgh/vgkGlZ0icHTwA==", "e23ab344-8e47-4462-8e80-d1da6949f328" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1669ea12-876b-4198-94bb-594a2109ca95", "AQAAAAEAACcQAAAAEJx8p3Uq8p62yJCEFUbUTOsyWyY62Cj1JnZye+OVszdB78RyyZojmVSHoXKBer+qNw==", "5c5cddd0-c5e4-47fa-b173-3bc013356999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34241b7d-c5e7-4faa-8d18-bf183b431dd4", "AQAAAAEAACcQAAAAEOeB1E2B5V5vDS6UaVS8r1IpaVN0p5oYuXZ/xd/eWH1PjozRy2rfNUM9y1xppzenyg==", "94a25a0f-5466-4021-919c-d268e8bae25a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65f8871f-e1fa-4a82-9019-aaef01b6f1a7", "AQAAAAEAACcQAAAAEPuJq9Dyjl9bQsn4BOo9cgDWdmkHwvcvZNR7EMdYtDTHdl8uPFV+T4pJol9azhJV7A==", "f8558eec-fbba-4bda-b5f5-e69e148dcc72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d8dd11-f2d1-4882-aba3-958b49088fec", "AQAAAAEAACcQAAAAEAMSRvb66D4s/MSg+7CfkbEi4AmY/9qV5bKICEO/+zl4RlozWbp9p61UEsxdh6QmDQ==", "7519a1fb-af8e-4920-9264-6b6ac92fef6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362e6713-be1f-4984-a0bb-6d1fe4553d2b", "AQAAAAEAACcQAAAAEAY7zOaEJvt9HLcsRxSXabijFbMAYd3uJHJg0zTFfYRvrVaNE+ZJL025isdW4ZlHVg==", "4f4025c8-729c-4ee7-b50d-0341ea3a3f78" });
        }
    }
}
