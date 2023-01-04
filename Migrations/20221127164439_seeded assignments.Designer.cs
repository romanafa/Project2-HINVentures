﻿// <auto-generated />
using System;
using HIN_Ventures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HIN_Ventures.Migrations
{
    [DbContext(typeof(HIN_VenturesContext))]
    [Migration("20221127164439_seeded assignments")]
    partial class seededassignments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FreelancerSpeciality", b =>
                {
                    b.Property<string>("FreelancersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SpecialitiesSpecialityId")
                        .HasColumnType("int");

                    b.HasKey("FreelancersId", "SpecialitiesSpecialityId");

                    b.HasIndex("SpecialitiesSpecialityId");

                    b.ToTable("FreelancerSpeciality");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignmentId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreelancerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("AssignmentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FreelancerId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            AssignmentId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "En spennende oppdrag",
                            IsActive = true,
                            IsCompleted = false,
                            Progress = 0
                        },
                        new
                        {
                            AssignmentId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "En krevende oppdrag",
                            IsActive = true,
                            IsCompleted = false,
                            Progress = 0
                        });
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.FreelancerRating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreelancerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("FreelancerId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Speciality", b =>
                {
                    b.Property<int>("SpecialityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialityId"), 1L, 1);

                    b.Property<string>("SpecialityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialityId");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.SubmittedCode", b =>
                {
                    b.Property<int>("CodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeId"), 1L, 1);

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.HasKey("CodeId");

                    b.HasIndex("AssignmentId")
                        .IsUnique();

                    b.ToTable("SubmittedCodes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2e7a8add-af80-466b-878d-cdcbee2415ae",
                            ConcurrencyStamp = "44156a3b-ee8b-4ae8-8bd5-32f9363f1883",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d31e9f4e-4166-41bf-b226-67da21879725",
                            ConcurrencyStamp = "8eec0417-2008-4be1-89e7-d40ad3d20ee0",
                            Name = "HINEmployee",
                            NormalizedName = "HINEMPLOYEE"
                        },
                        new
                        {
                            Id = "466b18cd-b94a-45cb-be05-aea6878443d8",
                            ConcurrencyStamp = "b41204d7-caf5-4d81-ac17-d0495577e5f8",
                            Name = "SeniorDeveloper",
                            NormalizedName = "SENIORDEVELOPER"
                        },
                        new
                        {
                            Id = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                            ConcurrencyStamp = "e726df7c-2c1e-4214-9818-40e0c90bf9f4",
                            Name = "Freelancer",
                            NormalizedName = "FREELANCER"
                        },
                        new
                        {
                            Id = "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                            ConcurrencyStamp = "ea45fd0b-5b9e-4f62-8605-b29659dced18",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                            RoleId = "2e7a8add-af80-466b-878d-cdcbee2415ae"
                        },
                        new
                        {
                            UserId = "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                            RoleId = "d31e9f4e-4166-41bf-b226-67da21879725"
                        },
                        new
                        {
                            UserId = "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                            RoleId = "466b18cd-b94a-45cb-be05-aea6878443d8"
                        },
                        new
                        {
                            UserId = "c1441e48-9e22-47d6-a6de-981461285925",
                            RoleId = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4"
                        },
                        new
                        {
                            UserId = "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                            RoleId = "3e52d2ba-8811-452a-be8e-0b2cc408c510"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "09235375-c213-49da-87f9-24c7ecdc5650",
                            Email = "admin@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HINVENTURES.NO",
                            NormalizedUserName = "ADMIN@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAELrFzYyCLob+RUyWhVMrnqnJvr4G/wVmpJkwt2BUKwSH4+LYo+5YmFKtuySULD1jGQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fbff110f-d415-4a94-a7b9-7e46cc73589b",
                            TwoFactorEnabled = false,
                            UserName = "admin@hinventures.no",
                            FirstName = "Admin",
                            LastName = "Bruker"
                        },
                        new
                        {
                            Id = "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1880eedf-7920-491f-b13f-b2521e609eea",
                            Email = "employee@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@HINVENTURES.NO",
                            NormalizedUserName = "EMPLOYEE@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEPI6jGPHg23d5mtfNUVvHvZuVEhOw1+pOWOZM9jWGqpU1cJ/e4uFWlJl3Mx/RhMPOg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "766c84e5-3709-4989-a439-4bcd7dbf9ea7",
                            TwoFactorEnabled = false,
                            UserName = "employee@hinventures.no",
                            FirstName = "Ansatt",
                            LastName = "HINVentures"
                        },
                        new
                        {
                            Id = "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9c3e62da-0743-49fe-8aef-119e09eda4a5",
                            Email = "senior@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SENIOR@HINVENTURES.NO",
                            NormalizedUserName = "SENIOR@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEOUR4pLDRYySJNymesvCFsVIBiZz+mxaMPAoEYnTBv1Hr2bnYQUNYw8IY9lyNbhzyw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "19f10dcf-72db-4308-aaca-842327603a09",
                            TwoFactorEnabled = false,
                            UserName = "senior@hinventures.no",
                            FirstName = "Senior",
                            LastName = "Utvikler"
                        });
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Customer", b =>
                {
                    b.HasBaseType("HIN_Ventures.Models.Entities.ApplicationUser");

                    b.Property<string>("AccountAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubscriber")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Customer");

                    b.HasData(
                        new
                        {
                            Id = "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f931592-ff7c-4e18-96bf-96475c4879cc",
                            Email = "customer@customer.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@CUSTOMER.NO",
                            NormalizedUserName = "CUSTOMER@CUSTOMER.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEDM9nlcp3tqqqLbb8hKcDLnKYXlGUnb7860al/IsseBJm2lGVNY/34vnYjRWTe8n8Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f5bd72ae-3945-46a1-903a-1d869ab53779",
                            TwoFactorEnabled = false,
                            UserName = "customer@customer.no",
                            FirstName = "Klient",
                            LastName = "Bruker",
                            AccountAddress = "2N7eG8ZNiyem2rLUF2RVkqrTBhgV6rWmXAc",
                            IsSubscriber = true
                        });
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Freelancer", b =>
                {
                    b.HasBaseType("HIN_Ventures.Models.Entities.ApplicationUser");

                    b.Property<string>("AccountAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Freelancer_AccountAddress");

                    b.HasDiscriminator().HasValue("Freelancer");

                    b.HasData(
                        new
                        {
                            Id = "c1441e48-9e22-47d6-a6de-981461285925",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b9bba6b-a5b1-47c4-b8e3-7f8b5899d85c",
                            Email = "freelancer@freelancer.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "FREELANCER@FREELANCER.NO",
                            NormalizedUserName = "FREELANCER@FREELANCER.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEJDeZzWd0pSVBC9MXClT7n35wh/OQKcKJN2b3Gw1esfmLgrgD8Dxwu8XU69B7HGBaQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea37795f-56d2-4a7c-9762-d7aba49aa0ac",
                            TwoFactorEnabled = false,
                            UserName = "freelancer@freelancer.no",
                            FirstName = "Freelancer",
                            LastName = "Bruker",
                            AccountAddress = "2NFhZSZY2zpHCiAHGLbD9iVYfdZkg9yYkef"
                        });
                });

            modelBuilder.Entity("FreelancerSpeciality", b =>
                {
                    b.HasOne("HIN_Ventures.Models.Entities.Freelancer", null)
                        .WithMany()
                        .HasForeignKey("FreelancersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HIN_Ventures.Models.Entities.Speciality", null)
                        .WithMany()
                        .HasForeignKey("SpecialitiesSpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Assignment", b =>
                {
                    b.HasOne("HIN_Ventures.Models.Entities.Customer", null)
                        .WithMany("Assignments")
                        .HasForeignKey("CustomerId");

                    b.HasOne("HIN_Ventures.Models.Entities.Freelancer", null)
                        .WithMany("Assignments")
                        .HasForeignKey("FreelancerId");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.FreelancerRating", b =>
                {
                    b.HasOne("HIN_Ventures.Models.Entities.Freelancer", null)
                        .WithMany("Ratings")
                        .HasForeignKey("FreelancerId");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Message", b =>
                {
                    b.HasOne("HIN_Ventures.Models.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.SubmittedCode", b =>
                {
                    b.HasOne("HIN_Ventures.Models.Entities.Assignment", "Assignment")
                        .WithOne("SubmittedCode")
                        .HasForeignKey("HIN_Ventures.Models.Entities.SubmittedCode", "AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Assignment", b =>
                {
                    b.Navigation("SubmittedCode")
                        .IsRequired();
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Customer", b =>
                {
                    b.Navigation("Assignments");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Freelancer", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}