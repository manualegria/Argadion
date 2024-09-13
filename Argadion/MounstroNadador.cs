using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public class MounstroNadador:Mounstruo, Inadador
    {

        public MounstroNadador(String Name, TipoAtaque tipoAtaque) : base(Name, tipoAtaque)
        {

        }

        public void Nadar()
        {
            Console.WriteLine($"{Name} está nadando ");
        }
        
    }
}
