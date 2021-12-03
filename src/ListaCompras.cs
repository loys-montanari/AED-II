using System.Collections.Generic;
using System;
using Spectre.Console;
using Spectre.Console.Rendering;
using System.Text;

namespace src
{
    public class ListaCompras
    {
        private List<Chapa> lista = new List<Chapa>();

        public void adicionar(Chapa produto)
        {
            lista.Add(produto);
        }
        public float totalizar()
        {
            float total = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                total = total + lista[i].getPreco();
            }

            return total;
        }
        public void imprimelista()
        {

            Console.WriteLine("\nCarrinho de Compras!");
            Console.WriteLine("____________________\n");

            foreach (var Chapa in lista)
            {

                Console.WriteLine(Chapa.chapacarrinho());
            }
        }
        public void imprimelistafinal()
        {

            foreach (var Chapa in lista)
            {

                Console.WriteLine(Chapa.chapacarrinho());
            }
            Console.WriteLine("____________________\n");
        }
        public string cabecalhocarrinho()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            String unicodeString = $" [Yellow]Carrinho[/] 🛒 ";
            return unicodeString;
        }

        public void printCarrinho()
        {
            var rule = new Rule();
            var grid = new Grid();

            grid.AddColumn(new GridColumn().NoWrap().PadRight(4));
            grid.AddColumn();
            foreach (var Chapa in lista)
            {
                grid.AddRow($"[B]{Chapa.getMaterial()}[/]", $"R$/M² {Chapa.getPreco()}");
            }
            AnsiConsole.Write(rule);
            grid.AddRow("[B]Total:[/]", $"R$ {totalizar()}");


            AnsiConsole.Write(

                new Panel(grid)

                    .Header(cabecalhocarrinho()));

        }


    }
}
