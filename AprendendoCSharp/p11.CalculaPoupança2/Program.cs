class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula polpança usando for");

        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mês
        //investimento = investimento + investimento * 0.005;
        //investimento = investimento * 1.005;

        //int mes = 1;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005; //mesma coisa!
            Console.WriteLine("No mês " + mes + " meu investimento chegou ao valor de R$ " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }

}