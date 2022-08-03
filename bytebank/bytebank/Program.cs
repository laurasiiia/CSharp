using bytebank;

Console.WriteLine("Bem Vindo ao seu banco, ByteBank!");

//conta1 é o objeto da classe ContaCorrente
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123-x";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agencia Central";
conta1.saldo = 100;

//classe é o modelo para criar objetos, onde possui as propriedades que vamos trabalhar
//objeto utiliza o modelo, a classe, para atribuir as propriedades

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Numero da Agencia: " + conta1.numeroAgencia);
Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey(); //espera o clique de alguma tecla para fechar