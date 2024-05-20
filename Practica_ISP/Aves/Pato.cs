using Practica_ISP.Interfaces;


namespace Practica_ISP.Aves
{
    class Pato : IAveVolado, IAveAcuatica
    {
        public void Volar()
        {
            Console.WriteLine("El pato vuela.");
        }

        public void Cantar()
        {
            Console.WriteLine("El pato canta.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato nada.");
        }
    }
}
