using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagementApp.Data;
using Microsoft.AspNetCore.Identity;
namespace LibraryManagementApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LibraryManagementAppContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryManagementAppContext") ?? throw new InvalidOperationException("Connection string 'LibraryManagementAppContext' not found.")));

                        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<LibraryManagementAppContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapRazorPages();    

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=LibraryHome}/{action=Index}/{id?}");

            app.Run();
        }
    }
}