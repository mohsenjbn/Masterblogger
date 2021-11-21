
using BL.Infrastracture.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Bootstraper.config(builder.Services, builder.Configuration.GetConnectionString("MasterBlogerDB"));
builder.Services.AddRazorPages();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapDefaultControllerRoute();

app.Run();
