class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de Variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna); //30

        idade = 25; //linha 11 permanece 30, pois idadeAna ja foi declarada

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}