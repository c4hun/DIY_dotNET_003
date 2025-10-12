using Todo.Repositories;  // Pour IUserRepository
using Todo.Services;  // Pour AuthService

var builder = WebApplication.CreateBuilder(args);

// Enregistrer les services de Todo dans l'injection de dépendances
builder.Services.AddScoped<AuthService>();  // Si AuthService est dans Todo.Services
builder.Services.AddScoped<IUserRepository, InMemoryUserRepository>();  // Exemple pour IUserRepository

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
