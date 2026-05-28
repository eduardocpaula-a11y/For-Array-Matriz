public static class Atividade3Array
{
    public static void Executar()
    {
      int [] numeros = new int[5];
      
      int soma = 0;
      
      for (int i = 0; i < 5; i++)
      {
        Console.Write($"Digite o numero {i + 1}");
        numeros[i] = int.Parse(Console.ReadLine()!);

        soma += numeros[i];      
      }
      Console.WriteLine($"\nSoma dos numeros: {soma}");
    }
}