using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_00
{
    class dvd:midia
    {

        public string produto { get; set; }
        public string diretor { get; set; }

        public dvd(string produto, string diretor, int codigo, string titulo, int ano, float valor, string categoria) : base(codigo, titulo, ano, valor, categoria)
        {
            this.produto = produto;
            this.diretor = diretor;
        }

        public dvd()
        {
        }
    }
}
