using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Cliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; } 
        public string RG { get; set;}
        public string CPF { get; set;}

        public Cliente() { }

        public Cliente(int id, string name, string endereco, string telefone, string rG, string cPF)
        {
            Id = id;
            Name = name;
            Endereco = endereco;
            Telefone = telefone;
            RG = rG;
            CPF = cPF;

        }


    }
}
