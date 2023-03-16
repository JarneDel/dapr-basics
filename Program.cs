var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hw", () => "Hello root World!");
app.MapGet("/helloworld", () => "Hello World!");

app.Run();
