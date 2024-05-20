using Practica_ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP.Aves
{
    class Halcon : IAveVolado, IAveRapiña
    {
        public void Volar()
        {
            Console.WriteLine("El halcón vuela.");
        }

        public void Cantar()
        {
            Console.WriteLine("El halcón no canta.");
        }

        public void Cazar()
        {
            Console.WriteLine("El halcón caza.");
        }
    }
}
