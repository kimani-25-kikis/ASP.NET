var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", () => "Joshua You are now heading in a positive way, keep going");
app.Run();