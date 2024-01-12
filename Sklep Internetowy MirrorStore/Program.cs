using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_MirrorStore.Models;
using Microsoft.AspNetCore.Identity;
using Sklep_Internetowy_MirrorStore.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MirrorDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddDbContext<MirrorStoreDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddDefaultIdentity<MirrorStoreUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MirrorStoreDbContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Mirror}/{action=Index}/{id?}");

app.Run();
