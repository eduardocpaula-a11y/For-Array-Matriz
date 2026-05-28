public static class atividade2Array
{ 
    public static void Executar()
    {
        int[]nome = new int[6];

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Digite o numero{i + 1}: ");
            nome[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("\nNúmeros digitados:");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(nome[i]);
        }
    }
}