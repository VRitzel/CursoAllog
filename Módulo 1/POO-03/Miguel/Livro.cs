using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Livro:Midia
    {
        public string autor;
        public string isbn;

        public Livro()
        {
        }

        public void Cadastrar(string autor, string isbn, int codigo, int ano, float valor, string categoria, string titulo)
        {
            this.autor = autor;
            this.isbn = isbn;
            base.Cadastrar(codigo, ano, valor, categoria, titulo);
        }


    }
}
