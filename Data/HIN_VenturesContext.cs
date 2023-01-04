using HIN_Ventures.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace HIN_Ventures.Data;

public class HIN_VenturesContext : IdentityDbContext
{
    public HIN_VenturesContext(DbContextOptions<HIN_VenturesContext> options)
    : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Freelancer> Freelancers { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Payment> Payments { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Speciality> Specialities { get; set; }

    public DbSet<Score> Scores { get; set; }
    public DbSet<SubmittedCode> SubmittedCodes { get; set; }


    public DbSet<FreelancerRating> Ratings { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        //Seed roles
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = "2e7a8add-af80-466b-878d-cdcbee2415ae"
            });

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "HINEmployee",
                NormalizedName = "HINEMPLOYEE",
                Id = "d31e9f4e-4166-41bf-b226-67da21879725"
            });

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "SeniorDeveloper",
                NormalizedName = "SENIORDEVELOPER",
                Id = "466b18cd-b94a-45cb-be05-aea6878443d8"
            });

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "Freelancer",
                NormalizedName = "FREELANCER",
                Id = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4"
            });

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                Id = "3e52d2ba-8811-452a-be8e-0b2cc408c510"
            });


        // Seed users
        var hasher = new PasswordHasher<ApplicationUser>();

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                Email = "admin@hinventures.no",
                NormalizedEmail = "ADMIN@HINVENTURES.NO",
                UserName = "admin@hinventures.no",
                NormalizedUserName = "ADMIN@HINVENTURES.NO",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Admin",
                LastName = "Bruker"
            }
        );

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                Email = "employee@hinventures.no",
                NormalizedEmail = "EMPLOYEE@HINVENTURES.NO",
                UserName = "employee@hinventures.no",
                AccountAddress = "2Mz8gC1F5Yyh4WyMX4F5ZSz3LemRttFFLTT",
                NormalizedUserName = "EMPLOYEE@HINVENTURES.NO",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Ansatt",
                LastName = "HINVentures"
            }
        );

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                Email = "senior@hinventures.no",
                NormalizedEmail = "SENIOR@HINVENTURES.NO",
                UserName = "senior@hinventures.no",
                NormalizedUserName = "SENIOR@HINVENTURES.NO",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Senior",
                LastName = "Utvikler"
            }
        );

        builder.Entity<Freelancer>().HasData(
            new Freelancer
            {
                Id = "c1441e48-9e22-47d6-a6de-981461285925",
                Email = "freelancer@freelancer.no",
                NormalizedEmail = "FREELANCER@FREELANCER.NO",
                UserName = "freelancer@freelancer.no",
                NormalizedUserName = "FREELANCER@FREELANCER.NO",
                AccountAddress = "2NFhZSZY2zpHCiAHGLbD9iVYfdZkg9yYkef",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Freelancer",
                LastName = "Bruker"
            }
        );

        builder.Entity<Freelancer>().HasData(
            new Freelancer
            {
                Id = "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                Email = "j.johannessen@freelancer.no",
                NormalizedEmail = "J.JOHANNESSEN@FREELANCER.NO",
                UserName = "j.johannessen@freelancer.no",
                NormalizedUserName = "J.JOHANNESSEN@FREELANCER.NO",
                AccountAddress = "2N8vgPdZu5KDbfcVvL38K2ZLJ5XFu8soMgG",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Jon",
                LastName = "Johannessen"
            }
        );

        builder.Entity<Freelancer>().HasData(
            new Freelancer
            {
                Id = "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                Email = "karibj@freelancer.no",
                NormalizedEmail = "KARIBJ@FREELANCER.NO",
                UserName = "karibj@freelancer.no",
                NormalizedUserName = "KARIBJ@FREELANCER.NO",
                AccountAddress = "2MwEkhdf9hbh4RyqEqYARHZPZhJsT5w3Bpe",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Kari",
                LastName = "Bjørklund"
            }
        );

        builder.Entity<Freelancer>().HasData(
            new Freelancer
            {
                Id = "a06696c0-0976-4e0c-8f06-550fba6b624e",
                Email = "mjansen@freelancer.no",
                NormalizedEmail = "MJANSEN@FREELANCER.NO",
                UserName = "mjansen@freelancer.no",
                NormalizedUserName = "MJANSEN@FREELANCER.NO",
                AccountAddress = "2MsFT3bnroCrEm2wVDxcwZs3NNZuxGoVjA5",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Mikael",
                LastName = "Jansen"
            }
        );

        builder.Entity<Freelancer>().HasData(
            new Freelancer
            {
                Id = "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                Email = "ingeborgo@freelancer.no",
                NormalizedEmail = "INGEBORGO@FREELANCER.NO",
                UserName = "ingeborgo@freelancer.no",
                NormalizedUserName = "INGEBORGO@FREELANCER.NO",
                AccountAddress = "2Mz5beBqoeFP2DSJt1fgxzPvnvDJAJtdAmB",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Ingeborg",
                LastName = "Olsen"
            }
        );

        builder.Entity<Customer>().HasData(
            new Customer
            {
                Id = "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                Email = "customer@customer.no",
                NormalizedEmail = "CUSTOMER@CUSTOMER.NO",
                UserName = "customer@customer.no",
                AccountAddress = "2N7eG8ZNiyem2rLUF2RVkqrTBhgV6rWmXAc",
                NormalizedUserName = "CUSTOMER@CUSTOMER.NO",
                PasswordHash = hasher.HashPassword(null, "MyPassword123."),
                FirstName = "Klient",
                LastName = "Bruker",
                IsSubscriber = false
            }
        );

        // Seed assignment
        builder.Entity<Assignment>().HasData(
            new Assignment()
            {
                AssignmentId = 1,
                Deadline = new DateTime(),
                Created = new DateTime(),
                Description = "En spennende oppdrag",
                IsActive = true,
                IsCompleted = false,
                Progress = 0,
                SubmittedCode = null

            });

        builder.Entity<Assignment>().HasData(
            new Assignment()
            {
                AssignmentId = 2,
                Deadline = new DateTime(),
                Created = new DateTime(),
                Description = "En krevende oppdrag",
                IsActive = true,
                IsCompleted = false,
                Progress = 0,
                SubmittedCode = null

            });

        // Seed users and roles
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2e7a8add-af80-466b-878d-cdcbee2415ae",
                UserId = "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c"
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "d31e9f4e-4166-41bf-b226-67da21879725",
                UserId = "608f98cc-681c-42d0-8ee0-5d889584cb8a"
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "466b18cd-b94a-45cb-be05-aea6878443d8",
                UserId = "e3d0c038-508b-4c80-8fd7-7e56b0f74188"
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                UserId = "c1441e48-9e22-47d6-a6de-981461285925"
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                UserId = "db001d8f-ee2f-4065-88ef-9732b8b5fc99"
            }
        );

        //scores
        builder.Entity<Score>().HasData(
            new Score
            {
                ScoreId = 1,
                ScoreValue = 1,
                ScoreName = "Dårlig"
            }
        );

        builder.Entity<Score>().HasData(
            new Score
            {
                ScoreId = 2,
                ScoreValue = 2,
                ScoreName = "Middels"
            }
        );

        builder.Entity<Score>().HasData(
            new Score
            {
                ScoreId = 3,
                ScoreValue = 3,
                ScoreName = "Bra"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 1,
                SpecialityName = "Webapplikasjoner"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 2,
                SpecialityName = "C#"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 3,
                SpecialityName = "HTML"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 4,
                SpecialityName = "CSS"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 5,
                SpecialityName = "JavaScript"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 6,
                SpecialityName = "TypeScript"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 7,
                SpecialityName = "Java"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 8,
                SpecialityName = "C++"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 9,
                SpecialityName = "Azure"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 10,
                SpecialityName = "ASP.Net"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 11,
                SpecialityName = "MVC"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 12,
                SpecialityName = "Blazor"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 13,
                SpecialityName = "Python"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 14,
                SpecialityName = "Android"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 15,
                SpecialityName = "XML"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 16,
                SpecialityName = "Ruby"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 17,
                SpecialityName = "Matlab"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 18,
                SpecialityName = "Kotlin"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 19,
                SpecialityName = "C"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 20,
                SpecialityName = "SQL"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 21,
                SpecialityName = "RoomDatabase"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 22,
                SpecialityName = "Database"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 23,
                SpecialityName = "PHP"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 24,
                SpecialityName = "AI"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 25,
                SpecialityName = "Systemutvikling"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 26,
                SpecialityName = "Apputvikling"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 27,
                SpecialityName = "Systemarkitektur"
            }
        );

        builder.Entity<Speciality>().HasData(
            new Speciality
            {
                SpecialityId = 28,
                SpecialityName = "Datasikkerhet"
            }
        );

        
        builder.Entity<Score>()
            .HasMany(f => f.Freelancers)
            .WithMany(s => s.Score)
            .UsingEntity(j => j.HasData(
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", ScoreId = 1 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", ScoreId = 2 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", ScoreId = 3 },

                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", ScoreId = 1 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", ScoreId = 2 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", ScoreId = 3 },

                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", ScoreId = 1 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", ScoreId = 2 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", ScoreId = 3 },

                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", ScoreId = 1 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", ScoreId = 2 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", ScoreId = 3 },


                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", ScoreId = 1 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", ScoreId = 2 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", ScoreId = 3 }
            ));
        

       builder.Entity<Speciality>()
            .HasMany(f => f.Freelancers)
            .WithMany(s => s.Specialities)
            .UsingEntity(j => j.HasData(
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 25},
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 1 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 2 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 3 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 4 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 5 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 10 },
                new { FreelancersId = "c1441e48-9e22-47d6-a6de-981461285925", SpecialitiesSpecialityId = 11 },

                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", SpecialitiesSpecialityId = 14 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", SpecialitiesSpecialityId = 15 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", SpecialitiesSpecialityId = 18 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", SpecialitiesSpecialityId = 20 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", SpecialitiesSpecialityId = 21 },
                new { FreelancersId = "86dc77f5-a7a5-4743-8a25-82b4c6d52525", SpecialitiesSpecialityId = 26 },

                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", SpecialitiesSpecialityId = 28 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", SpecialitiesSpecialityId = 27 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", SpecialitiesSpecialityId = 25 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", SpecialitiesSpecialityId = 23 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", SpecialitiesSpecialityId = 22 },
                new { FreelancersId = "163d57d7-8a53-46f0-8c37-90bc9fadddf6", SpecialitiesSpecialityId = 20 },

                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 20 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 12 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 22 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 25 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 28 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 9 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 6 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 4 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 5 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 3 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 2 },
                new { FreelancersId = "a06696c0-0976-4e0c-8f06-550fba6b624e", SpecialitiesSpecialityId = 1 },

                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 27 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 24 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 28 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 26 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 21 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 14 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 15 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 13 },
                new { FreelancersId = "a2d899fd-5b46-42f7-8a2d-3b042c159807", SpecialitiesSpecialityId = 17 }
            ));

        builder.Entity<Subscription>().HasData(
            new Subscription
            {
                SubscriptionId = 1,
                SubscriptionName = "Liten pakke",
                SubscriptionDescription = "10 % rabatt",
                NumberOfLines = 10000,
                Price = 0.059
            }
        );

        builder.Entity<Subscription>().HasData(
            new Subscription
            {
                SubscriptionId = 2,
                SubscriptionName = "Medium pakke",
                SubscriptionDescription = "25 % rabatt",
                NumberOfLines = 50000,
                Price = 0.26
            }
        );

        builder.Entity<Subscription>().HasData(
            new Subscription
            {
                SubscriptionId = 3,
                SubscriptionName = "Stor pakke",
                SubscriptionDescription = "40 % rabatt",
                NumberOfLines = 100000,
                Price = 0.53
            }
        );

    }
}
