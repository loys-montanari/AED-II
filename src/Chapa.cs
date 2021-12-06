using System;
using Spectre.Console;
using System.Threading;

namespace src
{
    public class Chapa : Material
    {


        private float area;
        private float preco;
        private int quantidadechapas;
        private int chapasquebradas;
        private float areaquebrada;
        private float areavendida;
        private int chapasvendidas;

        public Chapa(int id, string mat, int cla, float pr) : base(id, mat, cla)
        {

            area = 0;
            preco = pr;
            quantidadechapas = 0;
            chapasquebradas = 0;
            areaquebrada = 0;
            areavendida = 0;
            chapasvendidas = 0;

        }
        public void EntradaChapas(int qtd, float ar)
        {

            quantidadechapas = quantidadechapas + qtd;
            area = area + ar;
        }
        public void QuebraDeChapas(int qtd, float ar)
        {
            area = area - ar;
            areaquebrada = areaquebrada + ar;
            quantidadechapas = quantidadechapas - qtd;
            chapasquebradas = chapasquebradas + qtd;

        }
        public string chapacarrinho()
        {

            string prodcarrinho = (getMaterial() + "  R$" + preco);
            return prodcarrinho;
        }
        public float getPreco(){

            return preco;
        }
       public string iconeserrada()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            String unicodeString = $"[green]Serrada concluída com sucesso! ✅[/]";
            return unicodeString;
        }        
        public void serrar(float ar)
        {

            area = area + ar;

            AnsiConsole.MarkupLine("[grey]Aguarde enquanto processamos sua solicitação![/]");
            AnsiConsole.Progress()
                       .AutoClear(false)
                       .Columns(new ProgressColumn[]
                       {
                    new TaskDescriptionColumn(),    // Task description
                    new ProgressBarColumn(),        // Progress bar
                    new PercentageColumn(),         // Percentage
                    new RemainingTimeColumn(),      // Remaining time
                    new SpinnerColumn(),            // Spinner
                       })
           .Start(ctx =>
           {
               // Define tasks
               var task1 = ctx.AddTask("[green]Criando serrada[/]");
               var task2 = ctx.AddTask("[green]Serrando seu bloco[/]");
               var task3 = ctx.AddTask($"[green]Gerando {ar}m² de chapas[/]");

               while (!ctx.IsFinished)
               {
                   task1.Increment(5.5);
                   task2.Increment(4);
                   task3.Increment(3.5);

                   Thread.Sleep(100);
               }

           });
            AnsiConsole.MarkupLine(iconeserrada());
        }        
        public void saidaChapa(float ar, int qtd){

            area = area - ar;
            areavendida = area + ar;
            quantidadechapas = quantidadechapas - qtd;
            chapasvendidas = chapasvendidas + qtd;

        } 
    }
}