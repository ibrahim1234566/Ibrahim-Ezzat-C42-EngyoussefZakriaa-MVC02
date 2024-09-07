namespace ibrahimEzzat_C42_EngyoussefZakriaa_MVC02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("Hello from Home page!");
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Product", async context =>
                {
                    await context.Response.WriteAsync("Hello from Product page!");
                });
            });
            app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Your Requsted Page Not Found !!"); });
            // app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
