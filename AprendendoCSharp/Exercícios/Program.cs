class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Exercicios no fim do curso");

        //Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.

        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
            Console.WriteLine(i);

            }
        }
        //or 
        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine(); 
    }

}