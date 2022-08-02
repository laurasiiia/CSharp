class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        //com break:

        for (int contadorLinhas = 0; contadorLinhas <= 9; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("*");

                if (contadorColunas >= contadorLinhas)
                {
                    break; //caso a condiçao seja true, o for ira parar, e a linha 14 volta a rodar
                }
            }

            Console.WriteLine(); //lembrando que WriteLine pula linhas
        }

        //outra forma, sem o break:

        for (int contadorLinhas = 0; contadorLinhas <= 9; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++) //se atente a mudar os sinas < e >
            {
                Console.Write("*");

            }

            Console.WriteLine(); //lembrando que WriteLine pula linhas
        }


        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine(); //quando ele ler qualquer tecla do usuário, o fecha
    }

}