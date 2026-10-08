using MudBlazor;

namespace ExCodeSolutions.Web.Theme
{
    public static class ExCodeTheme
    {
        // Tema principal
        public static MudTheme Default { get; } = new()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#0F4C5C",
                Secondary = "#19A7A0",
                Background = "#F7F9FC",
                Surface = "#FFFFFF",
                TextPrimary = "#17212B"
            }
        };
    }
}