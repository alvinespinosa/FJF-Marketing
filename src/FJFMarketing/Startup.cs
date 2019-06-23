using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.Dapper.Interface;
using FJFMarketing.Repository.EF;
using FJFMarketing.Repository.EF.Data;
using FJFMarketing.Repository.EF.Interface;
using FJFMarketing.Services;
using FJFMarketing.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using ItemRepositoryDapper = FJFMarketing.Repository.Dapper.ItemRepository;
using ItemRepositoryEF = FJFMarketing.Repository.EF.ItemRepository;

namespace FJFMarketing
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<ItemContext>(
                opt => opt.UseSqlServer(
                    Configuration["ConnectionStrings:MyConnectionString"]));

            // Configure jwt authentication
            //services.AddAuthenticationCore(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults
            //})
            //.addjw;

            services
                .AddTransient<IItemService, ItemService>()
                .AddTransient<IUnitOfWork, UnitOfWork>()
                .AddTransient<IItemRepository, ItemRepositoryEF>()
                .AddTransient<IReadOnlyRepository<Item>, ItemRepositoryDapper>();

            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
