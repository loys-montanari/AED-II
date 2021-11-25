namespace src
{
    public class serrada
    {
        private int idserrada;
        private int idbloco;
        private string tipo;
        private string valorm2;       
        private string dataserrada;        
        

        public serrada(int ids, int idbl, string tp, string valor, DateTime data){

            idserrada = ids;
            idbloco = idbl;
            tipo = tp;
            valorm2 = valor;
            dataserrada = data;
        }
    }
}