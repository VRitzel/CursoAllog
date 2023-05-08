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
            double peso;
            double altura;
            while (true)
            {
                Console.WriteLine("Peso(KG) ");
                string x = Console.ReadLine();
                try
                {
                    x = x.Replace(".", ",");
                    peso = double.Parse(x);

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
                Console.WriteLine("Altura: ");
                string y = Console.ReadLine();
                try
                {
                    y = y.Replace(".", ",");
                    altura = double.Parse(y);
                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Você escreveu uma string ao invés de um número, tente novamente!");
                }
            }
            Console.Clear();
            double imc = peso / Math.Pow(altura,2);
            Console.WriteLine("Atualmente o seu índice é {0}",imc);
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade grau 3");
            }
            Console.ReadLine();
        }
    }
}

