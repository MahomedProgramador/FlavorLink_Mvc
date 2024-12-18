using DataMsSql;
using IOC;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

ConfigureServices.ConfigureWebApp(builder.Services);

builder.Services.AddSession(options =>
{
    options.Cookie.Name = "Belgas";
    options.IdleTimeout = TimeSpan.FromHours(1);
    options.Cookie.IsEssential = true;
    
});

builder.Services.AddHttpContextAccessor();
var app = builder.Build();


app.UseSession(); 

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


app.MapRazorPages();

app.Run();
