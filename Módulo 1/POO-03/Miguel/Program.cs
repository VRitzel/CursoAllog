using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("0-Dvd ou 1-Livro: ");
                string opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    Dvd dvd = new Dvd();
                    dvd.Cadastrar();

                    while (true)
                    {
                        try
                        {
                            Console.Write("Código: ");
                            int codigo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ano: ");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Valor: ");
                            float valor = float.Parse(Console.ReadLine());
                            Console.Write("Título: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Categoria: ");
                            string categoria = Console.ReadLine();
                            Console.Write("Produtor: ");
                            string produtor = Console.ReadLine();
                            Console.Write("Diretor: ");
                            string diretor = Console.ReadLine();
                            Dvd dvd1 = new Dvd();
                            dvd1.Cadastrar(produtor, diretor, codigo, ano, valor, categoria, titulo);
                            if (dvd1.HasNull())
                            {
                                Console.WriteLine("Algo não foi preenchido");
                                continue;
                            }
                            dvd1.Printar();
                            Console.Read();
                            break;
                        }
                        catch 
                        {
                            Console.WriteLine("ta errado");
                        }
                       
                    }
                   
                    
                }

            }

         
                

        }
    }
}
