using System;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace src
{
    public static class Program
    {
        public static void Main()
        {
            //cadastro de Materiais
            Material Aurora  = new Material(1, "Aurora Boreale", 3);
            Material Black   = new Material(2, "Black Brasil"  , 1);
            Material Green   = new Material(3, "Green Ubatuba" , 2);
            Material Grey    = new Material(4, "Grey Goose"    , 2);
            Material Itaunas = new Material(5, "Itaunas"       , 1);
            Material Perla   = new Material(6, "Perla Venata"  , 3);

            //cadastro de Blocos
            Bloco BlocoAurora  = new Bloco(1, "Aurora Boreale", 3);
            Bloco BlocoBlack   = new Bloco(2, "Black Brasil"  , 1);
            Bloco BlocoGreen   = new Bloco(3, "Green Ubatuba" , 2);
            Bloco BlocoGrey    = new Bloco(4, "Grey Goose"    , 2);
            Bloco BlocoItaunas = new Bloco(5, "Itaunas"       , 1);
            Bloco BlocoPerla   = new Bloco(6, "Perla Venata"  , 3);

            //cadastro de chapas
            Chapa ChapaAurora  = new Chapa(1, "Aurora Boreale", 3, 150f);
            Chapa ChapaBlack   = new Chapa(1, "Black Brasil"  , 1,  30f);
            Chapa ChapaGreen   = new Chapa(1, "Green Ubatuba" , 2,  80f);
            Chapa ChapaGrey    = new Chapa(1, "Grey Goose"    , 2, 100f);
            Chapa ChapaItaunas = new Chapa(1, "Itaunas"       , 1,  28f);
            Chapa ChapaPerla   = new Chapa(1, "Perla Venata"  , 3, 120f);
            

            ListaCompras lista = new ListaCompras();


            //Menu();
            // // Render panel borders
            Header("Rocks's Storage");
            //granito_itaunas.serrar(300f);




            // // Render panel borders
             string menuinicio, menucliente, menuadm;
             menuinicio = MenuInicio();

             if (menuinicio == "Administrador"){
                   
                   menuadm =  MenuAdministrador();
                   if (menuadm == "Entrada de Blocos")    //entrada bloco
                   { 
                      string escolhamaterial;
                      int qtd, m3;
                      AnsiConsole.MarkupLine("\n[grey bold]ENTRADA DE BLOCOS[/]\n");
                      Console.WriteLine("Escolha o material do bloco.");
                      escolhamaterial = EscolhaMaterial();
                      Console.WriteLine($"\nQuantos blocos de {escolhamaterial} deseja adicionar?");
                      qtd = int.Parse(Console.ReadLine());
                      Console.WriteLine("\nQuantos M³ total eles têm?");
                      m3 = int.Parse(Console.ReadLine());

                      if (escolhamaterial == "Aurora Boreale") //Aurora Boreal
                      {
                          BlocoAurora.EntradaBloco(m3, qtd);
                      }     
                      else if (escolhamaterial == "Black Brasil") //Black Brasil
                      {
                          BlocoBlack.EntradaBloco(m3, qtd);
                      }        
                      else if (escolhamaterial == "Green Ubatuba") //Green Ubatuba
                      {
                          BlocoGreen.EntradaBloco(m3, qtd);
                      } 
                      else if (escolhamaterial == "Grey Goose") //Grey Goose
                      {
                          BlocoGrey.EntradaBloco(m3, qtd);
                      }
                      else if (escolhamaterial == "Itaúnas") //Itaunas
                      {
                          BlocoItaunas.EntradaBloco(m3, qtd);
                      }
                      else if (escolhamaterial == "Perla Venata") //Perla Venata
                      {
                          BlocoPerla.EntradaBloco(m3, qtd);
                      }
                   }
                 }
             if (menuinicio == "Cliente"){MenuCliente();
                                   
    
             
             }                 

        }










        ////////////Front Console//////////
        private static void Header(string title)
        {
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule($"[grey bold]{title}[/]").RuleStyle("grey").LeftAligned());
            AnsiConsole.WriteLine();
        }
        private static string MenuAdministrador()
        {
       
            var escolha = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("")
            .AddChoices(new[]
                            {
                                  "Entrada de Blocos", "Serrada", "Quebra de Chapas", "Relatórios"

                             }));
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
         private static string EscolhaMaterial()
        {
           
        
            var escolha = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("")
            .AddChoices(new[]
                            {
                                  "Aurora Boreale", "Black Brasil", "Green Ubatuba", "Grey Goose", "Itaunas", "Perla Venata"

                             }));              
             
             return escolha;


        }

    }
}
