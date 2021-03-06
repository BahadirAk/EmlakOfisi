using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Bll.Concrete;
using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Dal.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakOfisi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddMvc().AddRazorPagesOptions(options =>
			{
				options.Conventions.AddPageRoute("/Login/Login", "");
			});
			services.AddDbContext<EmlakOfisiContext>(options =>
		options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
			services.AddScoped<IAdminDal,EfAdminDal>();
			services.AddScoped<IAgentDal, EfAgentDal>();
			services.AddScoped<IUserDal, EfUserDal>();
			services.AddScoped<IAdDal, EfAdDal>();
			services.AddScoped<IAdminService, AdminService>();
			services.AddScoped<IAgentService, AgentService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IAdService, AdService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
			});
		}
	}
}
