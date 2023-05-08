using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            while (true)
            {
                Console.WriteLine("Temperatura(Fahrenheit): ");
                string x = Console.ReadLine();
                try
                {
                    x = x.Replace(".", ",");
                    f = double.Parse(x);

                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Você escreveu uma string ao invés de um número, tente novamente!");
                }
            }
            Console.Clear();
            double c = ((f - 32) * 5) / 9;
            Console.WriteLine("{0} °F equivalem a {1} °C", f, c);
            Console.ReadLine();
        }
    }
}
