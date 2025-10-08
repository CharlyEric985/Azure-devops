var builder = WebApplication.CreateBuilder(args);

// Ajouter les services pour les Controllers et Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

// PAS besoin de UseAuthorization pour ce projet simple
// app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pret}/{action=Index}/{id?}");

app.Run();
