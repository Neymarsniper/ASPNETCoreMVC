using ASP_Core_Empty.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//These below lines of code represents the Connection building for EF Core to SSMS
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>(); // IConfiguration is the generic method
builder.Services.AddDbContext<StudentDBContext>(item => item.UseSqlServer(config.GetConnectionString("dbcs"))); 

var app = builder.Build();

app.MapDefaultControllerRoute();
app.MapControllerRoute(
  name: "default",
 pattern: "{Controller=Home}/{action=Index}/{id?}"
   );

app.MapControllers();

app.UseStaticFiles();


//app.UseRouting();
//app.UseEndpoints(endpoints => 
//{
//    endpoints.MapGet("/Home", async (context) => 
//    {
//        await context.Response.WriteAsync("this is GetHome page..");
//    });
//    endpoints.MapPost("/Home", async (context) =>
//    {
//        await context.Response.WriteAsync("this is PostHome page..");
//    });
//    endpoints.MapPut("/Home", async (context) =>
//    {
//        await context.Response.WriteAsync("this is PutHome page..");
//    });
//    endpoints.MapDelete("/Home", async (context) =>
//    {
//        await context.Response.WriteAsync("this is DeleteHome page..");
//    });
//});
//app.Run(async(HttpContext context) =>
//{
//    await context.Response.WriteAsync("Page not found..");
//});




//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World!");
//app.MapPost("/Home", () => "Hello World!");
//app.MapPut("/Home", () => "Hello World!");
//app.MapDelete("/Home", () => "Hello World!");
//app.Use(async(context, next) =>
//{
//    await context.Response.WriteAsync("Welcome Sir");
//    await next(context);
//});
//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("Home Sweet home");
//    await next(context);
//});
app.Run();
