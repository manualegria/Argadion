using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public class Argadion
    {
        public static void Main(string[] args)
        {
            
            Mounstruo Dragon = new MounstruaVolador("Dragon de fuego", TipoAtaque.FUEGO);
            Mounstruo Kraken = new MounstroNadador("Kraken", TipoAtaque.VENENO);
            Mounstruo Levitan = new MounstruoNadadoryVolador("Levitan", TipoAtaque.HIELO);




            Dragon.Caminar();
            Dragon.Atacar();
           //((Ivolador)Dragon).Volar();

            Kraken.Caminar();
            Kraken.Atacar();
           //  ((Inadador)Kraken).Nadar();

           // Levitan.Caminar();
            Levitan.Atacar();
            ((Ivolador)Levitan).Volar();
            ((Inadador)Levitan).Nadar();


        }
    }
}
