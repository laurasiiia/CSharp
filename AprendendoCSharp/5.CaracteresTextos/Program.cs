class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a'; //aspas simples!! char nao é string
        Console.WriteLine(letra);

        //char tambem é lido como numero pelo pc, por conta do ASCII:
        letra = (char)65; //65 
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra); //B, pq B em ASCII é 66

        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase + " " + 2022);

        string vazia = " ";
        //char vazia = ' '; //char nao permite caracter vazio 

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos); //funciona, fica listado, mas se usarmos TAB pra arrumar no codigo, muda no console tambem

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine(); 
    }

} 