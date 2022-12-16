using Core.Entities.Models;
using Core.Repository.Data;
using Core.Repository.Repository;
using Core.Service.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<ApplicationDbContext>();
string connString = builder.Configuration.GetConnectionString("connMSSQLNoCred");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connString, x => x.MigrationsAssembly("Core.Repository")));

builder.Services.AddTransient<IRepository<Categories>, Repository<Categories>>();
builder.Services.AddTransient<ICategoriesService, CategoriesService>();

builder.Services.AddTransient<IRepository<Branch>, Repository<Branch>>();
builder.Services.AddTransient<IBranchService, BranchService>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
