using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages(); // Adiciona serviços Razor Pages
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Exibe erros detalhados durante o desenvolvimento
        }
        else
        {
            app.UseExceptionHandler("/Error"); // Redireciona para a página de erro em produção
            app.UseHsts(); // Habilita HTTP Strict Transport Security
        }

        app.UseHttpsRedirection(); // Redireciona para HTTPS
        app.UseStaticFiles(); // Habilita arquivos estáticos

        app.UseRouting(); // Habilita roteamento

        app.UseAuthorization(); // Habilita autorização

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages(); // Mapeia as Razor Pages
        });
    }
}
