public static class Atividade1Array
{ 
    public static void Executar()
    {
        string[]alunos = new string[5];

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i + 1}: ");
            alunos[i] = Console.ReadLine()!;
        }
        Console.WriteLine("\nLista de alunos:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(alunos[i]);
        }
    }
}