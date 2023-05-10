using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_07
{
    class Program
    {
        public static void nome(string nome)
        {
            Console.Clear();
            Console.WriteLine("Olá meu nome é: {0}", nome);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome? ");
            string x = Console.ReadLine();
            nome(x);
        }
    }
}
