public static class Atividade1Matriz
{ 
    public static void Executar()
    {
        string[,] nomes = new string [2, 2];
        
    for (int linha = 0; linha < 2; linha++)
    {
        for(int coluna = 0; linha < 2; coluna++)
        {
            Console.Write($"Digite o nome para [{linha},{coluna}]:");
            nomes[linha, coluna] = Console.ReadLine()!;     
        }
    }
     Console.WriteLine("\nNomes digitados:");

     for (int linha = 0; linha < 2; linha++)
     {
        for(int coluna = 0; coluna < 2; coluna++)
        {
            Console.WriteLine(nomes[linha, coluna]);
        }
     }

    }
}