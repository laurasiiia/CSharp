using bytebank;

Console.WriteLine("Bem Vindo ao seu banco, ByteBank!");

//classe é o modelo para criar objetos, onde possui as propriedades que vamos trabalhar
//objeto utiliza o modelo, a classe, para atribuir as propriedades

//conta1 é o objeto da classe ContaCorrente
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123-x";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agencia Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Andre Silva";
conta2.conta = "10123-x";
conta2.numeroAgencia = 23;
conta2.nomeAgencia = "Agencia Central";
conta2.saldo = 100;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero da Agencia: " + conta1.numeroAgencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

/*
//logando no console mesmo sem adicionar propriedades para o objeto conta3:
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
*/

Console.WriteLine(conta1 == conta2); //false
//sao 2 referencias. quando se cria um novo objeto, é criada uma memoria no computador com um endereço
//aleatorio de memoria. entao quando comparamos conta1 com conta2, ele verifica os endereços diferentes
//de memorias. ele compara tipos de referencia, mesmo com valores iguais

conta1 = conta2;
//agora conta1 aponta pro mesmo endereço de memoria que conta2
Console.WriteLine(conta1 == conta2);

Console.ReadKey(); //espera o clique de alguma tecla para fechar