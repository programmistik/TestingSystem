using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestingSystem.Areas.Identity.Data;
using TestingSystem.Data;

[assembly: HostingStartup(typeof(TestingSystem.Areas.Identity.IdentityHostingStartup))]
namespace TestingSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TestingSystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TestingSystemContextConnection")));

                services.AddDefaultIdentity<TestingSystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<TestingSystemContext>();
            });
        }
    }
}