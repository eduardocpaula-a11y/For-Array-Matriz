public static class Atividade6Matriz
{
    public static void Executar ()
    {
int[,] numeros = new int[2, 3];

int maior = 0;

for (int linha = 0; linha < 2; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write($"Digite o número para [{linha},{coluna}]: ");
        numeros[linha, coluna] = int.Parse(Console.ReadLine()!);

        if (linha == 0 && coluna == 0)
        {
            maior = numeros[linha, coluna];
        }

        if (numeros[linha, coluna] > maior)
        {
            maior = numeros[linha, coluna];
        }
    }
}

Console.WriteLine($"Maior valor da matriz: {maior}");
    }
}