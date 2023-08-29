namespace Playground;
class TaskList
{
    static void clearScreen()
    {
        Console.Clear();
    }

    static void showMenu()
    {

        string banner = @"     
  _______        _      _      _     _   
 |__   __|      | |    | |    (_)   | |  
    | | __ _ ___| | __ | |     _ ___| |_ 
    | |/ _` / __| |/ / | |    | / __| __|
    | | (_| \__ \   <  | |____| \__ \ |_ 
    |_|\__,_|___/_|\_\ |______|_|___/\__|

";
        Console.WriteLine(banner);

        Console.WriteLine("1. Add a task");
        Console.WriteLine("2. List tasks");
        Console.WriteLine("3. Exit");
    }

    static void addTask(string path)
    {
        clearScreen();
        Console.WriteLine("Enter a task to do:");
        string userInput = Console.ReadLine() ?? string.Empty;
        File.AppendAllText(path, userInput + Environment.NewLine);
        Console.WriteLine("Task Added...");
        Thread.Sleep(500);
    }

    static void listTasks(string path)
    {
        clearScreen();

        if (File.Exists(path))
        {
            int counter = 1;
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine($"{counter} - {line}");
                counter++;
            }
        }

        Console.Write("Press Any key to return... ");
        Console.ReadLine();
    }


    static public void taskList()
    {
        int choice = 0;
        string path = "tasklist.txt";

        do
        {
            clearScreen();
            showMenu();
            Console.Write("what to do?: ");
            choice = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (choice)
            {
                case 1:
                    addTask(path);
                    break;
                case 2:
                    listTasks(path);
                    break;
                case 3:
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (choice != 3);



    }
}