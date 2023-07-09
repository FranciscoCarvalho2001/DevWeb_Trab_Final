using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DevWeb_Trab_Final.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


// intru��es para adicionar o servi�o de acesso � DB (neste caso, SQL Server)
builder.Services.AddDbContext<DevWeb_Trab_FinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevWeb_Trab_FinalContext") ?? throw new InvalidOperationException("Connection string 'DevWeb_Trab_FinalContext' not found.")));

builder.Services.AddDefaultIdentity<DevWeb_Trab_Final_User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // permite o uso de Roles
    .AddEntityFrameworkStores<DevWeb_Trab_FinalContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

app.Run();
