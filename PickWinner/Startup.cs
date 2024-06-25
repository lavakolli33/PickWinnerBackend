using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PickWinner.Models;
using PickWinner.Models.Interfaces;
using PickWinner.Services;

namespace PickWinner
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration config)
        {
            configuration = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddControllers();

            services.AddDbContextPool<AppDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("pickWinnerDBConnection")));

            services.AddScoped<IUserInfo, UserInfoService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "queue_storage", Version = "v1" });
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "queue_storage v1"));
            }

            app.UseCors(x => x
           .AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
