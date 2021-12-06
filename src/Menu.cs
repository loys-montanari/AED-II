using System;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace src
{
      public abstract class Menu 
    {


        
        // public Menu(){
        //     escolha = 0;
        // }
        


        ////////////Front Console//////////

        private static string MenuADM()
        {

        
            var escolha = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("")
            .AddChoices(new[]
                            {
                                  "Entrada de Blocos", "Serrada", "Quebra de Chapas", "Relatórios"

                             }));

             AnsiConsole.Write(
                new Panel(
                    new Panel($"Seja bem vindo [B][Blue]{escolha}[/][/]")
                        .Border(BoxBorder.Ascii)));                 
             
             return escolha;
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
        private static void Menua()
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
             
             int menuinicio;

             if (escolha == "Cliente"){menuinicio = 1;}
             else{menuinicio = 2;}
             return escolha;


        }
        
    }
}