using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Midia
    {
        public int codigo;
        public int ano;
        public float valor;
        public string categoria;
        public string titulo;

        public Midia()
        {
        }

        public Midia(int codigo, int ano, float valor, string categoria, string titulo)
        {
            this.codigo = codigo;
            this.ano = ano;
            this.valor = valor;
            this.categoria = categoria;
            this.titulo = titulo;
        }

        public void Printar()
        {
            Console.WriteLine("Código: "+this.codigo);
            Console.WriteLine("Ano: "+this.ano);
            Console.WriteLine("Valor: "+this.valor);
            Console.WriteLine("Categoria: "+this.categoria);
            Console.WriteLine("Titulo: "+this.titulo);
        }
        public bool HasNull()
        {
            if(this.categoria == "" || this.titulo == "")
            {
                return true;
            }
            return false;
        }
        public void Pesqusiar()
        {

        }
        public Midia Cadastrar()
        {
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
            Midia med = new Midia();
            return med;
                        
        }
        public void Alterar()
        {

        }



    }
}
