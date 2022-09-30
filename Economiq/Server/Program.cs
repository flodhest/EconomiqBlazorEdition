using Economiq.Server.Service;
using Economiq.Server.Data;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EconomiqContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EconomiqContext")));
builder.Services.AddTransient<ExpenseCategoryService>();
builder.Services.AddTransient<ExpenseService>();
builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<RecipientService>();
builder.Services.AddTransient<BudgetService>();

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
