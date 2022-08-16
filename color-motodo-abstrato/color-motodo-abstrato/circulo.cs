using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color_motodo_abstrato
{
    class circulo : corpo
    {
       public double raio { get; set;}

        public circulo()
        {

        }
        public circulo(color cor,double raio) : base(cor)
        {
            this.raio = raio;
        }

        public override double Area()
        {
            return Math.PI * raio*raio;
        }
    }
}
