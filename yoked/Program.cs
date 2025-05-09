namespace yoked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            /* Builder Adds Injected Services */
            var app = builder.Build();
            //Routing
            app.UseRouting();

            //Creating Endpoints
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/map1", async (HttpContext context) =>
                {
                    await context.Response.WriteAsync("In Map 1");
                });
                endpoints.MapPost("/map2", async (HttpContext context) =>
                {
                    await context.Response.WriteAsync("In Map 2");
                });

            });
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"Request received at {context.Request.Path}");
            });
            app.Run();
        }
    }
}
