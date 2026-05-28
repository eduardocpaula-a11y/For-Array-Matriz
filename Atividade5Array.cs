public static class Atividade5Array 
{
    public static void Executar()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o numero {i + 1}:");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }  

        int maior = numeros[0];

        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        Console.WriteLine($"\nMaior numero digitado:{maior}");
    } 
}