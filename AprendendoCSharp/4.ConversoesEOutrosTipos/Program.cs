using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Outros tipos de variáveis e conversões");

        double salario;
        salario = 3000.15;

        int salarioInteiro;
        //salarioInteiro = salario; //dá erro, pq salario é tipo double! 
        salarioInteiro = (int)salario; //só serao considerados numeros antes da virgula!

        Console.WriteLine(salarioInteiro); //3000

        int x;
        //x = 2000000000000000000; //nao funciona pq int só trabalha ate 32 bits

        long y;
        y = 2000000000000000000; //funciona!

        short w;
        w = 15000; //trabalha ate 16 bits

        float altura;
        //altura = 1.62; float nao tem precisao, entao da erro, mas é possivel continuar:
        altura = 1.62f;

        Console.WriteLine(altura); //1.62

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}