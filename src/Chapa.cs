using System;
using Spectre.Console;
using System.Threading;
using System.IO;
using System.Text;
using Spectre.Console.Rendering;

namespace src
{
    public class Chapa : Material
    {


        private int chapa;
        private float preco;
        private int chapaquebrada;
        private int chapavendida;
        private string arquivoprod;
        private string arquivoquebra;
        private string arquivovenda;

        public Chapa(int id, string mat, int cla, float pr, string arqp, string arqq, string arqv) : base(id, mat, cla)
        {

            chapa = 0;
            preco = pr;
            chapaquebrada = 0;
            chapavendida = 0;
            arquivoprod = arqp;
            arquivoquebra = arqq;
            arquivovenda = arqv;

        }
        public void setchapas()
        {
            //chapa
            FileStream arqprod   = new FileStream(@$"arquivos\{arquivoprod}", FileMode.Open, FileAccess.Read);
            FileStream arqquebra = new FileStream( @$"arquivos\{arquivoquebra}", FileMode.Open, FileAccess.Read);
            FileStream arqvenda  = new FileStream(@$"arquivos\{arquivovenda}", FileMode.Open, FileAccess.Read);
            StreamReader prod    = new StreamReader(arqprod, Encoding.UTF8);
            StreamReader quebra  = new StreamReader(arqquebra, Encoding.UTF8);
            StreamReader venda   = new StreamReader(arqvenda, Encoding.UTF8);
            
            
            int chapaprod = Convert.ToInt16(prod.ReadLine());
            prod.Close();
            arqprod.Close();
            chapa = chapaprod; 
            
            int chapaquebra = Convert.ToInt16(quebra.ReadLine());
            quebra.Close();
            arqquebra.Close();
            chapaquebrada = chapaquebra;             

            int chapavenda = Convert.ToInt16(venda.ReadLine());
            venda.Close();
            arqvenda.Close();
            chapavendida = chapavenda;                         
            
        }
        public void QuebraDeChapas( int ar)
        {
            chapa = chapa - ar;
            chapaquebrada = chapaquebrada + ar;

            FileStream arqprod = new FileStream( @$"arquivos\{arquivoprod}" , FileMode.Open, FileAccess.Write);
            StreamWriter prod = new StreamWriter(arqprod, Encoding.UTF8);
            
            FileStream arqquebra = new FileStream( @$"arquivos\{arquivoquebra}" , FileMode.Open, FileAccess.Write);
            StreamWriter quebra = new StreamWriter(arqquebra, Encoding.UTF8);
            
            float produzido = chapa;
            float quebrado =  chapaquebrada ;
            
            prod.WriteLine(produzido);
            prod.Close();
            arqprod.Close();
            quebra.WriteLine(quebrado);
            quebra.Close();
            arqquebra.Close();            
            
            AnsiConsole.Status()
             .Start("Registrando quebra de chapas", ctx =>
              {
               // Simulate some work
               
               Thread.Sleep(2500);
               AnsiConsole.MarkupLine($"[grey bold]Quebra de [yellow]{ar}[/] chapas(s) de [yellow]{getMaterial()}[/] registrada com sucesso![/]");
              });

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

            String unicodeString = $"[grey bold]Serrada concluída com sucesso! ✅[/]";
            return unicodeString;
        }        
        public void serrada(int ar)
        {
            
            chapa = chapa + ar;
            
            FileStream meuArq = new FileStream( @$"arquivos\{arquivoprod}" , FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);

            float chapaprod = chapa;
            sw.WriteLine(chapaprod);
            
            sw.Close();
            meuArq.Close();


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
               var task2 = ctx.AddTask("[green]Baixando blocos no estoque[/]");
               var task3 = ctx.AddTask("[green]Incluindo chapas no estoque[/]");

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
        public void saidaChapa(int ar){

            chapa = chapa - ar;
            chapavendida = chapa + ar;
            
            FileStream arqprod = new FileStream( @$"arquivos\{arquivoprod}" , FileMode.Open, FileAccess.Write);
            StreamWriter prod = new StreamWriter(arqprod, Encoding.UTF8);
            
            FileStream arqqvenda = new FileStream( @$"arquivos\{arquivovenda}" , FileMode.Open, FileAccess.Write);
            StreamWriter quebra = new StreamWriter(arqqvenda, Encoding.UTF8);
            
            float produzido = chapa;
            float vendido =  chapavendida ;

        }       
        public string getArqProd(){

            return arquivoprod;
        }          
        public int getchapaDisp(){

            return chapa;
        }
    }
}   