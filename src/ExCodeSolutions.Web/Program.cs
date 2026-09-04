using ExCodeSolutions.Web.Components;
using MudBlazor.Services;

namespace ExCodeSolutions.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configuración inicial
            var builder = WebApplication.CreateBuilder(args);

            // Registro de servicios
            builder.Services
                .AddRazorComponents()
                .AddInteractiveServerComponents();

            // Servicios MudBlazor
            builder.Services.AddMudServices();

            // Construir aplicación
            var app = builder.Build();

            // Seguridad en producción
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // Pipeline HTTP
            app.UseStatusCodePagesWithReExecute(
                "/not-found",
                createScopeForStatusCodePages: true);

            app.UseHttpsRedirection();
            app.UseAntiforgery();

            // Archivos estáticos
            app.MapStaticAssets();

            // Componentes Razor
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            // Iniciar aplicación
            app.Run();
        }
    }
}