using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_1
{
    class Funcionario
    { public string nome { get; set; }
        public int hora { get; set; }
        public double valorHora { get; set; }
        public Funcionario()
        {

        }

        public Funcionario(string nome, int hora, double valorHora)
        {
            this.nome = nome;
            this.hora = hora;
            this.valorHora = valorHora;
        }

        public virtual double pagamento()
        {
            return hora * valorHora;
        }
    }
}
