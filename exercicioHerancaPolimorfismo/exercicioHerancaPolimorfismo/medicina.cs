using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHerancaPolimorfismo
{
    class medicina : curso
    {
       public double custoadcional { get; set; }

        public medicina() { }

        public medicina(string nome,double valor, int alunos,double custoadcional) : base(nome,valor,alunos)
        {
            this.nome = "medicina";               
            this.valor = valor;
            this.alunos = alunos;
            this.custoadcional = custoadcional;
        }

        public override double mensalidade()
        {
            return valor+custoadcional;
        }
    }
}
