using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public class MounstruoNadadoryVolador: Mounstruo, Ivolador, Inadador
    {
        public MounstruoNadadoryVolador(String Name, TipoAtaque tipoAtaque) : base(Name, tipoAtaque) 
        { 

        }

        public void Nadar()
        {
            Console.WriteLine($"{Name} está nadando ");
        }

        public void Volar()
        {
            Console.WriteLine($"{Name} está volando ");
        }
    }
}
