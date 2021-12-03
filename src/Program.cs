using System;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace src
{
    public static class Program
    {
        public static void Main()
        {

            int menuinicial = 0;

            // Render panel borders
            Header("Rocks's Storage");
            MenuADM();
            Console.WriteLine("Digite a opção desejada");
            menuinicial = int.Parse(Console.ReadLine());



            // Render panel borders
            Header("Rocks's Storage");
            MenuInicial();
            

        }


        ////////////Front Console//////////
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
                return new Panel($"\n1 - Administrador\n" +
                                  "2 - Cliente")
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
                    new Padding(2, 0, 0, 0)));
        }
        private static void MenuADM()
        {


            static IRenderable CreatePanel(string name, BoxBorder border)
            {
                return new Panel($"\n1 - Entrada de Blocos\n" +
                                  "2 - Serrada\n" +
                                  "3 - Quebra de Chapas\n" +
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
                    new Padding(2, 0, 0, 0)));
        }
        private static void MenuCliente()
        {


            static IRenderable CreatePanel(string name, BoxBorder border)
            {
                return new Panel($"\n1 - Comprar\n" +
                                  "2 - Serrada\n" +
                                  "3 - Quebra de Chapas\n" +
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
                    new Padding(2, 0, 0, 0)));
        }

    }
}
