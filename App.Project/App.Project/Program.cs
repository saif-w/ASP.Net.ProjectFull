using App.Project.Serviecs;
using APP.Project.Buisness.Infstracter;
using APP.Project.Buisness.Serviecs;
using APP.Project.DataAccess.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);



//add ConnectionString
builder.Services.AddDbContext<HRDBContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("HRConnectionString")));
builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmployeesServices, EmployeeServices>(); builder.Services.AddControllersWithViews();

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
