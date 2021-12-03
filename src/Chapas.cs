using System;

namespace src
{
    public class Chapa:Material
    {


        private float area;
        private float preco;
        private int espessura;
        private int quantidadechapas;
        private int chapasquebradas;
        private float areaquebrada;

        public Chapa(int id, string mat, int cla, float pr, int esp): base(id, mat, cla){
            
            area = 0;
            preco = pr;
            espessura = esp;
            quantidadechapas = 0;
            chapasquebradas = 0;
            areaquebrada = 0;

        }

        public void EntradaChapas(int qtd, float ar){

            quantidadechapas = quantidadechapas + qtd;
            area = area + ar;
        }

        public void QuebraDeChapas(int qtd, float ar){
              area = area - ar;
              areaquebrada = areaquebrada + ar;
              quantidadechapas = quantidadechapas - qtd;
              chapasquebradas = chapasquebradas + qtd;

        }
    }
}