using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade; //o int atribui a var idade a um numero inteiro, sempre sera numero!! 

        idade = 27;
        idade = 27 - 5;
        idade = 5 * 2 - 6;
        Console.WriteLine("Minha idade é " + idade); //Minha idade é 4

        //se escrevermos apenas Console.Write, ele escreve no console mas nao faz quebra de linha

        Console.WriteLine("Pressione enter para fechar.");
        Console.ReadLine();


    }
}