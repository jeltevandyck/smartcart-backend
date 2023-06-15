using System.Text.Json.Serialization;
using EPS.Smartcart.API.Extensions;
using EPS.Smartcart.Application.Extensions;
using EPS.Smartcart.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterApplication();
builder.Services.RegisterInfrastructure();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var domain = $"https://{builder.Configuration["Auth0:Domain"]}/";
var audience = builder.Configuration["Auth0:Audience"];

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //Use urls
    app.Urls.Add("https://localhost:5000");
}
else
{
    app.Urls.Add("http://10.132.0.3:5000");
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseErrorHandlingMiddleware();
app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();

app.Run();