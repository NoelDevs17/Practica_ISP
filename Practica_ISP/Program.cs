using Practica_ISP.Aves;
using Practica_ISP.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Pato pato = new Pato();
        Halcon halcon = new Halcon();

        MostrarAcciones(pato);
        MostrarAcciones(halcon);
    }

    static void MostrarAcciones(IAveVolado ave)
    {
        if (ave is IAveVolado aveVolado)
        {
            aveVolado.Volar();
            aveVolado.Cantar();
        }

        if (ave is IAveAcuatica aveAcuatica)
        {
            aveAcuatica.Nadar();
        }

        if (ave is IAveRapiña aveRapiña)
        {
            aveRapiña.Cazar();
        }
    }
}