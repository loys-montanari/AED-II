using System;

namespace src
{
    public class producao
    {
        private int idatividade;
        private string descricao;
        private int custo;
        private int idbloco;  
        private string maquina;           

        public producao(int id, string desc, int cst, int idbl, string maq){

            idatividade = id;
            descricao = desc;
            custo = cst;
            idbloco = idbl;
            maquina = maq;
        }
        
    }
}