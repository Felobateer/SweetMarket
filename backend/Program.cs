using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Database;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.HttpsPolicy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Configuration.AddJsonFile("appsettings.json");

// Retrieve the connection string from appsettings.json
string connectionString = builder.Configuration.GetConnectionString("Default");

// Check if the connectionString is null or empty before registering it as a singleton
if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddSingleton(connectionString);
    builder.Services.AddSingleton<MyDb>();
    builder.Services.AddScoped<MyServices>(); 
}
else
{
    // Log or handle the error when connectionString is null or empty
    Console.WriteLine("Error: Connection string is null or empty.");
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseCors(builder => builder
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

