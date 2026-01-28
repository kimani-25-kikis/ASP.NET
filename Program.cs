// var builder = WebApplication.CreateBuilder(args);

// var app = builder.Build();
// app.MapGet("/", () => "Joshua You are now heading in a positive way, keep going");
// app.Run();

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.Run(async context =>
// {
//    await context.Response.WriteAsync("Am the admin for this system"); 
// });

// app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async(context, next) =>
{
    await context.Response.WriteAsync("Middleware 1: passing to the next middleware!\r\n");

    await next.Invoke();

    await context.Response.WriteAsync("Hello from middleware 1 again!\r\n");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from middleware 2!\r\n");
});

app.Run();