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
                StreamReader reader = new StreamReader( context.Request.Body);
                string body = await reader.ReadToEndAsync();
                Console.WriteLine(body);
            });
            app.Run();
        }
    }
}
