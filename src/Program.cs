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
            Bloco BlocoAurora  = new Bloco(1, "Aurora Boreale", 3, "BlocoAurora.txt");
            Bloco BlocoBlack   = new Bloco(2, "Black Brasil"  , 1, "BlocoBlack.txt");
            Bloco BlocoGreen   = new Bloco(3, "Green Ubatuba" , 2, "BlocoGreen.txt");
            Bloco BlocoGrey    = new Bloco(4, "Grey Goose"    , 2, "BlocoGrey.txt");
            Bloco BlocoItaunas = new Bloco(5, "Itaunas"       , 1, "BlocoItaunas.txt");
            Bloco BlocoPerla   = new Bloco(6, "Perla Venata"  , 3, "BlocoPerla.txt");

            //cadastro de chapas
            Chapa ChapaAurora  = new Chapa(1, "Aurora Boreale", 3, 150f, "ChapaAuroraProd.txt",  "ChapaAuroraQuebra.txt",  "ChapaAuroraVenda.txt");
            Chapa ChapaBlack   = new Chapa(1, "Black Brasil"  , 1,  30f, "ChapaBlackProd.txt",   "ChapaBlackQuebra.txt",   "ChapaBlackVenda.txt");
            Chapa ChapaGreen   = new Chapa(1, "Green Ubatuba" , 2,  80f, "ChapaGreenProd.txt",   "ChapaGreenQuebra.txt",   "ChapaGreenVenda.txt");
            Chapa ChapaGrey    = new Chapa(1, "Grey Goose"    , 2, 100f, "ChapaGreyProd.txt",    "ChapaGreyQuebra.txt",    "ChapaGreyVenda.txt");
            Chapa ChapaItaunas = new Chapa(1, "Itaunas"       , 1,  28f, "ChapaItaunasProd.txt", "ChapaItaunasQuebra.txt", "ChapaItaunasVenda.txt");
            Chapa ChapaPerla   = new Chapa(1, "Perla Venata"  , 3, 120f, "ChapaPerlaProd.txt",   "ChapaPerlaQuebra.txt",   "ChapaPerlaVenda.txt");
            
            //cadastro de serrada
            Serrada SerradaAurora  = new Serrada(1, "Aurora Boreale", 3,  "MultiFio",          105f);
            Serrada SerradaBlack   = new Serrada(1, "Black Brasil"  , 1,  "Tear Convencional",  32f);
            Serrada SerradaGreen   = new Serrada(1, "Green Ubatuba" , 2,  "Tear Convencional",  19f);
            Serrada SerradaGrey    = new Serrada(1, "Grey Goose"    , 2,  "MultiFio",           80f);
            Serrada SerradaItaunas = new Serrada(1, "Itaunas"       , 1,  "Tear Convencional",  32f);
            Serrada SerradaPerla   = new Serrada(1, "Perla Venata"  , 3,  "MultiFio",          105f);

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
                      int qtd;
                      AnsiConsole.MarkupLine("\n[grey bold]ENTRADA DE BLOCOS[/]\n");
                      Console.WriteLine("Escolha o material do bloco.");
                      escolhamaterial = EscolhaMaterial();
                      Console.WriteLine($"\nQuantos blocos de {escolhamaterial} deseja adicionar?");
                      qtd = int.Parse(Console.ReadLine());


                      if (escolhamaterial == "Aurora Boreale") //Aurora Boreal
                      {
                          BlocoAurora.EntradaBloco(qtd);
                      }     
                      else if (escolhamaterial == "Black Brasil") //Black Brasil
                      {
                          BlocoBlack.EntradaBloco(qtd);
                      }        
                      else if (escolhamaterial == "Green Ubatuba") //Green Ubatuba
                      {
                          BlocoGreen.EntradaBloco(qtd);
                      } 
                      else if (escolhamaterial == "Grey Goose") //Grey Goose
                      {
                          BlocoGrey.EntradaBloco(qtd);
                      }
                      else if (escolhamaterial == "Itaúnas") //Itaunas
                      {
                          BlocoItaunas.EntradaBloco(qtd);
                      }
                      else if (escolhamaterial == "Perla Venata") //Perla Venata
                      {
                          BlocoPerla.EntradaBloco(qtd);
                      }
                   }
                   else if (menuadm == "Serrada")
                   {
                      string escolhamaterial;
                      int qtd;
                      float ar;
                      AnsiConsole.MarkupLine("\n[grey bold]SERRADA DE BLOCOS[/]\n");
                      Console.WriteLine("Escolha o material do bloco que deseja serrar.");
                      escolhamaterial = EscolhaMaterial();
                      Console.WriteLine($"\nQuantos blocos de {escolhamaterial} serão serrados?");
                      qtd = int.Parse(Console.ReadLine());
                      Console.WriteLine("\nQuantos M² de chapas serão gerados?");
                      ar = float.Parse(Console.ReadLine());
                      
                      if (escolhamaterial == "Aurora Boreale") //Aurora Boreal
                      {
                          BlocoAurora.serrada(qtd);
                          ChapaAurora.serrada(ar);
                          SerradaAurora.serrada(ar);
                      }     
                      else if (escolhamaterial == "Black Brasil") //Black Brasil
                      {
                          BlocoBlack.serrada(qtd);
                          ChapaBlack.serrada(ar);
                          SerradaBlack.serrada(ar);
                      }        
                      else if (escolhamaterial == "Green Ubatuba") //Green Ubatuba
                      {
                          BlocoGreen.serrada(qtd);
                          ChapaGreen.serrada(ar);
                          SerradaGreen.serrada(ar);
                      } 
                      else if (escolhamaterial == "Grey Goose") //Grey Goose
                      {
                          BlocoGrey.serrada(qtd);
                          ChapaGrey.serrada(ar);
                          SerradaGrey.serrada(ar);
                      }
                      else if (escolhamaterial == "Itaúnas") //Itaunas
                      {
                          BlocoItaunas.serrada(qtd);
                          ChapaItaunas.serrada(ar);
                          SerradaItaunas.serrada(ar);
                      }
                      else if (escolhamaterial == "Perla Venata") //Perla Venata
                      {
                          BlocoPerla.serrada(qtd);
                          ChapaPerla.serrada(ar);
                          SerradaPerla.serrada(ar);
                      }

                   }                  
                   else if (menuadm == "Quebra de Chapas")
                   {
                      string escolhamaterial;
                      float ar;
                      AnsiConsole.MarkupLine("\n[grey bold]REGISTRO DE QUEBRA DE CHAPAS[/]\n");
                      Console.WriteLine("Escolha o material das chapas quebradas.");
                      escolhamaterial = EscolhaMaterial();
                      Console.WriteLine("\nQuantos M² de chapas foram quebrados?");
                      ar = float.Parse(Console.ReadLine());
                      
                      if (escolhamaterial == "Aurora Boreale") //Aurora Boreal
                      {

                          ChapaAurora.QuebraDeChapas(ar);

                      }     
                      else if (escolhamaterial == "Black Brasil") //Black Brasil
                      {

                          ChapaBlack.QuebraDeChapas(ar);
                          
                      }        
                      else if (escolhamaterial == "Green Ubatuba") //Green Ubatuba
                      {
                          
                          ChapaGreen.QuebraDeChapas(ar);
                          
                      } 
                      else if (escolhamaterial == "Grey Goose") //Grey Goose
                      {
                          
                          ChapaGrey.QuebraDeChapas(ar);
                          
                      }
                      else if (escolhamaterial == "Itaúnas") //Itaunas
                      {
                          
                          ChapaItaunas.QuebraDeChapas(ar);
                          
                      }
                      else if (escolhamaterial == "Perla Venata") //Perla Venata
                      {
                          
                          ChapaPerla.QuebraDeChapas(ar);
                          
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
