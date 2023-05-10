using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_00
{
    class midia
    {
        private int codigo;
        private string titulo;
        private int ano;
        private float valor;
        private string categoria;

        public midia()
        {
        }

        public midia(int codigo, string titulo, int ano, float valor, string categoria)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            this.valor = valor;
            this.categoria = categoria;
        }

        public void inserir()
        {
            

            Console.WriteLine("Código: ");
            this.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Título: ");
            this.Titulo = Console.ReadLine();
            Console.WriteLine("Ano: ");
            this.Ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor: ");
            this.Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Categoria: ");
            this.Categoria = Console.ReadLine();
        }
        public void cadastrar() { }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Ano { get => ano; set => ano = value; }
        public float Valor { get => valor; set => valor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
