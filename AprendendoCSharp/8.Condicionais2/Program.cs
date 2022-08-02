class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Programa 8- Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1; //verdadeiro, pois quantidadePessoas > 0, ou seja: true

        if (idadeJoao >= 18 || acompanhado) //or
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
            
        }

        //

        if (idadeJoao >= 18 && acompanhado) //and
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");

        }

        bool grupo = true;

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}