    using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using HIN_Ventures.Repository;
using HIN_Ventures.Hubs;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("HIN_VenturesContextConnectionAzure") ?? throw new InvalidOperationException("Connection string 'HIN_VenturesContextConnectionAzure' not found.");

builder.Services.AddDbContext<HIN_VenturesContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddSignalR();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => 
        options.SignIn.RequireConfirmedAccount = false)
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddEntityFrameworkStores<HIN_VenturesContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IAssignmentRepository, AssignmentRepository>();
builder.Services.AddTransient<ISubmittedCodeRepository, SubmittedCodeRepository>();
builder.Services.AddTransient<IFreelancerRepository, FreelancerRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.MapHub<ChatHub>("/chatHub");

app.Run();
