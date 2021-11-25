using System;

namespace src
{
    public class Bloco
    {
        private int idbloco;
        private string bloco;
        private string material;
        private float metroscubicos;
        private float valor;
        private DateTime? datacompra;

        public Bloco(int id, string bl, string mat, float m3, float val, DateTime data)
        {

            idbloco = id;
            bloco = bl;
            material = mat;
            metroscubicos = m3;
            valor = val;
            datacompra = data;

        }
        

    }
}