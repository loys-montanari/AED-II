using System;

namespace src
{
    public class Chapas
    {
        private int idchapa;
        private string chapa;
        private int idbloco;
        private string material;
        private float area;
        private float preco;
        private string qualidade;
        private int espessura;
        private DateTime? dataproducao;

        public Chapas(int idch, string ch, int idbl, string mat, float m2, float prc, string qld, int esp, DateTime data){

            idchapa = idch;
            chapa = ch;
            idbloco = idbl;
            material = mat;
            area = m2;
            preco = prc;
            qualidade = qld;
            espessura = esp;
            dataproducao = data;
        }
    }
}