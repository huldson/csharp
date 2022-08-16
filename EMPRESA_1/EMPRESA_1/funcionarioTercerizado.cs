using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_1
{
    class funcionarioTercerizado : Funcionario
    {
        public double despesaAdicional { get; set; }

        public funcionarioTercerizado(string nome, int hora, double valorHora,double despesa) : base(nome,hora,valorHora)
        {
            this.nome = nome;
            this.hora = hora;
            this.valorHora = valorHora;
            this.despesaAdicional = despesa;
        }
        public override double pagamento()
        {
            return valorHora * hora + ((despesaAdicional/100)*110);
        }
    }
}
