using System;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace src
{
    public static class Program
    {
        public static void Main()
        {
            //cadastro de produtos

            Chapa granito_itaunas = new Chapa(1, "Itaunas", 1, 26f);

            ListaCompras lista = new ListaCompras();


            //Menu();
            // // Render panel borders
            Header("Rocks's Storage");
            granito_itaunas.serrar(300f);




            // // Render panel borders

            // MenuInicial();
            // for (int i = 1; i <= 10; i++)
            // {
            //     lista.adicionar(granito_itaunas);
            // }
            //  lista.carrinhonovo();


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

        private static void Menu()
        {
            var favorites = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("O que deseja fazer?")
            .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
            //.InstructionsText("[grey](Aperte [blue]<espaço>[/] para selecionar, [green]<enter>[/] to accept)[/]")
            .AddChoices(new[]
                            {
                                  "Entrada de Blocos", "Serrada", "Quebra de Chapas", "Relatórios",

                             }));
        }
        private static string MenuInicio()
        {
           
        
            var escolha = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("")
            //.InstructionsText("[grey](Aperte [green]<enter>[/] para selecionar uma opção![/]")
            .AddChoices(new[]
                            {
                                  "Administrador", "Cliente"

                             }));

             AnsiConsole.Write(
                new Panel(
                    new Panel($"Seja bem vindo [B][Blue]{escolha}[/][/]")
                        .Border(BoxBorder.Ascii)));                 
             
             return escolha;


        }


    }
}
