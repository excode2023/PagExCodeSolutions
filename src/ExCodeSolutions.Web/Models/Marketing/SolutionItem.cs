namespace ExCodeSolutions.Web.Models.Marketing;

/// <summary>
/// Contiene la información que necesita una solución
/// para mostrarse en el catálogo y en su ventana de detalles.
/// </summary>
public sealed class SolutionItem
{
    /// <summary>
    /// Identificador único utilizado internamente por la interfaz.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Categoría a la que pertenece la solución.
    /// </summary>
    public required SolutionCategory Category { get; init; }

    /// <summary>
    /// Icono de MudBlazor que se mostrará en la tarjeta.
    /// </summary>
    public required string Icon { get; init; }

    /// <summary>
    /// Nombre comercial de la solución.
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// Descripción corta utilizada en la tarjeta.
    /// </summary>
    public required string Summary { get; init; }

    /// <summary>
    /// Explicación completa utilizada en el diálogo.
    /// </summary>
    public required string Description { get; init; }

    /// <summary>
    /// Beneficios principales que obtiene el cliente.
    /// </summary>
    public IReadOnlyList<string> Benefits { get; init; } = [];

    /// <summary>
    /// Situaciones empresariales donde puede utilizarse.
    /// </summary>
    public IReadOnlyList<string> UseCases { get; init; } = [];
}