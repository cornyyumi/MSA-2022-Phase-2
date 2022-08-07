using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using MSA.Phase2.Weatherman.Data;


var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("AppDb");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument(options =>
{
    options.DocumentName = "My Amazing API";
    options.Version = "V1";

});

builder.Services.AddScoped<IWeatherRepo, DBWeatherRepo>(); 
builder.Services.AddDbContext<WeatherDbContext>(options => options.UseSqlite("Data Source=WeatherDatabase.sqlite"));


builder.Services.AddHttpClient("weathermman", configureClient: client =>
{
    client.BaseAddress = new Uri(@"https://api.openweathermap.org");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();