using System;
using System.Collections.Generic;

namespace EMPRESA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios =new List<Funcionario> { };
            Console.WriteLine("quantos clientes deseja cadastrar ?");
            int numero = int.Parse(Console.ReadLine());
            char tipoFuncionario;
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine( "é tercerizado s=> sim ou n=>não" );
                tipoFuncionario = char.Parse(Console.ReadLine());
                if (tipoFuncionario=='n')
                {
                    Console.Write("nome:");
                  string nome=Console.ReadLine();
                    Console.Write("horas trabalhadas:");
                    int hora = int.Parse(Console.ReadLine());
                    Console.Write(" valor da hora trabalhada:");
                    double horaTrabalho = double.Parse(Console.ReadLine());

                    Funcionario func = new Funcionario(nome,hora,horaTrabalho);
                    funcionarios.Add(func);

                }
                else
                {
                    Console.Write("nome:");
                    string nome = Console.ReadLine();
                    Console.Write("horas trabalhadas:");
                    int hora = int.Parse(Console.ReadLine());
                    Console.Write(" valor da hora trabalhada:");
                    double horaTrabalho = double.Parse(Console.ReadLine());
                    Console.Write("despesas valor:");
                    double despesa = double.Parse(Console.ReadLine());

                     
                    Funcionario func = new funcionarioTercerizado(nome, hora, horaTrabalho,despesa);
                    funcionarios.Add(func);


                }

                  
            }
            foreach(Funcionario func in funcionarios)
            {
                Console.WriteLine(func.nome+"-> $"+func.pagamento());
                
            }

        }
    }
}
