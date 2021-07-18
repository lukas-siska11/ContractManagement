using ContractManagement.Application.ApplicationServices.Clients;
using ContractManagement.Application.ApplicationServices.Consultants;
using ContractManagement.Application.ApplicationServices.Contracts;
using ContractManagement.Application.ApplicationServices.Institutions;
using ContractManagement.Application.Mappers.Clients;
using ContractManagement.Application.Mappers.Consultants;
using ContractManagement.Application.Mappers.Contracts;
using ContractManagement.Application.Mappers.Institutions;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Repositories.Contracts;
using ContractManagement.Domain.Repositories.Institutions;
using ContractManagement.Infrastructure.Data;
using ContractManagement.Infrastructure.Repositories.Clients;
using ContractManagement.Infrastructure.Repositories.Consultants;
using ContractManagement.Infrastructure.Repositories.Contracts;
using ContractManagement.Infrastructure.Repositories.Institutions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContractManagement
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // TODO: Password as secret value
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("devel")));
            //var builder = new SqlConnectionStringBuilder(Configuration.GetConnectionString("devel"));
            //builder.Password = Configuration["mssqlPasswordDevel"];

            // Application services
            services.AddScoped<IClientApplicationService, ClientApplicationService>();
            services.AddScoped<IConsultantApplicationService, ConsultantApplicationService>();
            services.AddScoped<IContractApplicationService, ContractApplicationService>();
            services.AddScoped<IInstitutionApplicationService, InstitutionApplicationService>();

            // Mappers
            services.AddScoped<ClientMapper>();
            services.AddScoped<ConsultantMapper>();
            services.AddScoped<ContractMapper>();
            services.AddScoped<InstitutionMapper>();

            // Repositories
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IConsultantRepository, ConsultantRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IInstitutionRepository, InstitutionRepository>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
