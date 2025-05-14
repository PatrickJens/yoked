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
            app.Run();
        }
    }
}
