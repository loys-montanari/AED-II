using Spectre.Console;
using Spectre.Console.Rendering;

namespace src
{
    public class Material
    {
        private int idmaterial;
        private string material;
        private int classe;

        public Material(int id, string desc, int cla)
        {

            idmaterial = id;
            material = desc;
            classe = cla;
        }

        public string getMaterial()
        {
            return material;
        }
        public int getClasse()
        {
            return classe;
        }

        public void setClasse(int cla){
            classe = cla;
        }




    }
}