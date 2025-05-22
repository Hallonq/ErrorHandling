namespace ErrorHandling.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllers();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/error/server");
                app.UseStatusCodePagesWithRedirects("/error/http/{0}");
            }

            app.Run();
        }
    }
}
