using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FiorellaDatabaseP418"));
});
var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();