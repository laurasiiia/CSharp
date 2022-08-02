using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario; //double sao variaveis com numeros ponto flutuante, com virgula! 
        salario = 3000.10;
        Console.WriteLine(salario); //3000,1 

        salario = 3000; //tambem funciona com numeros inteiros!
        //double pode ter numeros inteiros, mas int nao pode ter pontos flutuantes! 

        double idade;
        idade = 7 / 5;
        Console.WriteLine(idade); //1 
        //o double entende que 7/5 é um numero inteiro, e devolve um numero inteiro tambem
        //nao é arrendondamento, ele apenas considera a parte inteira do numero! 
        //para arrumar isso, podemos fazer o seguinte:

        idade = 7.0 / 5;
        Console.WriteLine(idade); //1,4 

        Console.WriteLine("Pressione enter para fechar.");
        Console.ReadLine();
    }
}
  