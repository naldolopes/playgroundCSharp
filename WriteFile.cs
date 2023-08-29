class WriteFile
{
    public static void writeFile()
    {
        Console.WriteLine("Por favor, insira um texto:");
        string userInput = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite 's' para sobrescrever ou 'a' para adicionar:");
        char choice = Console.ReadKey().KeyChar;

        string path = "saida.txt";

        try
        {
            switch (choice)
            {
                case 's':
                    File.WriteAllText(path, userInput + Environment.NewLine);
                    Console.WriteLine($"\nTexto salvo com sucesso no arquivo {path}!");
                    break;
                case 'a':
                    File.AppendAllText(path, userInput + Environment.NewLine);
                    Console.WriteLine($"\nTexto adicionado com sucesso ao arquivo {path}!");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao escrever no arquivo: {ex.Message}");
        }
    }
}
