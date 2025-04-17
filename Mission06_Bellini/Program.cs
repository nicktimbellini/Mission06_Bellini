using Microsoft.EntityFrameworkCore;
using Mission06_Bellini.Data; // ? Ensure this matches ApplicationDbContext namespace
using Mission06_Bellini.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=JoelHiltonMovieCollection.sqlite"));

var app = builder.Build();



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
