using Microsoft.EntityFrameworkCore;
using yoked.Data;

namespace yoked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            /* Builder Adds Injected Services */
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<YokedDbContext>(options =>
            
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );
            

            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run( async(HttpContext context) =>
            {
                string path = context.Request.Path;
                string method = context.Request.Method;
                context.Response.StatusCode = 200;
                context.Response.Headers["Is_Prod"] = "not_prod";
                await context.Response.WriteAsync("World");
                await context.Response.WriteAsync("Hello");
                await context.Response.WriteAsync($"<p>{path}</p>");
                await context.Response.WriteAsync($"<br>{method}");

            });
            app.Run();
        }
    }
}
