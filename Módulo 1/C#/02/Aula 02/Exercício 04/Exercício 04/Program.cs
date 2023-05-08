using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            int velocidade;
            while (true)
            {
                Console.WriteLine("Tempo: ");
                string x = Console.ReadLine();
                try
                {
                    x = x.Replace(".", ",");
                    tempo = int.Parse(x);

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
                Console.WriteLine("Velocidade média: ");
                string y = Console.ReadLine();
                try
                {
                    y = y.Replace(".", ",");
                    velocidade = int.Parse(y);
                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Você escreveu uma string ao invés de um número, tente novamente!");
                }
            }
            int distancia = tempo * velocidade;
            int litro = distancia / 12;
            Console.Clear();
            Console.WriteLine("Velocidade média = {0}\nTempo gasto = {1}\nDistância = {2}\nLitros usados = {3}", velocidade, tempo, distancia, litro);
            Console.ReadLine();
        }
    }
}

