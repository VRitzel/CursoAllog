using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_00
{
    class Program
    {
        static midia UserMedia()
        {
            midia m = new midia();

            Console.WriteLine("Código: ");
            m.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Título: ");
            m.Titulo = Console.ReadLine();
            Console.WriteLine("Ano: ");
            m.Ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor: ");
            m.Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Categoria: ");
            m.Categoria = Console.ReadLine();

            return m;
        }

        static void Main(string[] args)
        {
            List<midia> listamidia = new List<midia>()
            dvd dvd = new dvd();
            livro livro = new livro();
            string x;
            string y;
            Console.WriteLine("Quantos produtos? ");
            int total = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < total; i++)
            {
                Console.Clear();
                Console.WriteLine("DVD: 1 \nLivro: 2");
                x = Console.ReadLine();
                Console.Clear();
                if (x == "1")
                {
                    Console.WriteLine("Produto: ");
                    dvd.produto = Console.ReadLine();
                    Console.WriteLine("Diretor: ");
                    dvd.diretor = Console.ReadLine();
                    midia m = UserMedia();
                    dvd.Codigo = m.Codigo;
                    dvd.Titulo = m.Titulo;
                    dvd.Ano = m.Ano;
                    dvd.Valor = m.Valor;
                    dvd.Categoria = m.Categoria;
                    listamidia.Add(dvd);
                }
                else
                {
                    Console.WriteLine("Autor: ");
                    livro.autor = Console.ReadLine();
                    Console.WriteLine("ISBN: ");
                    livro.isbn = Console.ReadLine();
                    midia m = UserMedia();
                    livro.Codigo = m.Codigo;
                    livro.Titulo = m.Titulo;
                    livro.Ano = m.Ano;
                    livro.Valor = m.Valor;
                    livro.Categoria = m.Categoria;
                    listamidia.Add(livro);
                }
            }
            Console.Clear();
            foreach (midia item in listamidia)
            {
                if (item is dvd)
                {
                    dvd dvditem = item as dvd;
                    Console.WriteLine("Produto: " + dvditem.produto);
                    Console.WriteLine("Diretor: " + dvditem.diretor);
                    Console.WriteLine("Código: " + dvditem.Codigo);
                    Console.WriteLine("Título: " + dvditem.Titulo);
                    Console.WriteLine("Ano: " + dvditem.Ano);
                    Console.WriteLine("Valor: " + dvditem.Valor);
                    Console.WriteLine("Categoria: " + dvditem.Categoria + "\n");
                }
                else
                {
                    livro livroitem = item as livro;
                    Console.WriteLine("Autor: " + livroitem.autor);
                    Console.WriteLine("ISBN: " + livroitem.isbn);
                    Console.WriteLine("Código: " + livroitem.Codigo);
                    Console.WriteLine("Título: " + livroitem.Titulo);
                    Console.WriteLine("Ano: " + livroitem.Ano);
                    Console.WriteLine("Valor: " + livroitem.Valor);
                    Console.WriteLine("Categoria: " + livroitem.Categoria);
                }
            }
            Console.ReadKey();
        }
    }
}
