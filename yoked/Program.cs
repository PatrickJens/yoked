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
                await context.Response.WriteAsync($"This is a default response body\n");
                if (context.Request.Query.ContainsKey("name") && context.Request.Query.ContainsKey("day"))
                {
                    string name = context.Request.Query["name"];
                    string day = context.Request.Query["day"];
                    await context.Response.WriteAsync($"Name is {name}\n");
                    await context.Response.WriteAsync($"Day is {day}\n");
                }
                


            });
            app.Run();
        }
    }
}
