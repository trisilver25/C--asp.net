using BasicMVC.DataLayer;
using BasicMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<MVCUser, IdentityRole> (options => {
    options.Password.RequiredLength = 10;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<AuthDBContext>().AddDefaultTokenProviders();

// add connection string
// builder.Services.AddDbContext<BasicDBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("BasicMVCContextString")));
builder.Services.AddDbContext<AuthDBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("BasicMVCContextString")));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Note need to figure out why we can't open the database file and migrate our data.