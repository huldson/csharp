using System;

namespace exercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            curso variavel = new curso("ciencia da computação", 1000, 45);
            curso medicina = new medicina("sdfghd", 10000, 50, 1200);

            Console.WriteLine(variavel.mensalidade());
            Console.WriteLine(medicina.mensalidade());
        }
    }
}
