using bytebank;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        //clicar com 'ctrl .' em cima do Cliente e selecionar 'using bytebank.Titular'
        //private Cliente titular;
        //public string conta;
        //public int numeroAgencia;
        //public string nomeAgencia;
        private double saldo; //um campo privado só é visível no corpo da própria classe onde foi definido,
                              //ou seja, 'Program.cs' não consegue acessar ele normalmente

        //public bool verificador;

        //metodos:
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        //'sacar' é um metodo que retorna valor: true ou false, por isso a palavra return
        //tipo bool, int, double etc, sempre retorna valor

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
        //void nao retorna valor, ele só executa uma ação, nao retorna nada

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        /*
        //metodo publico para 'Program.cs' poder acessar o campo privado do 'saldo':
        //public void DefinirSaldo(double valor)
        public void SetSaldo(double valor)

        {
            if (valor < 0)
            {
                return; //quando 'void' encontra 'return', ele para a execução
                //ou seja, se valor menor q 0, ele para a execução
            }
            else
            {
                saldo = valor;
            }
        }

        //public double ObterSaldo()
        public double GetSaldo()
        {
            return saldo;
        }
        //Set e Get sao prefixos para Definir e Obter, respectivamente
        */

        //propriedade que manipula o saldo:
        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }
        //propriedades começam com letra maiúscula e o campo da classe com letra minúscula!!!!!!!

        /*
        public Cliente Titular
        {
            get
            {
                return titular;
            }
            set
            {
                titular = value;
            }
        }
        */

        //propriedade autoimplementada:
        public Cliente Titular
        {
            get;
            set;
        }
        //o compilador cria o campo titular sozinho

        public string NomeAgencia { get; set; }


        //quando precisamos definir o uso de uma propriedade, precisamos criar o campo novamente
        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numeroAgencia = value;
                }
            }
        }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        //agora só é possivel criar a conta já adicionando os valores no parametro
        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            TotalContasCriadas += 1;
        }

        //o static expecifica que é uma propriedade da classe ContaCorrente e nao de um objeto
        public static int TotalContasCriadas { get; set; }
    }
}