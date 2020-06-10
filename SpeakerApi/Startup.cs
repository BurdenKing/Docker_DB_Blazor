using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SpeakerApi {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddControllers ();
            // services.AddDbContext<ApplicationDbContext>(
            //     option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Replace the above code with the following:

            var host = Configuration["DBHOST"] ?? "localhost";
            var port = Configuration["DBPORT"] ?? "1433";
            var password = Configuration["DBPASSWORD"] ?? "SqlExpress!";

            string connStr = $"Server=tcp:{host},{port};Database=SpeakerDB;UID=sa;PWD={password};";

            services.AddDbContext<ApplicationDbContext> (options => options.UseSqlServer (connStr));
            services.AddCors (o => o.AddPolicy ("SpeakerPolicy", builder => {
                builder.AllowAnyOrigin ()
                    .AllowAnyMethod ()
                    .AllowAnyHeader ();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext context) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }           
            app.UseStaticFiles();
            app.UseRouting ();

            app.UseCors();
            app.UseAuthorization();

            context.Database.Migrate();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}