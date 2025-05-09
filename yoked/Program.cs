namespace yoked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            /* Builder Adds Injected Services */
            String test_git = "testXXXX";
            String envVar = Environment.GetEnvironmentVariable("home_message");
            app.MapGet("/", () => envVar);
            app.Run();
        }
    }
}
