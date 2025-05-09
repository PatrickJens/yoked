namespace yoked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            /* Builder Adds Injected Services */

            
            app.Run( async ( HttpContext context) =>
            {
                StreamReader reader = new StreamReader(context.Request.Body);
                String body = await reader.ReadToEndAsync();
                context.Response.Headers["Content-type"] = "text/html";
                if ( context.Request.Method == "POST" && context.Request.Query.ContainsKey("id"))
                {
                    String id = context.Request.Query["id"];
                    await context.Response.WriteAsync($"<p>{id}<p>");
                }
                String path = context.Request.Path;
                String method = context.Request.Method;
                await context.Response.WriteAsync($"<p>{path}<p>");
                await context.Response.WriteAsync($"<p>{method}<p>");
                
            });

            app.Run();
        }
    }
}
