//The main difference between MVC and Razor Pages is that in MVC we have models, views and controllers but in Razor Pages we only have Pages which perform all the functionality

//Razor Pages are somewhat similar to old .net dev where one file contains both frontend and backend.
using Microsoft.EntityFrameworkCore;
using Razor.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//In MVX there are ControllersWithViews in services
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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

app.UseAuthorization();

//In Razor pages, we don't have any controllers
//In MVC the URL was like home/Privacy but now in the Razor Pages the URL is /privacy
//Whatever is there in the Pages folder will be the route

//We have added a new page called Categories, we can access it on the following path serverPath/Categories/index or
// serverPath/Categoires only
app.MapRazorPages();

app.Run();


//Steps to run it 

//1- Install the following NuGet Packages Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer,
//Microsoft.EntityFrameworkCore.Tools, Microsoft.VisualStudio.Web.CodeGeneration.Design