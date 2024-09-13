using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public abstract class Mounstruo
    {
        protected String? Name {  get; set; }
        protected TipoAtaque tipoAtaque { get; set; }

        public Mounstruo(String Name, TipoAtaque tipoAtaque) {
            this.Name = Name;
            this.tipoAtaque = tipoAtaque;
        }

        public void Caminar()
        {
            Console.WriteLine($"{Name} está caminando");
        }

        public void Atacar()
        {
            Console.WriteLine($"{Name} está atacando con {tipoAtaque}");
        }
    }
}
