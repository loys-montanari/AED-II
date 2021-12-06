
using System;
using Spectre.Console;
using System.Threading;


namespace src
{
    public class Serrada : Material
    {

        private string maquinario;
        private float valorm2;
        private float areaproduzida;

        public Serrada(int id, string mat, int cla, string maq, float vl) : base(id, mat, cla)
        {

            maquinario = maq;
            valorm2 = vl;
            areaproduzida = 0;

        }
        public void setValor(float val)
        {

            valorm2 = val;
        }

        public string getMaquinario()
        {
            return maquinario;

        }
        public float getValor()
        {

            return valorm2;
        }
 
    }

}
