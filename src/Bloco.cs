
using System;
using Spectre.Console;
using Spectre.Console.Rendering;
using System.Threading;

namespace src
{
    public class Bloco : Material
    {

        private float metroscubicos;
        private int quantidadeblocos;
        private int blocosserrados;



        public Bloco(int id, string mat, int cla) : base(id, mat, cla)
        {


            metroscubicos = 0;
            quantidadeblocos = 0;
            blocosserrados = 0;


        }
        public void EntradaBloco(float m3, int qtd)
        {

            metroscubicos = metroscubicos + m3;
            quantidadeblocos = quantidadeblocos + qtd;

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