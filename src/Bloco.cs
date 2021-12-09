
using System;
using Spectre.Console;
using Spectre.Console.Rendering;
using System.Threading;
using System.IO;
using System.Text;

namespace src
{
    public class Bloco : Material
    {

        
        private int quantidadeblocos;
        private int blocosserrados;
        private string arquivo;


        public Bloco(int id, string mat, int cla, string arq) : base(id, mat, cla)
        {


            quantidadeblocos = 0;
            blocosserrados = 0;
            arquivo = arq;

        }
        public void EntradaBloco(int qtd)
        {

            quantidadeblocos = quantidadeblocos + qtd;
            FileStream meuArq = new FileStream( @$"arquivos\{arquivo}" , FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);

            int valor = quantidadeblocos;
            sw.WriteLine(valor);
            
            sw.Close();
            meuArq.Close();

            AnsiConsole.Status()
             .Start("Adicionando blocos ao estoque", ctx =>
              {
               // Simulate some work
               
               Thread.Sleep(2500);
               AnsiConsole.MarkupLine($"[grey bold][yellow]{qtd}[/] bloco(s) de [yellow]{getMaterial()}[/] adicionados com sucesso![/]");
              });
        }
        public void serrada(int qtd)
        {

            blocosserrados = blocosserrados + qtd;


        }

    }
}