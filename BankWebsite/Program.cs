using BankWedsite.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(options =>
{
	options.Conventions.AddPageRoute("/Loginpage", "");
});

var app = builder.Build();
app.UseStaticFiles();

Database.Instans = new Database();

app.MapRazorPages();
app.Run();