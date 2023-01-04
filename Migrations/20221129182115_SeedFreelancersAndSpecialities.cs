using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class SeedFreelancersAndSpecialities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "abd7a9e1-7596-446e-a124-b19abaa83e89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "94ad7b69-fc8c-45c1-b7e5-0a3b5ba296ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "8acb8a65-b785-4800-a9e4-8ce071799a49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "3187f032-87ee-412b-b766-6007f1fe6472");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "72e1220a-f1ef-475c-988a-cda5aa1e79f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "116ec3e5-da7c-4b16-a490-97d03b11a46a", "AQAAAAEAACcQAAAAECmj4+VRLdnhrSJEV/MCRirSFMWK8B5Gw40VJ9SjbRXsJA17ukxDQYT35f2YIOn+Sw==", "4f39b12a-7827-4b94-b2b1-37d7e7dd420b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecc9a9d4-84c4-44cd-8c95-5d2f7090be61", "AQAAAAEAACcQAAAAEHu5QNHL7cbgj3y4ItaWJwAN7RgERiof0yuiGOlZ+iPN9C0L1KdRNssnjTolgJm2jw==", "59944cb4-d0ab-4d1c-a4e6-949fae249b59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a946c9f-abcc-4785-8f0c-46cd5e36c7da", "AQAAAAEAACcQAAAAEGLNzOE/Eajl3LnvM3+LwxnqzWnSfAxs8p90Wp0J/p0V+7yQiOBXYoBPr2dkm5xe6Q==", "a35face1-a089-40b6-8960-b3314e40ff07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e7f5df-18cf-490e-b569-68e2e428e3ed", "AQAAAAEAACcQAAAAEBZrp1pWHP3uc0g/namRVGT1zDR0TVScGTxX8Qs8T+BgHeqfdMfGWGT6JQzwE0DyCA==", "e9302c40-7bb6-4635-a794-1b3f77481de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8743dbbe-8627-409b-ad84-64564728fca9", "AQAAAAEAACcQAAAAEBunrRYDvMnI5FORL4FOjY1qE/Kbnbnm8IBm9ufJ5jvBU3dFbmE2uI03HOCcQXBd7g==", "8fe5de80-2345-4b6c-a154-c356e814b65d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Freelancer_AccountAddress", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 0, "2MwEkhdf9hbh4RyqEqYARHZPZhJsT5w3Bpe", "7ccd7508-f2a3-4c4f-86d3-3202155dfa34", "Freelancer", "karibj@freelancer.no", false, "Kari", "Bjørklund", false, null, "KARIBJ@FREELANCER.NO", "KARIBJ@FREELANCER.NO", "AQAAAAEAACcQAAAAEAFsrjSL6eYXZsKAuQX7S3AijIVRHzNlR44xkr4J+OtOZFpG/jgulwEzXxvz7hgjOw==", null, false, "909413ea-210d-4084-aa6d-b0c7630f409c", false, "karibj@freelancer.no" },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 0, "2N8vgPdZu5KDbfcVvL38K2ZLJ5XFu8soMgG", "a408504c-9303-46b2-abba-98779a8181c9", "Freelancer", "j.johannessen@freelancer.no", false, "Jon", "Johannessen", false, null, "J.JOHANNESSEN@FREELANCER.NO", "J.JOHANNESSEN@FREELANCER.NO", "AQAAAAEAACcQAAAAEGol12yhSOYyJcZmH0Gq4T5OBy+QgbaFHPWCDm+R3IuigdOvi9vaQZXkGyFN4qBFYg==", null, false, "e7cc0a11-96f0-4dac-bac5-d5b4846bb0f6", false, "j.johannessen@freelancer.no" },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 0, "2MsFT3bnroCrEm2wVDxcwZs3NNZuxGoVjA5", "3d48e0f0-d0ba-4ef5-a560-d100c189791a", "Freelancer", "mjansen@freelancer.no", false, "Mikael", "Jansen", false, null, "MJANSEN@FREELANCER.NO", "MJANSEN@FREELANCER.NO", "AQAAAAEAACcQAAAAEC0NI3yIq3pJhyS/JXlRMGWeg2Ht+AGYi6WNVq8x1IQ3buvM/IfM7LKPpWdK9pVCsQ==", null, false, "42cec6ff-43ff-4183-abc8-46197a763f92", false, "mjansen@freelancer.no" },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 0, "2Mz5beBqoeFP2DSJt1fgxzPvnvDJAJtdAmB", "293bac7d-42ed-418b-93c6-08a4ebbb07b5", "Freelancer", "ingeborgo@freelancer.no", false, "Ingeborg", "Olsen", false, null, "INGEBORGO@FREELANCER.NO", "INGEBORGO@FREELANCER.NO", "AQAAAAEAACcQAAAAEOnS4SyUDEMdceTkrF1mBcHqXaQRyueZ5OjWQJj2SnTkbUVS6jwJ0Q5PKnlgGS0JeA==", null, false, "e9f52feb-040b-442e-b441-85c30683a902", false, "ingeborgo@freelancer.no" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "SpecialityId", "SpecialityName" },
                values: new object[,]
                {
                    { 1, "Webapplikasjoner" },
                    { 2, "C#" },
                    { 3, "HTML" },
                    { 4, "CSS" },
                    { 5, "JavaScript" },
                    { 6, "TypeScript" },
                    { 7, "Java" },
                    { 8, "C++" },
                    { 9, "Azure" },
                    { 10, "ASP.Net" },
                    { 11, "MVC" },
                    { 12, "Blazor" },
                    { 13, "Python" },
                    { 14, "Android" },
                    { 15, "XML" },
                    { 16, "Ruby" },
                    { 17, "Matlab" },
                    { 18, "Kotlin" },
                    { 19, "C" },
                    { 20, "SQL" },
                    { 21, "RoomDatabase" },
                    { 22, "Database" },
                    { 23, "PHP" },
                    { 24, "AI" },
                    { 25, "Systemutvikling" },
                    { 26, "Apputvikling" },
                    { 27, "Systemarkitektur" },
                    { 28, "Datasikkerhet" }
                });

            migrationBuilder.InsertData(
                table: "FreelancerSpeciality",
                columns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                values: new object[,]
                {
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 20 },
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 22 },
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 23 },
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 25 },
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 27 },
                    { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 28 },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 14 },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 15 },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 18 },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 20 },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 21 },
                    { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 26 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 1 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 2 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 3 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 4 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 5 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 6 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 9 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 12 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 20 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 22 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 25 },
                    { "a06696c0-0976-4e0c-8f06-550fba6b624e", 28 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 13 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 14 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 15 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 17 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 21 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 24 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 26 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 27 },
                    { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 28 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 1 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 2 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 3 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 4 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 5 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 10 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 11 },
                    { "c1441e48-9e22-47d6-a6de-981461285925", 25 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 20 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 22 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 23 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 25 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 27 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "163d57d7-8a53-46f0-8c37-90bc9fadddf6", 28 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 14 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 15 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 18 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 20 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 21 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "86dc77f5-a7a5-4743-8a25-82b4c6d52525", 26 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 1 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 2 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 3 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 4 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 5 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 6 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 9 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 12 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 20 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 22 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 25 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a06696c0-0976-4e0c-8f06-550fba6b624e", 28 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 13 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 14 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 15 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 17 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 21 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 24 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 26 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 27 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "a2d899fd-5b46-42f7-8a2d-3b042c159807", 28 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 1 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 2 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 3 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 4 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 5 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 10 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 11 });

            migrationBuilder.DeleteData(
                table: "FreelancerSpeciality",
                keyColumns: new[] { "FreelancersId", "SpecialitiesSpecialityId" },
                keyValues: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 25 });

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807");

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "SpecialityId",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "7193f472-44a3-4510-80de-51d25be5fe43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "abe5c59a-273f-4bae-b8ca-8fe7c28f04bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "0a011fd4-600c-462b-bd63-458ec0489ac9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "aaba36f1-f463-4921-85ce-73443e972f78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "0ee6065a-a134-4065-bce1-9e77544f69a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324ec967-37df-46f7-9dec-8806e6ec4b36", "AQAAAAEAACcQAAAAEH9rqUobMQSJG7MTL2URIxysUK0q3wiHCPVTjDe/dGv/P7EsOqn2RhC6P+hgEE3G8g==", "0782bb05-4d33-47e2-be41-e19d17366a46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4afefa78-fc46-42eb-b47e-4e2737c27124", "AQAAAAEAACcQAAAAEIcelcHtpbU0wCnJc4RkRhsQ0PrBI441PFE5C3iB0z8vQSN8aEfKEQCEGDZCI+FMxg==", "437b7f93-141e-4f55-ace1-f0120ab01bcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f6fdcb8-42cb-46c4-86f8-158dfec822c3", "AQAAAAEAACcQAAAAEJ/YdTOjDP8CWkTzeE4fGf/PpzTwZVrnTMvfatr5rVQidqpz2KQdDk4kzkbSJC0pfQ==", "38121ab7-32c1-4cd9-b432-ef327165eda7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b398ea1-962c-4bd3-9c85-11262b9c1c76", "AQAAAAEAACcQAAAAEExqkrqsa9gMc8LC/77iKWBoCvAEcZZuHgVV/0kmys+FmDXMLXtHLkKqsB1qBmZM2w==", "607d3bc0-8382-449a-b5f4-0b571c58c989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e12ba062-7da0-4a37-b701-d3819213090c", "AQAAAAEAACcQAAAAENWbNrrLdWJNp7Thg25QHU/GNqS+NNSTyWXRUwkBcdp0J4C7O/mFDvHgHKBoDCm8ww==", "4d400a96-4508-4a2f-a010-d5253ec14c01" });
        }
    }
}
