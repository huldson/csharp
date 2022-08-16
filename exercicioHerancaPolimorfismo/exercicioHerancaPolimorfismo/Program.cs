using System;
using System.Collections.Generic;

namespace exercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            curso variavel = new curso("ciencia da computação", 1000, 45);
            List<curso> faculdade = new List<curso> { };// quando a class é abstrata ele pode ser tpo ainda pode ser herdada porm não pode ser instaciada 
            curso medicina = new medicina("sdfghd", 10000, 50, 1200);

            Console.WriteLine(variavel.mensalidade());
            Console.WriteLine(medicina.mensalidade());
        }
    }
}
