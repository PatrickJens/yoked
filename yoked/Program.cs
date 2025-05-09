namespace yoked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            /* Builder Adds Injected Services */
            builder.Services.AddControllers();
            var app = builder.Build();
            app.MapControllers();          
            app.Run();
        }
    }
}
