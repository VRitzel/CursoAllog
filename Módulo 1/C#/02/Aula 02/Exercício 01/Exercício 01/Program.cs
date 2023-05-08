using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double us;
            double cash;
            while (true)
            {
                Console.WriteLine("Cotação (Dólar): ");
                string x = Console.ReadLine();
                try
                {
                    x = x.Replace(".", ",");
                    us = double.Parse(x);

                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Você escreveu uma string ao invés de um número, tente novamente!");
                }
            }
            Console.Clear();
            while (true)
            {
                Console.WriteLine("U$ 1.00 = U$ {0}", us);
                Console.WriteLine("Quantos dólares você possui? ");
                string y = Console.ReadLine();
                try
                {
                    y = y.Replace(".", ",");
                    cash = double.Parse(y);
                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Você escreveu uma string ao invés de um número, tente novamente!");
                }
            }
            double real = cash * us;
            Console.WriteLine("Atualmente você possui R$ {0}", real);
            Console.ReadLine();
        }
    }
}

