using Economiq.Client;
using Economiq.Client.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("expense", client =>
{
    client.BaseAddress = new Uri($"{builder.Configuration["ApiAdress"]}api/expense/");
});
builder.Services.AddHttpClient("expenseCategory", client =>
{
    client.BaseAddress = new Uri($"{builder.Configuration["ApiAdress"]}api/expenseCategory/");
});
builder.Services.AddHttpClient("user", client =>
{
    client.BaseAddress = new Uri($"{builder.Configuration["ApiAdress"]}api/user/");
});
builder.Services.AddHttpClient("recipient", client =>
{
    client.BaseAddress = new Uri($"{builder.Configuration["ApiAdress"]}api/recipient");
});
builder.Services.AddHttpClient("budget", client =>
{
    client.BaseAddress = new Uri($"{builder.Configuration["ApiAdress"]}api/budget/");
});


builder.Services.AddTransient<RecipientService>();
builder.Services.AddSingleton<ApiService>();
builder.Services.AddSingleton<AppState>();
builder.Services.AddTransient<ExpenseService>();
builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<BudgetService>();
builder.Services.AddTransient<ExpenseCategoryService>();
await builder.Build().RunAsync();
