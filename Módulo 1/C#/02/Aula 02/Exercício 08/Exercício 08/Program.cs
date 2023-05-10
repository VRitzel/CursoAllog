using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_08
{
    class Program
    {
        public static void Salary()
        {
            Console.WriteLine("Digite o seu salário");
            string x = Console.ReadLine();
            decimal num = Convert.ToDecimal(x); 
            if (num < 1850)
            {
                num += 320;
            }
            else
            {
                num -= 180;
            }
            Console.WriteLine("O salário final seria R$ {0}", num);
        }
        static void Main(string[] args)
        {
            Salary();
            Console.ReadLine();
        }
    }
}
