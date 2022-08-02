class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Programa 8- Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado."; //é o que foi logado
        }
        else
        {
            textoAdicional = "João não está acompanhado.";
        }

        if (idadeJoao >= 18 || acompanhado) 
        {
            Console.WriteLine(textoAdicional); //pelo primeiro if ter sido logado, o conteudo dessa string permanece "Joao está acompanhado"
            Console.WriteLine("Pode entrar!");
        }
        else
        
            Console.WriteLine("Não pode entrar!"); //quando só temos um unico comando no if, nao é necessario o uso de {}

        

        //se nao tivessemos declarado 'textoAdicional' fora do if else, nao
        //teriamos acesso a essa variavel no proximo if por causa do escopo

        Console.WriteLine("Tecle enter para fechar.");
        Console.ReadLine();
    }
}