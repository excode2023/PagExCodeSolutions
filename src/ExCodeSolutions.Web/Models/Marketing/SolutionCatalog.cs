using ExCodeSolutions.Web.Models.Marketing;
using MudBlazor;

namespace ExCodeSolutions.Web.Content.Marketing;

/// <summary>
/// Contenido comercial utilizado por el catálogo de la página principal.
/// Estas entradas describen tipos de soluciones personalizables,
/// no productos terminados ni funcionalidades de backend.
/// </summary>
public static class SolutionCatalog
{
    private static readonly IReadOnlyList<SolutionItem> Items =
    [
        new()
        {
            Id = "process-automation",
            Category = SolutionCategory.PointProblem,
            Icon = Icons.Material.Filled.AutoMode,
            Title = "Automatización de procesos",
            Summary = "Reduce tareas manuales y repetitivas dentro de tu operación.",
            Description =
                "Analizamos un proceso específico de tu empresa y diseñamos " +
                "una solución que reduzca pasos manuales, errores y tiempos de espera.",
            Benefits =
            [
                "Menos trabajo repetitivo",
                "Reducción de errores humanos",
                "Mayor trazabilidad del proceso"
            ],
            UseCases =
            [
                "Registro de solicitudes",
                "Generación de documentos",
                "Notificaciones y seguimiento"
            ]
        },

        new()
        {
            Id = "system-integration",
            Category = SolutionCategory.PointProblem,
            Icon = Icons.Material.Filled.SyncAlt,
            Title = "Integración entre sistemas",
            Summary = "Conecta herramientas y evita registrar la misma información varias veces.",
            Description =
                "Diseñamos integraciones para que diferentes aplicaciones puedan " +
                "intercambiar información de manera controlada y confiable.",
            Benefits =
            [
                "Información más consistente",
                "Menos duplicación de datos",
                "Procesos conectados"
            ],
            UseCases =
            [
                "Conexión con APIs",
                "Sincronización de datos",
                "Integración con servicios externos"
            ]
        },

        new()
        {
            Id = "custom-management-system",
            Category = SolutionCategory.CompleteSystem,
            Icon = Icons.Material.Filled.DashboardCustomize,
            Title = "Sistema de gestión a medida",
            Summary = "Centraliza procesos, usuarios e información en una sola plataforma.",
            Description =
                "Diseñamos un sistema adaptado al funcionamiento real de la empresa, " +
                "sus usuarios, reglas de negocio y necesidades de crecimiento.",
            Benefits =
            [
                "Información centralizada",
                "Procesos más claros",
                "Crecimiento progresivo"
            ],
            UseCases =
            [
                "Inventario y logística",
                "Ventas y presupuestos",
                "Gestión interna"
            ]
        },

        new()
        {
            Id = "business-portal",
            Category = SolutionCategory.CompleteSystem,
            Icon = Icons.Material.Filled.Web,
            Title = "Portal empresarial",
            Summary = "Ofrece a clientes o colaboradores un espacio digital organizado.",
            Description =
                "Creamos portales para consultar información, registrar solicitudes " +
                "y realizar operaciones relacionadas con tu negocio.",
            Benefits =
            [
                "Atención disponible en línea",
                "Menos carga administrativa",
                "Mejor experiencia de usuario"
            ],
            UseCases =
            [
                "Portal de clientes",
                "Área de colaboradores",
                "Seguimiento de solicitudes"
            ]
        },

        new()
        {
            Id = "ai-assistant",
            Category = SolutionCategory.ArtificialIntelligence,
            Icon = Icons.Material.Filled.SmartToy,
            Title = "Asistente inteligente",
            Summary = "Facilita consultas y acceso a información mediante lenguaje natural.",
            Description =
                "Evaluamos si un asistente con inteligencia artificial puede aportar " +
                "valor real antes de incorporarlo a los procesos de la empresa.",
            Benefits =
            [
                "Consultas más rápidas",
                "Acceso sencillo a información",
                "Disponibilidad ampliada"
            ],
            UseCases =
            [
                "Preguntas frecuentes",
                "Asistencia interna",
                "Orientación inicial al cliente"
            ]
        },

        new()
        {
            Id = "intelligent-classification",
            Category = SolutionCategory.ArtificialIntelligence,
            Icon = Icons.Material.Filled.FactCheck,
            Title = "Clasificación inteligente",
            Summary = "Organiza solicitudes o documentos utilizando criterios automatizados.",
            Description =
                "Analizamos información recibida y evaluamos mecanismos inteligentes " +
                "para clasificarla, priorizarla o dirigirla al proceso correcto.",
            Benefits =
            [
                "Respuesta inicial más rápida",
                "Información mejor organizada",
                "Priorización consistente"
            ],
            UseCases =
            [
                "Clasificación de consultas",
                "Organización de documentos",
                "Distribución de solicitudes"
            ]
        }
    ];

    /// <summary>
    /// Devuelve únicamente las soluciones de la categoría seleccionada.
    /// </summary>
    public static IReadOnlyList<SolutionItem> GetByCategory(
        SolutionCategory category)
    {
        return Items
            .Where(item => item.Category == category)
            .ToList();
    }
}