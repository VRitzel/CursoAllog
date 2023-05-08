using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            while (true)
            {
                Console.WriteLine("Temperatura(Celsius): ");
                string x = Console.ReadLine();
                try
                {
                    x = x.Replace(".", ",");
                    c = double.Parse(x);

                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Você escreveu uma string ao invés de um número, tente novamente!");
                }
            }
            Console.Clear();
            double f = (9 * c + 160)/5;
            Console.WriteLine("{0} °C equivalem a {1} °F", c, f);
            Console.ReadLine();
        }
    }
}

