using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        //public string nome; //escreva prop e aperte tab 2x:
        public string Nome { get; set; }
        //public string cpf;
        public int Cpf { get; set; }
        //public string profissao;
        public string Profissao { get; set; }
    }
}

//a classe 'cliente' e 'contacorrente' estao contidas no namespace 'bytebanmk'
//o mesmo namespace pode ter varias classes. ele trabalha de maneira hierarquica