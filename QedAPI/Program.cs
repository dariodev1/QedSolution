using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();



app.MapGet("/", () => "Hello World!");

app.MapGet("/addNumbers/{number1,number2}", async (string number1, string number2) =>
{
    int num1 = int.Parse(number1);
    int num2 = int.Parse(number2);
    await Task.Delay(5000);
    return num1 + num2;
});

app.Run();
