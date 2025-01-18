using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/calculate", async (HttpContext context) =>
{
    var formData = await context.Request.ReadFromJsonAsync<CalculationRequest>();
    if (formData == null)
        return Results.BadRequest("Invalid data");

    double result = formData.Operation switch
    {
        "Add" => formData.Number1 + formData.Number2,
        "Subtract" => formData.Number1 - formData.Number2,
        "Multiply" => formData.Number1 * formData.Number2,
        "Divide" => formData.Number2 != 0 ? formData.Number1 / formData.Number2 : throw new DivideByZeroException(),
        _ => throw new ArgumentException("Invalid operation")
    };

    return Results.Json(new { Result = result });
});

app.Run();

public record CalculationRequest(double Number1, double Number2, string Operation);
