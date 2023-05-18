using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.net
{
    public class Categoria
            {

        public int ID { get; set; }
        public string Nome { get; set; }
        public int Valor_diaria { get; set; }
        


        public Categoria() { }

        public Categoria(int iD, string nome, int valor_diaria)
        {
           // ID = iD;
           // Nome = nome;
           // Valor_diaria = valor_diaria;
        }

        




    }
}
