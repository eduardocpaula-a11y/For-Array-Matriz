public static class For5
{
    public static void Executar()
    {
 
        Console.Write("Digite um número para ver a tabuada for: ");
        int numeroFor = int.Parse(Console.ReadLine()!);
 
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numeroFor} x {i} = {numeroFor * i}");
        }
 
   
        Console.Write("Digite um número para ver a tabuada  while: ");
        int numeroWhile = int.Parse(Console.ReadLine()!);
 
        int n = 1;
        while (n <= 10)
        {
            Console.WriteLine($"{numeroWhile} x {n} = {numeroWhile * n}");
            n++;
        }
    }
}