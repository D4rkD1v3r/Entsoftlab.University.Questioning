using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rmi.University.Questioning.Data;

namespace Rmi.University.Questioning.AdminUi
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
			var connectionString = Configuration.GetConnectionString("QuestioningContext");
		  services.AddAutoMapper();
		  services.AddEntityFrameworkNpgsql().AddDbContext<QuestioningContext>(options => options.UseNpgsql(connectionString));
      services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
      app.UseMvc();
		  app.UseDefaultFiles(new DefaultFilesOptions {
		    DefaultFileNames = new
		      List<string> { "index.html" }
		  });
		  app.UseStaticFiles();
    }
	}
}
