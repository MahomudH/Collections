using CollectionsTypes.StackApp;
using System.Security.AccessControl;

Stack<Command> undo = new Stack<Command>();
Stack<Command> redo = new Stack<Command>();

string line;
while (true)
{
    Console.Write("Url ('exit' to quit):");
    line = Console.ReadLine().ToLower();

    if (line == "exit")
    {
        break;
    }
    else if (line == "back")
    {
        if(undo.Count > 0)
        {
            redo.Push(undo.Pop());
        }
        else
        {
            continue;
        }
    }
    else if (line == "next")
    {
        if(redo.Count > 0)
        {
            undo.Push(redo.Pop());
        }
        else
        {
            continue;
        }
    }
    else
    {
        undo.Push(new Command(line));
    }
    Console.Clear();// to clear the console window

    print("Back", undo);
    print("Next", redo);
}

static void print(string name,Stack<Command> commands)
{
    Console.WriteLine($"{name} history");
    Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
    foreach (Command command in commands)
    {
        Console.WriteLine($"\t{command}");
    }
    Console.BackgroundColor= ConsoleColor.Black;
}