using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color_motodo_abstrato
{
    class Retangulo : corpo
    {  public double altura { get; set; }
       public  double largura { get; set; }

        public Retangulo()
        {

        }

        public Retangulo(color cor ,double altura, double largura) : base(cor)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public override double Area()
        {
            return altura * largura;
        }

    }

}
