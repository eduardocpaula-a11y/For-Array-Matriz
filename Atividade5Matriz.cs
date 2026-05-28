public static class Atividade5Matriz
{
    public static void Executar ()
    {
double[,] notas = new double[3, 2];

for (int linha = 0; linha < 3; linha++)
{
    double soma = 0;

    Console.WriteLine($"Aluno {linha + 1}");

    for (int coluna = 0; coluna < 2; coluna++)
    {
        Console.Write($"Digite a nota {coluna + 1}: ");
        notas[linha, coluna] = double.Parse(Console.ReadLine()!);

        soma += notas[linha, coluna];
    }

    double media = soma / 2;

    Console.WriteLine($"Média do aluno: {media}");
}
    }
}