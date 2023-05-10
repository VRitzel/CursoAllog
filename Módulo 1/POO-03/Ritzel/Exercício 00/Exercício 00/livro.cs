using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_00
{
    class livro : midia
    {

        public string autor { get; set; }
        public string isbn { get; set; }

        public livro(string autor, string isbn, int codigo, string titulo, int ano, float valor, string categoria) : base(codigo, titulo, ano, valor, categoria)
        {
            this.autor = autor;
            this.isbn = isbn;
        }

        public void cadastrar()
        {
            Console.WriteLine("Autor: ");
            this.autor = Console.ReadLine();
            Console.WriteLine("ISBN: ");
            this.isbn = Console.ReadLine();
            this.inserir();
        }
        public livro()
        {
        }
    }
}
