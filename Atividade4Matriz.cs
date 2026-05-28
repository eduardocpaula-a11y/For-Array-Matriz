public static class Atividade4Matriz
{
    public static void Executar ()
    {
       double[,] notas = new double[3, 2];

double soma = 0;
int quantidade = 0;

for (int linha = 0; linha < notas.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < notas.GetLength(1); coluna++)
    {
        Console.Write($"Digite a nota para [{linha},{coluna}]: ");
        notas[linha, coluna] = double.Parse(Console.ReadLine()!);

        soma += notas[linha, coluna];
        quantidade++;
    }
}

double media = soma / quantidade;

Console.WriteLine($"\nMédia geral: {media}");
    }
}