public static class Atividade4Array
{
    public static void Executar()
    {
        double[] notas = new double[4];
        
        double soma = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite a nota {i + 1}:");
            notas[i] = double.Parse(Console.ReadLine()!);

            soma += notas[i];
        }
        
        double media = soma / 4;

        Console.WriteLine($"\nMedia final: {media}");
    }
}