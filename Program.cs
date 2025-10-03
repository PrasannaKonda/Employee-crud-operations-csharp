using MyFirstApp.Models;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();
//builder.Services.AddControllersWithViews().AddXmlSerializerFormatters();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
var app = builder.Build();
var logger = app.Logger;

var myValue = builder.Configuration["MyKey"];

app.UseStaticFiles();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");


//app.MapGet("/", async context =>
//{
//    await context.Response.WriteAsync("Hello from 3rd middleware");
//    logger.LogInformation("MW3: request handled and response produced");
//});

//app.MapGet("",async context =>
//{
//    throw new Exception("Some error processing the request");
//    await context.Response.WriteAsync("Hello from 3rd middleware");
    
//});


//app.MapGet("/", () => "Hello World!");
//app.MapGet("/",() =>  "Hello World! ");

app.Run();
