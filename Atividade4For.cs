public static class For4
{
    public static void Executar()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine()!);
 
        Console.WriteLine($"Tabuada do {numero}:");
 
        for (int contador = 1; contador <= 10; contador++)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
        }
    }
 }