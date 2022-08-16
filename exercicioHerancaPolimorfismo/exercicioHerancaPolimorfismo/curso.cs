using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHerancaPolimorfismo
{
    abstract class curso
    {
        public string nome { get; set; }
        public double valor { get; set; }
        public int alunos { get; set; }
        public curso(){
        }
        public curso(string nome, double valor, int alunos)
        {
            this.nome = nome;
            this.valor = valor;
            this.alunos = alunos;
        }

        public virtual double mensalidade()
        {
            return valor;
        }
    }
}
