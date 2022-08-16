using System;
using System.Collections.Generic;

namespace color_motodo_abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("quantos numero deseja cadastrar: ");
            int x = int.Parse(Console.ReadLine());
            List<corpo> lapisdecor = new List<corpo>();
            for (int i = 0; i <x; i++)
            {
                Console.WriteLine("deseja cadastrar um retangulo digite ->r oucirculo ->c");
                string letra = Console.ReadLine();
                if (letra=="c") {
                    Console.Write("qual cor :");
                    color cor = Enum.Parse<color>(Console.ReadLine());
                    Console.Write("raio:");
                    double raio = double.Parse(Console.ReadLine());
                    circulo cir = new circulo(cor, raio);
                    lapisdecor.Add(cir);
                }
                else
                {
                    Console.Write("qual cor :");
                    color cor = Enum.Parse<color>(Console.ReadLine());
                    Console.Write("altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.Write("largura:");
                    double largura = double.Parse(Console.ReadLine());
                    Retangulo ret = new Retangulo(cor, altura, largura);
                    lapisdecor.Add(ret);
                }


                
            }

            foreach (corpo item in lapisdecor)
            {
                Console.WriteLine("cor:"+item.cor+"area:"+item.Area().ToString("f2"));
            }
        }
    }
}
