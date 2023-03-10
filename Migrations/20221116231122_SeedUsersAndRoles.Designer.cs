// <auto-generated />
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
    [Migration("20221116231122_SeedUsersAndRoles")]
    partial class SeedUsersAndRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            ConcurrencyStamp = "5836cd4b-293d-4af3-8ce1-82ce78f043d9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d31e9f4e-4166-41bf-b226-67da21879725",
                            ConcurrencyStamp = "2d2efc5d-7f62-4e89-9474-cc65578c2cdc",
                            Name = "HINEmployee",
                            NormalizedName = "HINEMPLOYEE"
                        },
                        new
                        {
                            Id = "466b18cd-b94a-45cb-be05-aea6878443d8",
                            ConcurrencyStamp = "0b07c5f0-28b3-479e-b076-c02e4e1960da",
                            Name = "SeniorDeveloper",
                            NormalizedName = "SENIORDEVELOPER"
                        },
                        new
                        {
                            Id = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                            ConcurrencyStamp = "35a09239-93de-43e3-b39a-704f28777aa8",
                            Name = "Freelancer",
                            NormalizedName = "FREELANCER"
                        },
                        new
                        {
                            Id = "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                            ConcurrencyStamp = "b77a03db-cef9-41d7-b118-de13d65c206b",
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
                            ConcurrencyStamp = "c3a006bc-408f-40c1-aff7-4c2706f3a99f",
                            Email = "admin@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HINVENTURES.NO",
                            NormalizedUserName = "ADMIN@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEMfwLC+MKz9uHf3A++MCrpmy2HvafEYHOb+jMs/OKyM047cWftK2iz+Dfa7UbkhqbA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "73d6fcdf-0dfa-4090-80d7-280f94d8565c",
                            TwoFactorEnabled = false,
                            UserName = "admin@hinventures.no",
                            FirstName = "Admin",
                            LastName = "Bruker"
                        },
                        new
                        {
                            Id = "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "495476a1-f8e2-494b-8495-dd7c92895135",
                            Email = "employee@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@HINVENTURES.NO",
                            NormalizedUserName = "EMPLOYEE@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEOvzcIMRierIoMjhGh2WAC5C5v91XIXkbnf5YFWOVy+/lWZYoDGZQCxlsByKuSGPEA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "deed907f-4fdf-484e-b6ec-230cf47b1149",
                            TwoFactorEnabled = false,
                            UserName = "employee@hinventures.no",
                            FirstName = "Ansatt",
                            LastName = "HINVentures"
                        },
                        new
                        {
                            Id = "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "531835b5-c791-49dd-a269-7e157bd208aa",
                            Email = "senior@hinventures.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SENIOR@HINVENTURES.NO",
                            NormalizedUserName = "SENIOR@HINVENTURES.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAENdjofmCdFeJM2uxdPzWfYLy8A1KnwfSdciN7wuwZiSoc0Z6wvrNl5I8vF4aqd0gtw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2d303893-99ed-4a79-846a-2a3f2ffa1464",
                            TwoFactorEnabled = false,
                            UserName = "senior@hinventures.no",
                            FirstName = "Senior",
                            LastName = "Utvikler"
                        },
                        new
                        {
                            Id = "2a6c7358-6dea-434c-8c16-f762a5db6289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7e6e3a48-5d38-493e-8883-2381279ccce8",
                            Email = "freelancer@freelancer.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "FREELANCER@FREELANCER.NO",
                            NormalizedUserName = "FREELANCER@FREELANCER.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEOEErdLLYJ27UIQbbCn0hbATGw8nMVK+yYlNH9hbbTEKGm82DTTcO7NUqgx1mthCKA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "39425864-2df6-476a-9636-cf97c9c7cbcf",
                            TwoFactorEnabled = false,
                            UserName = "freelancer@freelancer.no",
                            FirstName = "Freelancer",
                            LastName = "Bruker"
                        },
                        new
                        {
                            Id = "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e137eb03-55fd-4064-9aa4-668f20ea2b8a",
                            Email = "customer@customer.no",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@CUSTOMER.NO",
                            NormalizedUserName = "CUSTOMER@CUSTOMER.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAECXdpfBbeIcbcok1hIv9U5dCzcAdIi38mlRwKSMGJqshFVXvQxmhH+QPwjgcKWE/4Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a9453e0d-e655-4b80-af36-02e471a1730c",
                            TwoFactorEnabled = false,
                            UserName = "customer@customer.no",
                            FirstName = "Klient",
                            LastName = "Bruker"
                        });
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
#pragma warning restore 612, 618
        }
    }
}
