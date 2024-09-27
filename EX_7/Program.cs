using Microsoft.EntityFrameworkCore;
using EX_7.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicionar o LivroContext ao contêiner de dependências
builder.Services.AddDbContext<LivroContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();

var app = builder.Build();

// Migrar o banco de dados automaticamente na inicialização
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<LivroContext>();
    context.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
