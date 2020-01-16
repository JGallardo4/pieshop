using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(pieshop.Areas.Identity.IdentityHostingStartup))]
namespace pieshop.Areas.Identity
{
	public class IdentityHostingStartup : IHostingStartup
	{
		public void Configure(IWebHostBuilder builder)
		{
			builder.ConfigureServices((context, services) => {
			});
		}
	}
}