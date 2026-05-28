public static class Atividade2Matriz
{
    public static void Executar()
    {
        int[,] numeros = new int[2,3];

        for(int linha = 0; linha < 2; linha++)
        {
            for(int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite o numero para [{linha},{coluna}]: ");
                numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("Matriz:");

        for (int linha = 0; linha < 2; linha++)
        {
            for(int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(numeros[linha, coluna] + "\t");
            }
            Console.WriteLine();
        }
    }
}