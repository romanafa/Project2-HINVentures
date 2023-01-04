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
    [Migration("20221118103659_DatabaseUpdate")]
    partial class DatabaseUpdate
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

                    b.ToTable("FreelancerRating");
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
                            ConcurrencyStamp = "8e8b3844-cf58-4a63-8399-99a8703a94d2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d31e9f4e-4166-41bf-b226-67da21879725",
                            ConcurrencyStamp = "0cb8da30-cc87-46be-9652-0f6db910a709",
                            Name = "HINEmployee",
                            NormalizedName = "HINEMPLOYEE"
                        },
                        new
                        {
                            Id = "466b18cd-b94a-45cb-be05-aea6878443d8",
                            ConcurrencyStamp = "d39defcd-34a7-4e12-8f6e-b0fb7d8531e1",
                            Name = "SeniorDeveloper",
                            NormalizedName = "SENIORDEVELOPER"
                        },
                        new
                        {
                            Id = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                            ConcurrencyStamp = "4985ff39-e566-4976-bc67-1021ba8892d5",
                            Name = "Freelancer",
                            NormalizedName = "FREELANCER"
                        },
                        new
                        {
                            Id = "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                            ConcurrencyStamp = "19f10650-5cda-43f2-ac70-f33683409184",
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
                            UserId = "2a6c7358-6dea-434c-8c16-f762a5db6289",
                            RoleId = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4"
                        },
                        new
                        {
                            UserId = "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a",
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
                            ConcurrencyStamp = "3f9af132-bafc-4a7d-b219-60b15f576fcc",
                            Email = "admin@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HINVENTURES.NO",
                            NormalizedUserName = "ADMIN@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEEnwKgyvAgHltg251SfJ/sSncXkD58aNCtLwYdKzJAY1LxyVUN0PW/tjmQ4qLm38Jg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e4920835-78c2-4f1f-bc5a-7690b8cb9d3b",
                            TwoFactorEnabled = false,
                            UserName = "admin@hinventures.no",
                            FirstName = "Admin",
                            LastName = "Bruker"
                        },
                        new
                        {
                            Id = "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b9fb1431-7434-4373-b467-3bc921b30b50",
                            Email = "employee@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@HINVENTURES.NO",
                            NormalizedUserName = "EMPLOYEE@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEBIjMdkA6o7ZHtLeqkVRlZYbx9HpkCFfOwHLiwN2a3q9XsKP3kcHftmvNHYKh4AdaA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cdd422e3-bcdc-468e-962e-fbe49d8c9388",
                            TwoFactorEnabled = false,
                            UserName = "employee@hinventures.no",
                            FirstName = "Ansatt",
                            LastName = "HINVentures"
                        },
                        new
                        {
                            Id = "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a5dea1a-0fd4-442c-85dc-514cf0919339",
                            Email = "senior@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SENIOR@HINVENTURES.NO",
                            NormalizedUserName = "SENIOR@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEPz9LiRGr7JbYZxRhlb+YfGSC2bzwO1fejgIPVJaCunpMGK6vIOQwElhiOW0cyypQQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b5895971-cc95-4a59-817b-b7b03d4dbce2",
                            TwoFactorEnabled = false,
                            UserName = "senior@hinventures.no",
                            FirstName = "Senior",
                            LastName = "Utvikler"
                        },
                        new
                        {
                            Id = "2a6c7358-6dea-434c-8c16-f762a5db6289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "80673048-281b-473f-9faf-519a2d2039c7",
                            Email = "freelancer@freelancer.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "FREELANCER@FREELANCER.NO",
                            NormalizedUserName = "FREELANCER@FREELANCER.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAELVD41QgGFwmWLsEZvspukg8JcxGf2PDBKZ0ODrseHk0D+d3f9nuk9+Nu3Jp/mW7sA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1378a7b9-f1c2-4175-9dc3-9efbfaf49346",
                            TwoFactorEnabled = false,
                            UserName = "freelancer@freelancer.no",
                            FirstName = "Freelancer",
                            LastName = "Bruker"
                        },
                        new
                        {
                            Id = "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5cab823-ed29-436b-bb5e-4a211b15a1f5",
                            Email = "customer@customer.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@CUSTOMER.NO",
                            NormalizedUserName = "CUSTOMER@CUSTOMER.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEP4ulu34VKRDmoYUV3wQ+KM6Bb+YGbGMMX6CfMSYZemVFftYEXUEoNZjT0cFidOZGQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bff3645f-ddd9-4bcd-b06c-2662f1d6c36e",
                            TwoFactorEnabled = false,
                            UserName = "customer@customer.no",
                            FirstName = "Klient",
                            LastName = "Bruker"
                        });
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Customer", b =>
                {
                    b.HasBaseType("HIN_Ventures.Models.Entities.ApplicationUser");

                    b.Property<bool>("IsSubscriber")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("HIN_Ventures.Models.Entities.Freelancer", b =>
                {
                    b.HasBaseType("HIN_Ventures.Models.Entities.ApplicationUser");

                    b.HasDiscriminator().HasValue("Freelancer");
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
