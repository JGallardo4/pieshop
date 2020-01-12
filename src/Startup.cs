using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using pieshop.Models;
using System;

namespace pieshop
{
	public class Startup
{
	public IConfiguration Configuration { get; }

	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	// This method gets called by the runtime. Use this method to add services to the container.
	// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddDbContextPool<AppDbContext>(x => x
			.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
				mySqlOptions => 
				{
					mySqlOptions
						.ServerVersion(new Version(10, 4, 11), ServerType.MariaDb);
				})
		);
		services.AddScoped<IPieRepository, PieRepository>();
		services.AddScoped<ICategoryRepository, CategoryRepository>();
		services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
		services.AddHttpContextAccessor();
		services.AddSession();

		services.AddControllersWithViews();
	}

	// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			app.UseDeveloperExceptionPage();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();
		app.UseSession();
		
		app.UseRouting();

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
