using System.Collections.Generic;
using System;
using Spectre.Console;
using System.Threading;
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


        public void carrinhonovo()
        {
            var table = new Table().Centered();

            // Animate
            AnsiConsole.Live(table)
                .AutoClear(false)
                .Overflow(VerticalOverflow.Ellipsis)
                .Cropping(VerticalOverflowCropping.Top)
                .Start(ctx =>
                {
                    void Update(int delay, Action action)
                    {
                        action();
                        ctx.Refresh();
                        Thread.Sleep(delay);
                    }

                    // Columns
                    Update(230, () => table.AddColumn("Quatidade"));
                    Update(230, () => table.AddColumn("Material"));
                    Update(230, () => table.AddColumn("Preco"));

                    // Rows
                    foreach (var Chapa in lista)
                    {
                        Update(70, () => table.AddRow("1", $"[yellow]{Chapa.getMaterial()}[/] [grey]2cm[/] [u]IV[/]", $"R$ {Chapa.getPreco()}"));
                    }


                    // Column footer
                    Update(230, () => table.Columns[2].Footer($"{totalizar()}"));


                    // Column alignment
                    Update(230, () => table.Columns[2].RightAligned());

                    // Column titles
                    Update(70, () => table.Columns[0].Header("[bold]Quantidade[/]"));
                    Update(70, () => table.Columns[1].Header("[bold]Item[/]"));
                    Update(70, () => table.Columns[2].Header("[red bold]Preço[/]"));


                    // Footers
                    Update(70, () => table.Columns[0].Footer($"[B] Total:[/]"));
                    Update(70, () => table.Columns[2].Footer($"R$ {totalizar()}"));


                    // Title
                    Update(500, () => table.Title($"{cabecalhocarrinho()}"));
                    Update(400, () => table.Title($"[[ [yellow]{cabecalhocarrinho()}[/] ]]"));

                    // Borders
                    Update(230, () => table.BorderColor(Color.Yellow));
                    Update(230, () => table.MinimalBorder());
                    Update(230, () => table.SimpleBorder());
                    Update(230, () => table.SimpleHeavyBorder());

                    // Caption
                    Update(400, () => table.Caption("[[ [blue]FINALIZAR COMPRA? (S/N) [/] ]]"));
                });
        }

    }
}
