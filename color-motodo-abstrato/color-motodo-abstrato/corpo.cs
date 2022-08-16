using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color_motodo_abstrato
{
    abstract class corpo
    {
       public  color cor { get; set; }

        public corpo()
        {
          
        }
        public corpo(color cor)
        {
            this.cor = cor;
        }

        public abstract double Area();
        
        
    }
}
