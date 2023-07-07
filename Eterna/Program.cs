using Eterna;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EternaDbContext>(opt =>
{
    opt.UseSqlServer("Server=SHALALA\\SADB;Database=EternaDb;Trusted_Connection=true;");
});

var app = builder.Build();

app.MapControllerRoute(
        "default",
        "{controller=home}/{action=index}"
    );
app.UseStaticFiles();
app.Run();
