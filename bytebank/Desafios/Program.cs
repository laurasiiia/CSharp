namespace Desafio
{

    //1.10 desenvolva classe para sistema de gerenciamento de produtos no estoque do Supermercado
    public class Produtos
    {
        public string nome;
        public string fabricante;
        public int codigoBarras;
        public double valorUnitario;
        public double valorCompra;
        public int quantidadeEstoque;
    }

    //2.08 imagine que você precisa cadastrar uma pessoa num sistema médico
    //exibir no Program.cs o valor padrão de cada um dos campos:
    public class CadastroMedico
    {
        public string nome; // ""
        public int idade; //0
        public double altura; //0
        public double peso; //0
    }

    //3.08 criar método que exiba todas as informações da conta no console da aplicação
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        public void ExibirDados()
        {
            Console.WriteLine("Titular da conta: " + titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Número da agência: " + numeroAgencia);
            Console.WriteLine("Nome da agência: " + nomeAgencia);
            Console.WriteLine("Saldo: R$ " + saldo);
        }


    }

    //4.10 criar uma composição de classes que poderá ser usada no franqueados um sistema de pedidos online
    //deverá trabalhar com informações de pedidos de clientes, como valor total do pedido, cliente,
    //endereço de entrega e os itens selecionados (máximo de 3).
    public class Produto
    {
        public string descriçao;
        public int codigoProduto;
        public double valor;
        public int quantidadeEstoque;
    }
    
    public class DadosCliente
    {
        public string nome;
        public Endereço endereço;
    }

    public class Endereço
    {
        public string rua;
        public int numero;
        public string bairro;
        public string cidade;
    }

    public class ProdutoPedido
    {
        public int quantidade;
        public Produto produto1;
        public Produto produto2;
        public Produto produto3;
    }

    public class Pedido
    {
        public DadosCliente cliente;
        public string numeroPedido;
        public double valor;
        public ProdutoPedido item;
    }

    //5.10 a propriedade Matricula precisa validar a operação de Set, não permitindo a inserção de valores
    //menores ou iguais a zero.
    class Aluno
    {
        //public int Matricula { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }

        private int matricula;
        public int Matricula
        {
            get
            {
                return matricula;
            }
            
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Matrícula inválida");
                }
                else
                {
                    matricula = value;
                }
            }
        }
    }

    //6.08 gerar um construtor personalizado para a classe ContaCorrente, que deve receber todos os campos
    //necessários para preencher o objeto
    public ContaCorrente(string titular, string conta, int numeroAgencia, string nomeAgencia, double saldo)
    {
        Titular = titular;
        Conta = conta;
        NumeroAgencia = numeroAgencia;
        NomeAgencia = nomeAgencia;
        Saldo = saldo;

    }
}