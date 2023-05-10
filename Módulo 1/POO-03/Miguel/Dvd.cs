using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dvd:Midia
    {
        public string produtor;
        public string diretor;

        public Dvd()
        {
        }
        public bool HasNull()
        {
            if(this.produtor == "" || this.diretor == "" || base.HasNull())
            {
                return true;
            }
            return false;
        }

        public void Cadastrar()
        {
            while (true)
            {
                try
                {
                    base.Cadastrar();
                    Console.Write("Produtor: ");
                    string produtor = Console.ReadLine();
                    Console.Write("Diretor: ");
                    string diretor = Console.ReadLine();
                    if (this.HasNull())
                    {
                        Console.WriteLine("Algo não foi preenchido");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("ta errado");
                }
            }
        }

        public void Printar()
        {
            Console.WriteLine("======DVD======");
            Console.WriteLine("Produtor: "+this.produtor);
            Console.WriteLine("Diretor: "+this.diretor);
            base.Printar();
        }

    }
}
