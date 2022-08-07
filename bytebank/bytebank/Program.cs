using bytebank;
using bytebank.Titular;

Console.WriteLine("Bem Vindo ao seu banco, ByteBank!");
/*
//classe é o modelo para criar objetos, onde possui as propriedades que vamos trabalhar
//objeto utiliza o modelo, a classe, para atribuir as propriedades

//'conta1' é o objeto da classe ContaCorrente
ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Andre Silva";
conta1.conta = "10123-x";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agencia Central";
//conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
conta2.conta = "10160-x";
conta2.numeroAgencia = 23;
conta2.nomeAgencia = "Agencia Central";
//conta2.saldo = 100;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero da Agencia: " + conta1.numeroAgencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//logando no console mesmo sem adicionar propriedades para o objeto 'conta3':
ContaCorrente conta3 = new ContaCorrente();

Console.WriteLine("Titular: " + conta3.titular); //string vazia
Console.WriteLine("Conta: " + conta3.conta);
Console.WriteLine("Numero da Agencia: " + conta3.numeroAgencia); //0
Console.WriteLine("Nome da Agencia: " + conta3.nomeAgencia);
Console.WriteLine("Saldo: " + conta3.saldo); //0
Console.WriteLine("Verificador: " + conta3.verificador); //false

//testes
double saldo = 100;
double saldo2 = 100;
double saldo3 = conta1.saldo;
conta2.saldo = 200;

Console.WriteLine(saldo == saldo2); //true
Console.WriteLine(saldo == conta1.saldo); //true
Console.WriteLine(saldo == saldo3); //true
Console.WriteLine(saldo == conta2.saldo); //false

//testando se a 'conta1' e a 'conta2' são identicas (as informações da 'conta2' foram trocadas):
Console.WriteLine(conta1 == conta2); //false
//sao 2 referencias. quando se cria um novo objeto, é criada uma memoria no computador com um endereço
//aleatorio de memoria. entao quando comparamos conta1 com 'conta2', ele verifica os endereços diferentes
//de memorias. ele compara tipos de referencia, mesmo com valores iguais

conta1 = conta2;
//agora 'conta1' aponta pro mesmo endereço de memoria que 'conta2':
Console.WriteLine(conta1 == conta2); //true


//Console.WriteLine("Saldo da Amanda pré-saque: R$ " + conta2.saldo); //100
conta2.Sacar(50);
//Console.WriteLine("Saldo da Amanda pós-saque: R$ " + conta2.saldo); //50

conta2.Sacar(51);
//Console.WriteLine(conta2.saldo); //50, pois 'Sacar' retornou 'false' já que o valor é maior que o saldo


//antes de arrumar o metodo para só retornar true para valores acima de 0:
conta2.Sacar(-50);
//Console.WriteLine(conta2.saldo); //100, pois (-50) é menor que 50, então retorna true. quando saldo - (-50)
                                 //é executado, vira saldo + 50 por conta dos sinais

//depois de colocar 'if (valor < 0) return false':
conta2.Sacar(-50);
//Console.WriteLine(conta2.saldo); //50, pois retornou false e não houve saque

conta2.Depositar(60);
//Console.WriteLine("Saldo da Amanda pós-depósito: R$ " + conta2.saldo); //110

/*
//sobre retornar valores:
bool saque = conta2.Sacar(50);
Console.WriteLine("Saque realizado? " + saque); //retorna valor 'true'
bool depositar = conta2.Depositar(50); //dá erro, nao da pra converter 'void' para 'bool'
*/

/*
Console.WriteLine("Saldo pré-transferência da Amanda: R$ " + conta2.saldo); //110
Console.WriteLine("Saldo pré-transferência do André: R$ " + conta1.saldo); //100

bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine("Transferência realizada com sucesso: " + transferencia); //true (retorna valor pois 

Console.WriteLine("Saldo pós-transferência da Amanda: R$ " + conta2.saldo); //160
Console.WriteLine("Saldo pós-transferência do André: R$ " + conta1.saldo); //50


//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "123456789-0";
//cliente.profissao = "Programador C#";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
/*
conta3.titular.nome = "Andre Silva";
conta3.titular.cpf = "123456789-0";
conta3.titular.profissao = "Programador C#";

conta3.conta = "2513252-x";
conta3.numeroAgencia = 35;
conta3.nomeAgencia = "Agencia Central";

//Console.WriteLine(cliente.nome); //Andre Silva
Console.WriteLine(conta3.titular.nome); //Andre Silva
/*
if (conta3.titular ==null)
{
    Console.WriteLine("O campo titular está nulo"); //quando comentamos o codigo do cliente acima, ele loga esta frase no console
}

ContaCorrente conta4 = new ContaCorrente();
//conta4.saldo = -10;
//Console.WriteLine(conta4.saldo); //erro pois agora 'saldo' é um campo privado


conta4.SetSaldo(-10);
Console.WriteLine("Saldo: R$ " + conta4.GetSaldo()); //0, nao logou nada pois o 'return' parou a execução

conta4.SetSaldo(10);
Console.WriteLine("Saldo: R$ " + conta4.GetSaldo()); //10


Cliente Sarah = new Cliente();
//ContaCorrente conta4 = new ContaCorrente();

conta4.Saldo = 150; //com letra maiúscula, pois vai executar o método Saldo
Console.WriteLine(conta4.Saldo); //150

conta4.Titular = Sarah;
conta4.Saldo = 100;
conta4.NumeroAgencia = -10;
conta4.Conta = "";

ContaCorrente conta4 = new ContaCorrente(235, "1233456-x");
Console.WriteLine(conta4.NumeroAgencia);
Console.WriteLine(conta4.Conta);
*/

ContaCorrente conta5 = new ContaCorrente(123, "123456-0");
//conta5.TotalContasCriadas = 1;
ContaCorrente conta6 = new ContaCorrente(321, "654321-0");
//conta6.TotalContasCriadas += 1;
//Console.WriteLine(conta5.TotalContasCriadas); //1
//Console.WriteLine(conta6.TotalContasCriadas); //1

Console.WriteLine(ContaCorrente.TotalContasCriadas); //2

Console.ReadKey(); //espera o clique de alguma tecla para fechar