public static class Atividade3Matriz
{
    public static void Executar()
    {
        int[,] matriz = new int[2,2];
        int soma = 0;

        for(int linha = 0; linha < 2; linha++)
        {
            for(int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write($"Digite o numero para [{linha},{coluna}]: ");
                matriz[linha, coluna] = int.Parse(Console.ReadLine()!);

                soma += matriz[linha, coluna];
            }
        }
        Console.WriteLine("\nSoma dos valores: " + soma);
    }
}