using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public class MounstruaVolador:Mounstruo,Ivolador
    {

        public MounstruaVolador(String Name, TipoAtaque tipoAtaque) : base(Name, tipoAtaque) 
        {

        }

        public void Volar()
        {
            
            Console.WriteLine($"{Name} esta volando");
        }

        


    }
}
