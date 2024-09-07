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

        /*    app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Product", async context =>
                {
                    await context.Response.WriteAsync("Hello from Product page!");
                });
            });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Product/{ID :int?}", async context =>
                {
                    var id = context.Request.RouteValues["ID"];
                    if(id != null)
                    {
                        Convert.ToInt32(id);
                        await context.Response.WriteAsync($"Hello from Product page id => {id}");
                    }
                    else
                    {
                        await context.Response.WriteAsync("Hello from Product page!");

                    }
                    
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Books/{id :int}/{Author}", async context =>
                {
                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                    string name = context.Request.RouteValues["Author"].ToString();
                    await context.Response.WriteAsync($"Hello from Books page id => {id} name=>{name}");
                });
            });
            app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Your Requsted Page Not Found !!"); });
            // app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
