using Application.Data;
using Application.Repository;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using Ninject;

var builder = WebApplication.CreateBuilder(args);
// var kernel = new StandardKernel();
//
// kernel.Bind<IClassService>().To<ClassService>();
// kernel.Bind<ICourseService>().To<CourseService>();
// kernel.Bind<IStudentService>().To<StudentService>();

builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IClassService, ClassService>();
builder.Services.AddHttpContextAccessor();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

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