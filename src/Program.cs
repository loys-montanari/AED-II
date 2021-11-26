using Spectre.Console.Rendering;

namespace Spectre.Console.Examples
{
    public static class Program
    {
        public static void Main()
        {
            int menuincial;

            // Render panel borders
            Header("Rocks's Storage");
            MenuInicial();
            

        }
        private static void Header(string title)
        {
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule($"[white bold]{title}[/]").RuleStyle("grey").LeftAligned());
            AnsiConsole.WriteLine();
        }
        private static void MenuInicial()
        {
           
            
            static IRenderable CreatePanel(string name, BoxBorder border)
            {
                return new Panel($"1 - Entrada de Blocos\n"+
                                  "2 - Produção de chapas\n"+
                                  "3 - Serrada\n"+
                                  "4 - Relatórios")
                    .Header($" [blue]{name}[/] ", Justify.Center)
                    .Border(border)
                    .BorderStyle(Style.Parse("grey"));
            }

            var items = new[]
            {

                CreatePanel("Menu", BoxBorder.Square),

            };

            AnsiConsole.Write(
                new Padder(
                    new Columns(items).PadRight(2),
                    new Padding(2,0,0,0)));
        }

    }
}