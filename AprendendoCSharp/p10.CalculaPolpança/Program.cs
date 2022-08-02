class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula polpança usando while");

        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mês

        investimento = investimento + investimento * 0.005;

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " meu investimento chegou ao valor de R$ " +  investimento);
            mes++;

        }

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine(); 
    }

}