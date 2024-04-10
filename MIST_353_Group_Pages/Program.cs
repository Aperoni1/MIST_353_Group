using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;
using MIST_353_Group_API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContextClass>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Register custom services
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<IParkStatusService, ParkStatusService>();


// Add Razor Pages services
builder.Services.AddRazorPages();

//Add HTTP Client
builder.Services.AddHttpClient();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapRazorPages();

app.Run();
