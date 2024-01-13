using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_MirrorStore.Models;
using Microsoft.AspNetCore.Identity;
using Sklep_Internetowy_MirrorStore.Areas.Identity.Data;


public class Program
{
	public static async Task Main(string[] args)
	{

		var builder = WebApplication.CreateBuilder(args);

		// Konfiguruj us³ugi Identity
		

		builder.Services.AddDbContext<MirrorDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

		builder.Services.AddDbContext<MirrorStoreDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

		builder.Services.AddDefaultIdentity<MirrorStoreUser>(options => options.SignIn.RequireConfirmedAccount = false)
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

		app.MapRazorPages();

		app.UseAuthentication();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Mirror}/{action=Index}/{id?}");



		using(var scope = app.Services.CreateScope())
		{
			var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			var roles = new[] { "Admin", "User" };

			foreach (var role in roles)
			{
				
				if (!await roleManager.RoleExistsAsync(role))
				{
					// Utwórz role
					await roleManager.CreateAsync(new IdentityRole(role));
				}
			}
		}

		using (var scope = app.Services.CreateScope())
		{
			var userManager = scope.ServiceProvider.GetRequiredService<UserManager<MirrorStoreUser>>();

			string email = "szczepanduda11@gmail.com";
			string password = "#EDC4r";

				 
			if (await userManager.FindByEmailAsync(email) == null)
			{
				var user = new MirrorStoreUser();
				user.UserName = email;
				user.Email = email;
				
				await userManager.CreateAsync(user, password);

				await userManager.AddToRoleAsync(user, "Admin");
			}
			
		}




		app.Run();

	}
}
