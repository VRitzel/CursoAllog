using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string nova_frase = "";
            Console.WriteLine("Digite a frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++) {
                if (frase.Substring(i, 1) == "A" || frase.Substring(i, 1) == "a")
                {
                    nova_frase += '&';
                }
                else
                {
                    nova_frase += frase[i];
                }
            }
            Console.WriteLine(nova_frase);
            Console.ReadLine();
        }
    }
}
